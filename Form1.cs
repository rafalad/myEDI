using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myEDI
{
	public partial class MyEDI : Form
	{
		public MyEDI()
		{
			InitializeComponent();

			Start();
		}

		private void Start()
		{
			LoginDSV name = new LoginDSV();
			WebClient webClient = new WebClient();
			Resources resource = new Resources();

			string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");

			resource.Dirs();
			resource.DocDirCleanUp();

			if (Resources.listBoxMessageDris != string.Empty) //jezeli nie znaleziono folderow i byla potrzeba ich utworzenia to zwroc komuniakt
			{
				ListBox(Resources.listBoxMessageDris);
			}

			groupBox1.Paint += GroupBox_Paint;
			groupBox2.Paint += GroupBox_Paint;
			groupBox3.Paint += GroupBox_Paint;
			groupBox4.Paint += GroupBox_Paint;
			groupBox5.Paint += GroupBox_Paint;
			groupBox6.Paint += GroupBox_Paint;

			ver.Text = "v" + Application.ProductVersion;

			Task.Delay(3000).ContinueWith(t => resource.LogToFTP()); //zapisz log na serwerze z opoźnieniem

			latest_ver.Text = resource.CheckVersion(); //kontrola wersji programu

			richTextBoxSelectedEnv.Text = deployComboBox.Text; // kontrolka wyboru srodowiska dla deploya
		}

		private void GroupBox_Paint(object sender, PaintEventArgs e)
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

				g.Clear(BackColor);

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

		private void EDISupportTool_Load(object sender, EventArgs e)
		{

		}

		private void TextBoxAddUserLDAP_TextChanged(object sender, EventArgs e)
		{
			textBoxAddUserLDAP.CharacterCasing = CharacterCasing.Lower;
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("myEDI " + ver.Text + Environment.NewLine + "" + Environment.NewLine +
				"Developed by: " + Environment.NewLine + "" + Environment.NewLine +
				"rafal.adamczyk@dsv.com" + Environment.NewLine + Environment.NewLine +
				"EDI Support Team®", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void MinimizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void CreateAnObject_Click(object sender, EventArgs e)
		{
			ExtractResource click = new ExtractResource();

			// jezeli zaznaczono opcje z formularzem
			if (checkBoxSRQ.Checked)
			{
				//pobierz formularz
				Directory.CreateDirectory(@"C:\EDI\doc_temp");

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

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
			bool setup = checkBox_setup.Checked;
			bool maps = checkBox_maps.Checked;
			bool codelist = checkBox_cl.Checked;
			bool other = checkBox_other.Checked;

			string selectedFlow = comboBox_setup.GetItemText(comboBox_setup.SelectedItem); //wybieram zmienna z comboboxa

			if (String.IsNullOrEmpty(CHWnumberField.Text) && String.IsNullOrEmpty(SRQidField.Text))
			{
				MessageBox.Show("Enter any name and number which refers to the task, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else // jezeli spelniono warunki, czyli wybrano numer i nazwe zgloszenia
			{
				if (setup == true)
				{
					string task = " [STD LW Setup]";

					switch (selectedFlow)
					{
						case "other":
							string subdir1 = "other";
							WorkspaceFolder(subdir1, task);
							break;

						case "CL both flows":
							string subdir2 = "CL both flows";
							WorkspaceFolder(subdir2, task);
							break;

						case "CL in":
							string subdir3 = "CL in";
							WorkspaceFolder(subdir3, task);
							break;

						case "CL out":
							string subdir4 = "CL out";
							WorkspaceFolder(subdir4, task);
							break;

						case "CW in":
							string subdir5 = "CW in";
							WorkspaceFolder(subdir5, task);
							break;

						case "CW out":
							string subdir6 = "CW out";
							WorkspaceFolder(subdir6, task);
							break;

						case "CW both flows":
							string subdir7 = "CW both flows";
							WorkspaceFolder(subdir7, task);
							break;

						case "CW1 both flows":
							string subdir8 = "CW1 both flows";
							WorkspaceFolder(subdir8, task);
							break;

						case "CW1 in":
							string subdir9 = "CW1 in";
							WorkspaceFolder(subdir9, task);
							break;

						case "CW1 out":
							string subdir10 = "CW1 out";
							WorkspaceFolder(subdir10, task);
							break;

						case "myDSV":
							string subdir11 = "myDSV";
							WorkspaceFolder(subdir11, task);
							break;

						case "Passthrough":
							string subdir12 = "Passthrough";
							WorkspaceFolder(subdir12, task);
							break;
					}

					
				}

				else if (maps == true)
				{
					string subdir = String.Empty;
					string task = "maps";
					WorkspaceFolder(subdir, task);

				}
				else if (codelist == true)
				{
					string subdir = String.Empty;
					string task = " [codelist]";
					WorkspaceFolder(subdir, task);

				}
				else if (other == true)
				{
					string subdir = String.Empty;
					string task = "";
					WorkspaceFolder(subdir, task);
				}
			}
		}

		private void WorkspaceFolder(string subdir, string task)
        {
			try
			{
				bool form = checkBoxSRQ.Checked;
				string CHWnoField = CHWnumberField.Text;
				string idField = SRQidField.Text;

				Ticket folder = new Ticket();
				folder.NewTicket(CHWnoField, idField, task, form, subdir);

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + task + " folder has been created correctly at:");
				ListBox(folder.createdfolder);


				if (task == " [STD LW Setup]")
				{
					//Zwróć informacje o utworzonym dokumencie jezeli zostal wybrany i utworzony katalog ma w nazwie SRQ
					if (form == true && folder.createdfolder.Substring(7, 3) == "SRQ")
					{
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] The EDI Deploy Request document generated successfully.");
					}
				}

				if (MessageBox.Show("Folder created. \n Would you like to open it?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process.Start(folder.createdfolder);
				}
			}
			catch (Exception)
            {
				MessageBox.Show(@"Not executed due to an error. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void SRQidField_TextChanged(object sender, EventArgs e)
		{
			SRQidField.CharacterCasing = CharacterCasing.Upper;
		}

		private void DeployComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
				ExtractRT();
				if (checkBox_Query.Checked)
				{
					Note(new object(), new EventArgs());
					ConsoleQuery();
				}
				else
				{
					Note(new object(), new EventArgs());
				}
			}
			else
			{
				if (checkBox_Query.Checked)
				{
					Note(new object(), new EventArgs());
					ConsoleQuery();
				}
				else
				{
					Note(new object(), new EventArgs());
				}
			}
		}

		private void Note(object sender, EventArgs e)
		{
			Kit set = new Kit();
			string selected = deployComboBox.GetItemText(deployComboBox.SelectedItem); //wybieram zmienna z comboboxa

			int day = set.Day();
			string month = set.Month();

			var dirs = from dir in Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*") select dir;

			if (dirs.Count() == 0) //jezeli nie ma folderow do wdrozenia
			{
				MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else // jezeli folder sa
			{
				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

				if (string.IsNullOrEmpty(selected)) // jezeli nie wybrano srodowiska
				{
					MessageBox.Show(dirs.Count().ToString() + " directories found, but not selected deployment environment.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else // jezeli wybrano srodowisko, to zwroc informacje i kontynuuj dla wybranego srodowiska
				{
					if (selected == "QA only")
					{
						new Qa();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + dirs.Count().ToString() + ". dir found. MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else if (selected == "PROD only")
					{
						new Prod();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else if (selected == "both - QA & PROD")
					{
						new Qaprod();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			ListBox("");
		}

		private void ButtonCL_Click(object sender, EventArgs e)
		{
			bool inbound = checkBox_cl_in.Checked;
			bool outbound = checkBox_cl_out.Checked;
			bool both = checkBox_cl_both.Checked;

				if (inbound == true)
				{
					Form_InboundCL InboundForm = new Form_InboundCL();
					InboundForm.Show();
				}
				else if (outbound == true)
				{
					Form_OutboundCL OnboundForm = new Form_OutboundCL();
					OnboundForm.Show();
				}
				else if (both == true)
				{
					Form_bothCL bothCLForm = new Form_bothCL();
					bothCLForm.Show();
				}
			
		}

		private void ButtonGenerateRandomPassword_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(PasswordGenerator.NewPassword());
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
			MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ExtractRT_button_Click(object sender, EventArgs e)
		{
			if (File.Exists(@"C:\DEPLOYMENTS\msteams_note.txt"))
			{
				if (new FileInfo(@"C:\DEPLOYMENTS\msteams_note.txt").Length == 0)
				{
					MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					ExtractRT();
					MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ExtractRT()
		{
			Kit set = new Kit();
			int day = set.Day();
			string month = set.Month();

			var dirs = from dir in
						 Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*")
					   select dir;

			if (dirs.Count() == 0) //jezeli nie ma paczek do wdrozenia
			{
				
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
					i += 1;
					string fileName = Path.GetFileName(rt_file);
					string destFile = Path.Combine(targetPath_RT, fileName);
					File.Copy(rt_file, destFile, true);
				}

				string[] lw_array = Directory.GetFiles(set.DeployPath(), "*_f*.xml", SearchOption.AllDirectories);
				foreach (string lw_file in lw_array)
				{
					j += 1;
					string fileName = Path.GetFileName(lw_file);
					string destFile = Path.Combine(tagretPath_LW, fileName);
					File.Copy(lw_file, destFile, true);
				}

				string[] sql_array = Directory.GetFiles(set.DeployPath(), "*.sql", SearchOption.AllDirectories);
				foreach (string sql_file in sql_array)
				{
					k += 1;
					string fileName = Path.GetFileName(sql_file);
					string destFile = Path.Combine(tagretPath_SQL, fileName);
					File.Copy(sql_file, destFile, true);
				}

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + @"RT for SI exported files:  " + i + @" + Lightwell RT files:  " + j + @" + SQL files:  " + k);
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			Process.Start(@"C:\DEPLOYMENTS\DEPLOY");
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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

		private void Button_logs_Click(object sender, EventArgs e)
		{
			string path = @"C:\DEPLOYMENTS\My_Logs.txt";

			string[] lines = File.ReadAllLines(path);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Checking logs:");
			ListBox("");

			foreach (string line in lines)
			{
				ListBox(line);
			}
		}

		private void Button_resources_Click(object sender, EventArgs e)
		{
			Process.Start(@"C:\DEPLOYMENTS\RESOURCES");
		}

		private void Button_reports_Click(object sender, EventArgs e)
		{
			Process.Start(@"C:\DEPLOYMENTS\Reports");
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
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

		private void ConsoleQuery_button_Click(object sender, EventArgs e)
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

		private void ConsoleQuery()
		{
			ConsoleQuery query = new ConsoleQuery();
			Kit set = new Kit();

			query.Query();
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Clipboard.SetText(string.Join(Environment.NewLine, listBox1.Items.OfType<string>())); /// aby móc kopiować zawartość listboxa do schowka
		}

		private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MinimizeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void LWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://dsidb1:16680/lw/client/index.html#/login");
			Process.Start("http://tsiapp2:16680/lw/client/index.html#/login");
			Process.Start("http://qsiapp1:16680/lw/client/index.html#/login");
			Process.Start("http://psiapp2:16680/lw/client/index.html#/login");
		}

		private void SIToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Process.Start("http://dsidb1:15501/dashboard/");
			Process.Start("http://tsiapp2:15501/dashboard/");
			Process.Start("http://qsiapp1:15501/dashboard/");
			Process.Start("http://psiapp2:15501/dashboard/");
		}

		private void AboutToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("myEDI " + ver.Text + Environment.NewLine + "" + Environment.NewLine +
				"Developed by: " + Environment.NewLine + "" + Environment.NewLine +
				"rafal.adamczyk@dsv.com" + Environment.NewLine + Environment.NewLine +
				"EDI Support Team®", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ButtonGoLDAP_Click(object sender, EventArgs e)
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
			Ldap account = new Ldap();
			bool form = checkBoxLDAP.Checked;

			string selectedLDAP = comboBoxLDAP.GetItemText(comboBoxLDAP.SelectedItem); //wybieram zmienna z comboboxa
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
					ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

					account.LdapAccount(selectedLDAP, textbox, form, length);

					ListBox(Ldap.listBoxMessage1);
					ListBox(Ldap.listBoxMessage2);
					ListBox(Ldap.listBoxMessage3);
					ListBox(Ldap.listBoxMessage4);
				}
				else
				{
					ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Doc template could not be processed... Procedure stopped, please try again without form.");
					MessageBox.Show(@"Failed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				account.LdapAccount(selectedLDAP, textbox, form, length);

				ListBox(Ldap.listBoxMessage1);
				//listBox(Ldap.listBoxMessage2);
			}
			if (MessageBox.Show("Process completed. \n Would you like to move to the directory?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process.Start(@"C:\EDI");
			}
		}

		private void CheckBoxLDAP_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxLDAP.Checked)
				checkBoxLDAPno.Checked = false;
			else
				checkBoxLDAPno.Checked = true;
		}

		private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBoxLDAPno.Checked)
				checkBoxLDAP.Checked = false;
			else
				checkBoxLDAP.Checked = true;
		}

		private void CreateDirResourcesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Resources dir = new Resources();
			dir.Dirs();
			MessageBox.Show(@"Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CleanEventViewerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
		}

		private void FTPProcedureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractResource extract = new ExtractResource();

			string path = "C:\\EDI\\temp\\procedureftp.doc";
			string pathToHide = "C:\\EDI\\temp";

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

			extract.Extract("myEDI", @"C:\EDI\temp", "Resources", "procedureftp.doc");
			Process.Start(path);

			File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
		}

		private void MultipleEntriesCLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractResource extract = new ExtractResource();

			string path = "C:\\EDI\\temp\\CodeListTool.xls";
			string pathToHide = "C:\\EDI\\temp";

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

			extract.Extract("myEDI", @"C:\EDI\temp", "Resources", "CodeListTool.xls");
			Process.Start(path);

			File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
		}

		private void DeployRequestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractResource extract = new ExtractResource();

			string path = "C:\\EDI\\temp\\deploy_request.docx";
			string pathToHide = "C:\\EDI\\temp";

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

			extract.Extract("myEDI", @"C:\EDI\temp", "Resources", "deploy_request.docx");
			Process.Start(path);

			File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
		}

		private void GentranGenericListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractResource extract = new ExtractResource();

			string path = "C:\\EDI\\temp\\Generic_list_adjustment_date.xls";
			string pathToHide = "C:\\EDI\\temp";

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

			extract.Extract("myEDI", @"C:\EDI\temp", "Resources", "Generic_list_adjustment_date.xls");
			Process.Start(path);

			File.SetAttributes(pathToHide, File.GetAttributes(pathToHide) | FileAttributes.Hidden);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Completed.");
		}

		private void ComboBoxLDAP_SelectedIndexChanged(object sender, EventArgs e)
		{
			// ta metoda aktywuje / dezaktywuje opcje dla okreslonych plikow LDAP

			string selectedLDAP = comboBoxLDAP.GetItemText(comboBoxLDAP.SelectedItem);

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
		/*
		private void ComboBoxSRQ_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Ta metoda wyłącza możliwość generowania formularza dla zadań typu Code list
			// + aktywuje / dezaktywuje rodzaj setupu

			string selectedSRQ = comboBoxLDAP.GetItemText(comboBoxSRQ.SelectedItem);

			switch (selectedSRQ)
            {
				case "STD LW Setup":
					checkBoxSRQ.Checked = true;
					checkBoxSRQ.Enabled = true;
					comboBox_setup.Enabled = true;
					break;

				case "Code list":
					checkBoxSRQ.Checked = false;
					checkBoxSRQ.Enabled = false;
					comboBox_setup.Enabled = false;
					break;

				case "other":
					checkBoxSRQ.Checked = false;
					checkBoxSRQ.Enabled = true;
					comboBox_setup.Enabled = false;
					break;
			}
		}
		*/
		private void Button1_Click(object sender, EventArgs e)
		{
			PassSettings PassSettings = new PassSettings();
			PassSettings.Show();
		}

		private void CheckBoxPass8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPass8.Checked)
			{
				MessageBox.Show(@"The current LDAP script only supports 24 character passwords. Consider a 24-character password.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				checkBoxPass16.Checked = false;
				checkBoxPass24.Checked = false;
			}
		}

		private void CheckBoxPass16_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPass16.Checked)
			{
				MessageBox.Show(@"The current LDAP script only supports 24 character passwords. Consider a 24-character password.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				checkBoxPass8.Checked = false;
				checkBoxPass24.Checked = false;
			}
		}
		public void CheckBoxPass24_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxPass24.Checked)
			{
				checkBoxPass8.Checked = false;
				checkBoxPass16.Checked = false;
			}
		}

		private void ComboBoxPass_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedType = comboBoxPass.GetItemText(comboBoxPass.SelectedItem); //wybieram zmienna z comboboxa

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

		private void ListBox(string value)
		{
			listBox1.Items.Add(value);
		}

        private void checkBox_setup_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_setup.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_cl.Checked = false;
				checkBox_other.Checked = false;
				checkBoxSRQ.Checked = true;
				checkBoxSRQ.Enabled = true;
				comboBox_setup.Enabled = true;
			}
		}

        private void checkBox_cl_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_other.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = false;
				comboBox_setup.Enabled = false;
			}
		}

        private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_other.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_cl.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = true;
				comboBox_setup.Enabled = false;
			}
		}

        private void checkBox_cl_in_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_in.Checked)
			{
				checkBox_cl_out.Checked = false;
				checkBox_cl_both.Checked = false;
			}
		}

        private void checkBox_cl_out_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_out.Checked)
			{
				checkBox_cl_in.Checked = false;
				checkBox_cl_both.Checked = false;
			}
		}

        private void checkBox_cl_both_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_both.Checked)
			{
				checkBox_cl_in.Checked = false;
				checkBox_cl_out.Checked = false;
			}
		}
		
        private void codeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_maps_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_maps.Checked)
			{
				checkBox_cl.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_other.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = true;
				comboBox_setup.Enabled = false;
			}
		}

        private void cleanerDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			cleanerDownloads cleanerDownloads = new cleanerDownloads();
			cleanerDownloads.Show();
		}
	}
}