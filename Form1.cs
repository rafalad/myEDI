using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace myEDI
{
    public partial class myEDI : Form
    {
		public myEDI()
        {
            this.InitializeComponent();

            LoginDSV login = new LoginDSV();
            WebClient webClient = new WebClient();
            Resources resource = new Resources();

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] "+"Logged as: " + userName + " " + "(" + login.Login() + ")");
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] "+"App is ready to use.");

            resource.Dirs();
            resource.DocDirCleanUp();

            if (Resources.listBoxMessageDris != string.Empty) //jezeli nie znaleziono folderow i byla potrzeba ich utworzenia to zwroc komuniakt
            {
                listBox1.Items.Add(Resources.listBoxMessageDris);
            }

            this.groupBox1.Paint += this.groupBox_Paint;
            this.groupBox2.Paint += this.groupBox_Paint;
            this.groupBox3.Paint += this.groupBox_Paint;
            this.groupBox4.Paint += this.groupBox_Paint;
            this.groupBox5.Paint += this.groupBox_Paint;
            this.groupBox6.Paint += this.groupBox_Paint;
            
            ver.Text = "v" + Application.ProductVersion;

            Task.Delay(3000).ContinueWith(t => resource.LogToFTP()); //zapisz log na serwerze z opoźnieniem 3s

            latest_ver.Text = resource.CheckVersion(); //kontrola wersji programu

            richTextBoxSelectedEnv.Text = deployComboBox.Text; // kontrolka wyboru srodowiska dla deploya
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

        private void OnWyjdz(object sender, EventArgs ea)
        {
            Application.Exit();
        }

        private void EDISupportTool_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAddUserLDAP_TextChanged(object sender, EventArgs e)
        {
            textBoxAddUserLDAP.CharacterCasing = CharacterCasing.Lower;
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

        /*
        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        */
        private void CreateAnObject_Click(object sender, EventArgs e)
        {
            ExtractResource click = new ExtractResource();

            // jezeli zaznaczono opcje z formularzem
            if (checkBoxSRQ.Checked)
            {
                //pobierz formularz
                Directory.CreateDirectory(@"C:\EDI\doc_temp");

                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

                click.Extract("myEDI", @"C:\EDI\doc_temp", "Resources", "deploy_request.docx");
                Workspace();
            }
            // jezeli bez formularza, to nie pobieraj szablonu
            else
            {
                Workspace();
            }
        }

        private void Workspace()
        {
            bool form = checkBoxSRQ.Checked;
            string selectedSRQ = this.comboBoxSRQ.GetItemText(this.comboBoxSRQ.SelectedItem); //wybieram zmienna z comboboxa
            
                if (String.IsNullOrEmpty(CHWnumberField.Text) && String.IsNullOrEmpty(SRQidField.Text))
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
                    folder.NewTicket(CHWnoField, idField, task, form);

                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Standard setup folder has been created correctly at:");
                    listBox1.Items.Add(folder.createdfolder);

                    //Zwróć informacje o utworzonym dokumencie jezeli zostal wybrany i utworzony katalog ma w nazwie SRQ
                    if (form == true && folder.createdfolder.Substring(7, 3) == "SRQ")
                    {
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] The EDI Deploy Request document generated successfully.");
                    }

                    if (MessageBox.Show("Folder created. \n Would you like to open it?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(folder.createdfolder);
                        }
                    }
          
                    else if (selectedSRQ == "Code list")
                    {
                        string CHWnoField = CHWnumberField.Text;
                        string idField = SRQidField.Text;
                        string task = " [code list]";

                        Ticket folder = new Ticket();
                        folder.NewTicket(CHWnoField, idField, task, form);

                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Code list folder has been created correctly at:");
                        listBox1.Items.Add(folder.createdfolder);

                    //Zwróć informacje o utworzonym dokumencie jezeli zostal wybrany i utworzony katalog ma w nazwie SRQ
                    if (form == true && folder.createdfolder.Substring(7, 3) == "SRQ")
                    {
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] The EDI Deploy Request document generated successfully.");
                    }

                    if (MessageBox.Show("Folder created. \n Would you like to open it?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(folder.createdfolder);
                        }
                    }
                    else if (selectedSRQ == "None")
                    {
                        string CHWnoField = CHWnumberField.Text;
                        string idField = SRQidField.Text;
                        string task = string.Empty;

                        Ticket folder = new Ticket();
                        folder.NewTicket(CHWnoField, idField, task, form);

                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Folder has been created correctly at:");
                        listBox1.Items.Add(folder.createdfolder);

                    //Zwróć informacje o utworzonym dokumencie jezeli zostal wybrany i utworzony katalog ma w nazwie SRQ
                    if (form == true && folder.createdfolder.Substring(7, 3) == "SRQ")
                    {
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] The EDI Deploy Request document generated successfully.");
                    }

                    if (MessageBox.Show("Folder created. \n Would you like to open it?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(folder.createdfolder);
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
            //1. Oczysc i przygotuj katalogi
            Resources dir = new Resources();
            dir.PrepareDirs();

            //2. Przygotuj pliki do utworzenia notatki i skryptu
            using (FileStream fs = File.Create(@"C:\DEPLOYMENTS\msteams_note.txt", 1024))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                fs.Write(info, 0, info.Length);
            }
            using (FileStream fs = File.Create(@"C:\DEPLOYMENTS\query.txt", 1024))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                fs.Write(info, 0, info.Length);
            }

            //3. Generuj notatke zgodnie z wybranymi parametrami

            if (checkBox_RT.Checked)
            {
                extractRT();
                if (checkBox_Query.Checked)
                {
                    note(new object(), new EventArgs());
                    consoleQuery();
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
                    note(new object(), new EventArgs());
                    consoleQuery();
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

            var dirs = from dir in Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*") select dir;

            if (dirs.Count<string>() == 0) //jezeli nie ma folderow do wdrozenia
            {
                MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // jezeli folder sa
            {
                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

                if (String.IsNullOrEmpty(selected)) // jezeli nie wybrano srodowiska
                {
                    MessageBox.Show(dirs.Count<string>().ToString() + " directories found, but not selected deployment environment.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // jezeli wybrano srodowisko, to zwroc informacje i kontynuuj dla wybranego srodowiska
                {
                    if (selected == "QA only")
                    {
                        new Qa();

                        string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + dirs.Count<string>().ToString() + ". dir found. MS Teams note created.");
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

                        string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
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

                        string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

                        string[] lines = File.ReadAllLines(pathString);
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
                        listBox1.Items.Add("");

                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }

                        MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            listBox1.Items.Add("");
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

        public void VisibilityOfPasswordButtons()
        {
            string selectedType = this.comboBoxPass.GetItemText(this.comboBoxPass.SelectedItem); //wybieram zmienna z comboboxa

            if (selectedType == "single")
            {
                buttonMoreSettings.Enabled = false;
            }
        }

        private void buttonGenerateRandomPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordGenerator.NewPassword());
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
            MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CHWnumberField_TextChanged(object sender, EventArgs e)
        {

        }

        public void extractRT_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\DEPLOYMENTS\msteams_note.txt"))
            {
                if (new FileInfo(@"C:\DEPLOYMENTS\msteams_note.txt").Length == 0)
                {
                    MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    extractRT();
                    MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void extractRT()
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
                //MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + @"RT for SI exported files:  " + i + @" + Lightwell RT files:  " + j + @" + SQL files:  " + k);
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
            string path = @"C:\DEPLOYMENTS\My_Logs.txt";

            string[] lines = File.ReadAllLines(path);
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Checking logs:");
            listBox1.Items.Add("");

            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
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
            if (File.Exists(@"C:\DEPLOYMENTS\query.txt"))
            {
                if (new FileInfo(@"C:\DEPLOYMENTS\query.txt").Length == 0)
                {
                    MessageBox.Show("It looks like the deployment process hasn't been completed yet ... syntax file is empty.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Process.Start(@"C:\DEPLOYMENTS\query.txt");
                }
            }
            else
            {
                MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void consoleQuery()
        {
            ConsoleQuery query = new ConsoleQuery();
            Kit set = new Kit();

            query.Query();
        }
        
        private void richTextBoxSelectedEnv_TextChanged(object sender, EventArgs e)
        {

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
        
        private void lWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:16680/lw/client/index.html#/login");
            Process.Start("http://tsiapp2:16680/lw/client/index.html#/login");
            Process.Start("http://qsiapp1:16680/lw/client/index.html#/login");
            Process.Start("http://psiapp2:16680/lw/client/index.html#/login");
        }

        private void sIToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("http://dsidb1:15501/dashboard/");
            Process.Start("http://tsiapp2:15501/dashboard/");
            Process.Start("http://qsiapp1:15501/dashboard/");
            Process.Start("http://psiapp2:15501/dashboard/");
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
            ExtractResource FTPdoc = new ExtractResource();

            // jezeli nie wybrano dlugosci hasla
            if (checkBoxPass8.Checked == false && checkBoxPass16.Checked == false && checkBoxPass24.Checked == false)
            {
                MessageBox.Show(@"Choose your password length and try again.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // jezeli zaznaczono opcje z formularzem
                if (checkBoxLDAP.Checked)
                {
                    Directory.CreateDirectory(@"C:\EDI\doc_temp");

                    FTPdoc.Extract("myEDI", @"C:\EDI\doc_temp", "Resources", "procedureftp.doc");
                    //kontynuuj prace na formularzu
                    LDAP();
                }

                // jezeli bez formularza, to nie pobieraj szablonu
                else
                {
                    LDAP();
                }
            }
        }

        private void LDAP()
        {
            Resources ftp = new Resources();
            Ldap account = new Ldap();
            bool form = checkBoxLDAP.Checked;

            string selectedLDAP = this.comboBoxLDAP.GetItemText(this.comboBoxLDAP.SelectedItem); //wybieram zmienna z comboboxa
            string textbox = textBoxAddUserLDAP.Text;
            int length = 0;

            //na podstawie zaznaczonego checkboxa ustawiam dlugosc hasla
            if (checkBoxPass8.Checked)
            {
                 length = 8;
            }
            if (checkBoxPass16.Checked)
            {
                 length = 16;
            }
            if (checkBoxPass24.Checked)
            {
                 length = 24;
            }



            if (form == true)
            {
                if (File.Exists(@"C:\EDI\doc_temp\procedureftp.doc"))
                {
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

                    account.LdapAccount(selectedLDAP, textbox, form, length);

                    listBox1.Items.Add(Ldap.listBoxMessage1);
                    listBox1.Items.Add(Ldap.listBoxMessage2);
                    listBox1.Items.Add(Ldap.listBoxMessage3);
                    listBox1.Items.Add(Ldap.listBoxMessage4);
                }
                else
                {
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Doc template could not be processed... Procedure stopped, please try again without form.");
                    MessageBox.Show(@"Failed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                account.LdapAccount(selectedLDAP, textbox, form, length);

                listBox1.Items.Add(Ldap.listBoxMessage1);
                //listBox1.Items.Add(Ldap.listBoxMessage2);
            }
            if (MessageBox.Show("Process completed. \n Would you like to move to the directory?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(@"C:\EDI");
            }
        }

        private void checkBoxLDAP_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBoxLDAP.Checked)
                checkBoxLDAPno.Checked = false;
            else
                checkBoxLDAPno.Checked = true;

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxLDAPno.Checked)
                checkBoxLDAP.Checked = false;
            else
                checkBoxLDAP.Checked = true;
        }

        private void createDirResourcesToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Resources dir = new Resources();
            dir.Dirs();
            MessageBox.Show(@"Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		private void cleanEventViewerToolStripMenuItem_Click(object sender, EventArgs e)
		{
            listBox1.Items.Clear();
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
        }

		private void fTPProcedureToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ExtractResource click = new ExtractResource();

            string path = "C:\\EDI\\temp\\procedureftp.doc";
            string pathToHide = "C:\\EDI\\temp";

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

            click.Extract("myEDI", @"C:\EDI\temp", "Resources", "procedureftp.doc");
            Process.Start(path);

            File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
        }

		private void multipleEntriesCLToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ExtractResource click = new ExtractResource();

            string path = "C:\\EDI\\temp\\CodeListTool.xls";
            string pathToHide = "C:\\EDI\\temp";

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

            click.Extract("myEDI", @"C:\EDI\temp", "Resources", "CodeListTool.xls");
            Process.Start(path);

            File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
        }

		private void deployRequestToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ExtractResource click = new ExtractResource();

            string path = "C:\\EDI\\temp\\deploy_request.docx";
            string pathToHide = "C:\\EDI\\temp";

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

            click.Extract("myEDI", @"C:\EDI\temp", "Resources", "deploy_request.docx");
            Process.Start(path);

            File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
        }

		private void gentranGenericListToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Resources dir = new Resources();
            ExtractResource click = new ExtractResource();

            string path = "C:\\EDI\\temp\\Generic_list_adjustment_date.xls";
            string pathToHide = "C:\\EDI\\temp";

            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

            click.Extract("myEDI", @"C:\EDI\temp", "Resources", "Generic_list_adjustment_date.xls");
            Process.Start(path);

            File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
        }

		private void comboBoxLDAP_SelectedIndexChanged(object sender, EventArgs e)
		{
            // ta metoda aktywuje / dezaktywuje opcje dla okreslonych plikow LDAP

            string selectedLDAP = this.comboBoxLDAP.GetItemText(this.comboBoxLDAP.SelectedItem);

            if (selectedLDAP == "Modify user" || selectedLDAP == "Delete user" || selectedLDAP == "Remove SSHkey")
            {
                checkBoxLDAP.Checked = false;
                checkBoxLDAP.Enabled = false;
                checkBoxLDAPno.Enabled = false;
            }
            else
            {
                checkBoxLDAP.Checked = true;
                checkBoxLDAP.Enabled = true;
                checkBoxLDAPno.Enabled = true;
            }
            
            if (selectedLDAP == "Delete user" || selectedLDAP == "Remove SSHkey")
            {
                checkBoxPass8.Enabled = false;
                checkBoxPass16.Enabled = false;
                checkBoxPass24.Enabled = false;
            }
            else
            {
                checkBoxPass8.Enabled = true;
                checkBoxPass16.Enabled = true;
                checkBoxPass24.Enabled = true;
            }
            
        }

		private void comboBoxSRQ_SelectedIndexChanged(object sender, EventArgs e)
		{
            //Ta metoda wyłącza możliwość generowania formularza dla zadań typu Code list

            string selectedSRQ = this.comboBoxLDAP.GetItemText(this.comboBoxSRQ.SelectedItem);

            if (selectedSRQ == "Code list")
            {
                checkBoxSRQ.Checked = false;
                checkBoxSRQ.Enabled = false;
            }
            else
            {
                checkBoxSRQ.Checked = true;
                checkBoxSRQ.Enabled = true;
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            PassSettings PassSettings = new PassSettings();
            PassSettings.Show();
        }

		private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxPass8_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBoxPass8.Checked)
            {
                MessageBox.Show(@"The current LDAP script only supports 24 character passwords. Consider a 24-character password.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBoxPass16.Checked = false;
                checkBoxPass24.Checked = false;
            }
		}

		private void checkBoxPass16_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBoxPass16.Checked)
            {
                MessageBox.Show(@"The current LDAP script only supports 24 character passwords. Consider a 24-character password.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBoxPass8.Checked = false;
                checkBoxPass24.Checked = false;
            }
        }

		private void checkBoxPass24_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBoxPass24.Checked)
            {
                checkBoxPass8.Checked = false;
                checkBoxPass16.Checked = false;
            }
        }

		private void comboBoxPass_SelectedIndexChanged(object sender, EventArgs e)
		{
            string selectedType = this.comboBoxPass.GetItemText(this.comboBoxPass.SelectedItem); //wybieram zmienna z comboboxa

            if (selectedType == "multiple")
            {
                buttonMoreSettings.Enabled = true;
                buttonGenerateRandomPassword.Enabled = false;
            }
            else
            {
                buttonMoreSettings.Enabled = false;
                buttonGenerateRandomPassword.Enabled = true;
            }
        }
	}
}

