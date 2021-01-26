using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace EDISupportTool
{
    public partial class myEDI : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void Component()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myEDI));
            this.SuspendLayout();
            // 
            // EDISupportTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myEDI";
            this.Text = "myEDI";
            this.ResumeLayout(false);

        }

        public myEDI()
        {
            this.InitializeComponent();
        }
        private void OnWyswietlKomunikat(object sender, EventArgs ea)
        {

        }
        private void OnWyjdz(object sender, EventArgs ea)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAddUserLDAP.Text))
            {
                MessageBox.Show("Enter user account name please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string fileName = "addUser_" + textBoxAddUserLDAP.Text + ".txt";
                string[] lines = { "userName=" + textBoxAddUserLDAP.Text, "password=" + PasswordGenerator.NewPasswordforFile() };
                string path = Path.Combine(@"C:\EDI\", fileName);
                File.WriteAllLines(path, lines);

                MessageBox.Show(@"File has been created in C:\EDI\", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EDISupportTool_Load(object sender, EventArgs e)
        {

        }

        private void SRQnumberField_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SRQnumberField.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SRQnumberField.Text = SRQnumberField.Text.Remove(SRQnumberField.Text.Length - 1);
            }
        }

        private void textBoxAddUserLDAP_TextChanged(object sender, EventArgs e)
        {
            textBoxAddUserLDAP.CharacterCasing = CharacterCasing.Lower;

        }

        private void buttonOpenConsole_Click(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by: " + Environment.NewLine + "" + Environment.NewLine +
                "rafal.adamczyk@dsv.com" + Environment.NewLine + Environment.NewLine +
                "EDI Support Team®", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonOpenSI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dsidb1:15501/dashboard/");
            System.Diagnostics.Process.Start("http://tsiapp1:15501/dashboard/");
            System.Diagnostics.Process.Start("http://qsiapp1:15501/dashboard/");
            System.Diagnostics.Process.Start("http://psiapp1:15501/dashboard/");
        }

        private void CreateAnObject_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(CHWnumberField.Text))
            {
                if (String.IsNullOrEmpty(SRQnumberField.Text))
                {
                    MessageBox.Show("Enter the SRQ/ID values you are working on, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(SRQidField.Text))
                {
                    MessageBox.Show("Enter any name which refers to the task, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    string folder_name = "DSV_SRQ" + SRQnumberField.Text + "_" + SRQidField.Text + "_1.0_rt";
                    string folder_path = Path.Combine(@"C:\EDI", folder_name);
                    Directory.CreateDirectory(folder_path);

                    MessageBox.Show("RT folder has been created correctly at: " + folder_path, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string setvalue = CHWnumberField.Text;
                string type = string.Empty;
                string no = string.Empty;

                string type_srq = "DSV_SRQ";
                string type_inc = "DSV_INC";


                //przechodzę o po znakach w poszukiwania liczb, jeżeli znajdę to przypisuję do zmiennej
                for (int i = 0; i < setvalue.Length; i++)
                {
                    if (Char.IsDigit(setvalue[i]))
                        no += setvalue[i];

                }
                //przechodzę o po znakach w poszukiwania liter, jeżeli znajdę to przypisuję do zmiennej
                for (int i = 0; i < setvalue.Length; i++)
                {
                    if (Char.IsLetter(setvalue[i]))
                        type += setvalue[i];
                }

                if (type == "Incident")
                {
                    if (String.IsNullOrEmpty(SRQidField.Text))
                    {
                        MessageBox.Show("Enter any name which refers to the task, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        string folder = type_inc + no + "_" + SRQidField.Text + "_1.0_rt";
                        string path = Path.Combine(@"C:\EDI", folder);
                        Directory.CreateDirectory(path);

                        MessageBox.Show("RT folder has been created correctly at: " + path, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(SRQidField.Text))
                    {
                        MessageBox.Show("Enter any name which refers to the task, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        string folder = type_srq + no + "_" + SRQidField.Text + "_1.0_rt";
                        string path = Path.Combine(@"C:\EDI", folder);
                        Directory.CreateDirectory(path);

                        MessageBox.Show("RT folder has been created correctly at: " + path, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void SRQidField_TextChanged(object sender, EventArgs e)
        {
            SRQidField.CharacterCasing = CharacterCasing.Upper;
        }

        private void deployComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxSelectedEnv.Text = deployComboBox.Text;
        }

        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            string selected = deployComboBox.Text;

            if (String.IsNullOrEmpty(selected))
            {
                MessageBox.Show(@"Please select the deployment environment first.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkBox_RT.Checked)
                {
                    extractRT_button_Click(new object(), new EventArgs());
                    if (checkBox_Query.Checked)
                    {
                        consoleQuery_button_Click(new object(), new EventArgs());
                        note(new object(), new EventArgs());
                    }
                    else
                    {
                        note(new object(), new EventArgs());
                    }
                }
                else
                {
                    if (checkBox_Query.Checked)
                    {
                        consoleQuery_button_Click(new object(), new EventArgs());
                        note(new object(), new EventArgs());
                    }
                    else
                    {
                        note(new object(), new EventArgs());
                    }
                }
            }
        }

        public void note(object sender, EventArgs e)
        {
            Kit set = new Kit();
            string selected = this.deployComboBox.GetItemText(this.deployComboBox.SelectedItem); //wybieram zmienna z comboboxa

            int day = set.Day();
            string month = set.Month();

            // LINQ query.
            var dirs = from dir in
                         Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*")
                       select dir;

            Console.WriteLine();

            if (dirs.Count<string>() == 0) //jezeli nie ma folderow do wdrozenia
            {
                MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // jezeli folder sa
            {
                if (String.IsNullOrEmpty(selected)) // jezeli nie wybrano srodowiska
                {
                    MessageBox.Show(dirs.Count<string>().ToString() + " directories found, but not selected deployment environment.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // jezeli wybrano srodowisko, to zwroc informacje i kontynuuj dla wybranego srodowiska
                {
                    MessageBox.Show(dirs.Count<string>().ToString() + " directories found. Click OK to continue...", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (selected == "QA only")
                    {
                        new Qa();
                    }
                    else if (selected == "PROD only")
                    {
                        new Prod();
                    }
                    else if (selected == "both - QA & PROD")
                    {
                        new Qaprod();
                    }
                }
            }
        }

        private void buttonCL_Click(object sender, EventArgs e)
        {
            string selectedCL = this.codeListComboBox.GetItemText(this.codeListComboBox.SelectedItem); //wybieram zmienna z comboboxa

            if (String.IsNullOrEmpty(selectedCL)) // jezeli nie wybrano CL
            {
                MessageBox.Show("Please select the type of flow", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // jezeli wybrano srodowisko, to zwroc informacje i kontynuuj dla wybranego srodowiska
            {
                if (selectedCL == "Inbound")
                {
                    Form_InboundCL InboundForm = new Form_InboundCL();
                    InboundForm.Show();
                }
                else if (selectedCL == "Outbound")
                {
                    Form_OutboundCL OnboundForm = new Form_OutboundCL();
                    OnboundForm.Show();
                }
                else if (selectedCL == "both")
                {
                    Form_bothCL bothCLForm = new Form_bothCL();
                    bothCLForm.Show();
                }
            }
        }

        private void buttonGenerateRandomPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordGenerator.NewPassword());
            MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenLW_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dsidb2:16680/lw/client/index.html#/login");
            System.Diagnostics.Process.Start("http://tsiapp2:16680/lw/client/index.html#/login");
            System.Diagnostics.Process.Start("http://qsiapp2:16680/lw/client/index.html#/login");
            System.Diagnostics.Process.Start("http://psiapp2:16680/lw/client/index.html#/login");
        }

        private void buttonCreateDeployDirs_Click(object sender, EventArgs e)
        {
            Kit set = new Kit();
            set.CreateDirDEPLOYMENTS();
        }

        private void buttonCreateEDIDirs_Click(object sender, EventArgs e)
        {
            Kit set = new Kit();
            set.CreateDirEDI();
        }

        private void CHWnumberField_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_folder_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SRQnumberField.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SRQnumberField.Text = SRQnumberField.Text.Remove(SRQnumberField.Text.Length - 1);
            }
        }

       

		public void extractRT_button_Click(object sender, EventArgs e)
		{
            Kit set = new Kit();
            int day = set.Day();
            string month = set.Month();

            // LINQ query.
            var dirs = from dir in
                         Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*")
                       select dir;

            if (dirs.Count<string>() == 0) //jezeli nie ma paczek do wdrozenia
            {
                MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // jezeli paczki sa, to stworz foldery RT i LW i skopiuj pliki .xml
            {
                string targetPath_RT = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "RT");
                string tagretPath_LW = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "LW");
                string tagretPath_SQL = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "SQL");

                int i = 0;
                int j = 0;
                int k = 0;

                Directory.CreateDirectory(targetPath_RT);
                Directory.CreateDirectory(tagretPath_LW);
                Directory.CreateDirectory(tagretPath_SQL);

                string[] rt_array = Directory.GetFiles(set.DeployPath(), "*exp.xml", SearchOption.AllDirectories);
                foreach (string rt_file in rt_array)
                {
                    i = i + 1;
                    string fileName = Path.GetFileName(rt_file);
                    string destFile = Path.Combine(targetPath_RT, fileName);
                    File.Copy(rt_file, destFile, true);
                }

                string[] lw_array = Directory.GetFiles(set.DeployPath(), "*_f*.xml", SearchOption.AllDirectories);
                foreach (string lw_file in lw_array)
                {
                    j = j + 1;
                    string fileName = Path.GetFileName(lw_file);
                    string destFile = Path.Combine(tagretPath_LW, fileName);
                    File.Copy(lw_file, destFile, true);
                }

                string[] sql_array = Directory.GetFiles(set.DeployPath(), "*.sql", SearchOption.AllDirectories);
                foreach (string sql_file in sql_array)
                {
                    k = k + 1;
                    string fileName = Path.GetFileName(sql_file);
                    string destFile = Path.Combine(tagretPath_SQL, fileName);
                    File.Copy(sql_file, destFile, true);
                }

                MessageBox.Show(@"RT exported files:  "+ i + Environment.NewLine +
                                @"LW exported files:  "+ j + Environment.NewLine +
                                @"SQL exported files:  " + k,
                                "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

		private void button5_Click(object sender, EventArgs e)
		{
            Process.Start(@"C:\DEPLOYMENTS\DEPLOY");
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBox_RT.Checked)
            {
                extractRT_button.Enabled = true;
            }
            else
            {
                extractRT_button.Enabled = false;
            }
        }

		private void button_logs_Click(object sender, EventArgs e)
		{
            Process.Start(@"C:\DEPLOYMENTS\My_Logs.txt");
        }

		private void button_resources_Click(object sender, EventArgs e)
		{
            Process.Start(@"C:\DEPLOYMENTS\RESOURCES");
        }

		private void button_reports_Click(object sender, EventArgs e)
		{
            Process.Start(@"C:\DEPLOYMENTS\Reports");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

        }

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBox_Query.Checked)
            {
                consoleQuery_button.Enabled = true;
            }
            else
            {
                consoleQuery_button.Enabled = false;
            }
        }

		private void consoleQuery_button_Click(object sender, EventArgs e)
		{
            ConsoleQuery query = new ConsoleQuery();
            query.Query();
		}
	}
}

