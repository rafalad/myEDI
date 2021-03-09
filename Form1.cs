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
using System.Net;
using myEDI;

namespace EDISupportTool
{
    public partial class myEDI : Form
    {
        public static int licznik;

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

            LoginDSV login = new LoginDSV();
            WebClient webClient = new WebClient();
            Resources edidirs = new Resources();

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] App is ready to use.");

            edidirs.Dirs();

            if (Resources.listBoxMessageDris != string.Empty)
            {
                listBox1.Items.Add(Resources.listBoxMessageDris);
            }

            this.groupBox1.Paint += this.groupBox_Paint;
            this.groupBox2.Paint += this.groupBox_Paint;
            this.groupBox3.Paint += this.groupBox_Paint;
            this.groupBox4.Paint += this.groupBox_Paint;
            this.groupBox5.Paint += this.groupBox_Paint;
            this.groupBox6.Paint += this.groupBox_Paint;

            //this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.List_RightClick);

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            user.Text = "Logged as: " + userName + " " + "(" + login.Login() + ")";

            ver.Text = "v" + Application.ProductVersion;


            

            /*
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/qiJ05NWB").Contains("1.1.0.5"))
                {
                    if (MessageBox.Show("A new version of myEDI is avaiable. \n Would you like to update now?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start("Updater_myEDI.exe");
                            this.Close();
                        }
                }
            }

            catch
            {

            }
            */
        }



        private void groupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.MidnightBlue, Color.DarkGray);
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
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

        }

        private void EDISupportTool_Load(object sender, EventArgs e)
        {

        }
        /*
        private void SRQnumberField_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SRQnumberField.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only digits.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SRQnumberField.Text = SRQnumberField.Text.Remove(SRQnumberField.Text.Length - 1);
            }
        }
        */
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
            MessageBox.Show("myEDI " + ver.Text + Environment.NewLine + "" + Environment.NewLine +
                "Developed by: " + Environment.NewLine + "" + Environment.NewLine +
                "rafal.adamczyk@dsv.com" + Environment.NewLine + Environment.NewLine +
                "EDI Support Team®", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonOpenSI_Click(object sender, EventArgs e)
        {

        }

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void CreateAnObject_Click(object sender, EventArgs e)
        {
            string selectedSRQ = this.comboBoxSRQ.GetItemText(this.comboBoxSRQ.SelectedItem); //wybieram zmienna z comboboxa

            if (String.IsNullOrEmpty(CHWnumberField.Text) && String.IsNullOrEmpty(SRQidField.Text)) // jezeli nie wybrano CL
            {
                MessageBox.Show("Enter any name and number which refers to the task, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // jezeli spelniono warunki, czyli wybrano numer i nazwe zgloszenia
            {
                if (selectedSRQ == "Standard setup")
                {
                    string CHWnoField = CHWnumberField.Text;
                    string idField = SRQidField.Text;
                    string task = " [standard setup]";

                    Ticket folder = new Ticket();
                    folder.NewTicket(CHWnoField, idField, task);

                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Standard setup folder has been created correctly at:");
                    listBox1.Items.Add(folder.createdfolder);
                    MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (selectedSRQ == "Code list")
                {
                    string CHWnoField = CHWnumberField.Text;
                    string idField = SRQidField.Text;
                    string task = " [code list]";

                    Ticket folder = new Ticket();
                    folder.NewTicket(CHWnoField, idField, task);

                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Code list folder has been created correctly at:");
                    listBox1.Items.Add(folder.createdfolder);
                    MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedSRQ == "None")
                {
                    string CHWnoField = CHWnumberField.Text;
                    string idField = SRQidField.Text;
                    string task = string.Empty;

                    Ticket folder = new Ticket();
                    folder.NewTicket(CHWnoField, idField, task);

                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Folder has been created correctly at:");
                    listBox1.Items.Add(folder.createdfolder);
                    MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            listBox1.Items.Clear();
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
                    //MessageBox.Show(dirs.Count<string>().ToString() + " directories found. Click OK to continue...", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (selected == "QA only")
                    {
                        new Qa();

                        string pathString = Path.Combine(set.deploymentsdir, "note.txt");

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("Note for MS Teams:");
                        listBox1.Items.Add("");

                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }

                        MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (selected == "PROD only")
                    {
                        new Prod();

                        string pathString = Path.Combine(set.deploymentsdir, "note.txt");

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("Note for MS Teams:");
                        listBox1.Items.Add("");

                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }

                        MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (selected == "both - QA & PROD")
                    {
                        new Qaprod();

                        string pathString = Path.Combine(set.deploymentsdir, "note.txt");

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("Note for MS Teams:");
                        listBox1.Items.Add("");

                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }

                        MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
        }

        private void buttonOpenLW_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateDeployDirs_Click(object sender, EventArgs e)
        {
            Kit set = new Kit();
            set.CreateDirDEPLOYMENTS();
        }

        private void buttonCreateEDIDirs_Click(object sender, EventArgs e)
        {

        }

        private void CHWnumberField_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show(@"RT exported files:  " + i + Environment.NewLine +
                                @"LW exported files:  " + j + Environment.NewLine +
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
            Kit set = new Kit();

            query.Query();
        }

        private void button_SSH_Click(object sender, EventArgs e)
        {
            LoginDSV login = new LoginDSV();

            string selected = this.deployComboBox.GetItemText(this.deployComboBox.SelectedItem); //wybieram zmienna z comboboxa

            if (String.IsNullOrEmpty(selected)) // jezeli nie wybrano srodowiska
            {
                MessageBox.Show("Please select the deployment environment first.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // jezeli wybrano srodowisko, to kontynuuj dla wybranego srodowiska
            {
                if (selected == "QA only")
                {
                    ProcessStartInfo cmd = new ProcessStartInfo();
                    cmd.FileName = @"C:\Program Files\PuTTY\putty.exe";
                    cmd.UseShellExecute = false;
                    cmd.RedirectStandardInput = false;
                    cmd.RedirectStandardOutput = true;
                    cmd.Arguments = "-ssh " + login.Login() + "@" + "qsiapp1.dsv.com" + " 22 " + "-pw " + login.Login() + "";
                    using (Process process = Process.Start(cmd))
                    {
                        process.WaitForExit();
                    }
                }
                else if (selected == "PROD only")
                {
                    ProcessStartInfo cmd = new ProcessStartInfo();
                    cmd.FileName = @"C:\Program Files\PuTTY\putty.exe";
                    cmd.UseShellExecute = false;
                    cmd.RedirectStandardInput = false;
                    cmd.RedirectStandardOutput = true;
                    cmd.Arguments = "-ssh " + login.Login() + "@" + "psiapp1.dsv.com" + " 22 " + "-pw " + login.Login() + "";
                    using (Process process = Process.Start(cmd))
                    {
                        process.WaitForExit();
                    }
                }
                else if (selected == "both - QA & PROD")
                {
                    ProcessStartInfo cmd1 = new ProcessStartInfo();
                    cmd1.FileName = @"C:\Program Files\PuTTY\putty.exe";
                    cmd1.UseShellExecute = false;
                    cmd1.RedirectStandardInput = false;
                    cmd1.RedirectStandardOutput = true;
                    cmd1.Arguments = "-ssh " + login.Login() + "@" + "qsiapp1.dsv.com" + " 22 " + "-pw " + login.Login() + "";
                    using (Process process = Process.Start(cmd1))
                    {
                        process.WaitForExit();
                    }

                    ProcessStartInfo cmd2 = new ProcessStartInfo();
                    cmd2.FileName = @"C:\Program Files\PuTTY\putty.exe";
                    cmd2.UseShellExecute = false;
                    cmd2.RedirectStandardInput = false;
                    cmd2.RedirectStandardOutput = true;
                    cmd2.Arguments = "-ssh " + login.Login() + "@" + "psiapp1.dsv.com" + " 22 " + "-pw " + login.Login() + "";
                    using (Process process = Process.Start(cmd2))
                    {
                        process.WaitForExit();
                    }
                }
            }
        }

        private void richTextBoxSelectedEnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void deployDirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kit set = new Kit();
            set.CreateDirDEPLOYMENTS();
        }

        private void eDIDirsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kit set = new Kit();
            set.CreateDirEDI();
        }
        */
        private void sIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:15501/dashboard/");
            Process.Start("http://tsiapp1:15501/dashboard/");
            Process.Start("http://qsiapp1:15501/dashboard/");
            Process.Start("http://psiapp1:15501/dashboard/");
        }

        private void lightwellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:16680/lw/client/index.html#/login");
            Process.Start("http://tsiapp2:16680/lw/client/index.html#/login");
            Process.Start("http://qsiapp1:16680/lw/client/index.html#/login");
            Process.Start("http://psiapp2:16680/lw/client/index.html#/login");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(Environment.NewLine, listBox1.Items.OfType<string>())); /// aby móc kopiować zawartość listboxa do schowka
        }

        private void codeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ver_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:15501/dashboard/");
            Process.Start("http://tsiapp1:15501/dashboard/");
            Process.Start("http://qsiapp1:15501/dashboard/");
            Process.Start("http://psiapp1:15501/dashboard/");
        }

        private void lWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:16680/lw/client/index.html#/login");
            Process.Start("http://tsiapp2:16680/lw/client/index.html#/login");
            Process.Start("http://qsiapp2:16680/lw/client/index.html#/login");
            Process.Start("http://psiapp2:16680/lw/client/index.html#/login");
        }

        private void aboutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("myEDI " + ver.Text + Environment.NewLine + "" + Environment.NewLine +
                "Developed by: " + Environment.NewLine + "" + Environment.NewLine +
                "rafal.adamczyk@dsv.com" + Environment.NewLine + Environment.NewLine +
                "EDI Support Team®", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		public void buttonGoLDAP_Click(object sender, EventArgs e)
		{
            Resources ftp = new Resources();
            bool form = checkBoxLDAP.Checked;

            if (form == true)
            {
                if (File.Exists(@"C:\EDI\Templates\procedureftp.doc"))
                {
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Doc template found.");
                }
                else
                {
                    ftp.FTPdoc();
                    listBox1.Items.Add(Resources.listBoxMessageFTPdoc);
                }    
            }

                string selectedLDAP = this.comboBoxLDAP.GetItemText(this.comboBoxLDAP.SelectedItem); //wybieram zmienna z comboboxa

                string textbox = textBoxAddUserLDAP.Text;

                Ldap account = new Ldap();
                account.LdapAccount(selectedLDAP, textbox, form);

                listBox1.Items.Add(Ldap.listBoxMessage1);
                listBox1.Items.Add(Ldap.listBoxMessage2);

                if (form == true) //jezeli wybrano checkbox z formularzem to pobierz kolejne komunikaty o utworzeniu dokumentu FTP.
                {
                listBox1.Items.Add(Ldap.listBoxMessage3);
                listBox1.Items.Add(Ldap.listBoxMessage4);
                }
        }

		private void checkBoxLDAP_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void createDirResourcesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Resources dir = new Resources();
            dir.Dirs();
        }
	}
}

