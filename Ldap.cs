using System;
using System.IO;
using System.Windows.Forms;

namespace myEDI
{
	class Ldap : LdapForm
	{
		public static string passwordForm;
		public static string loginForm;
		public static string listBoxMessage1;
		public static string listBoxMessage2;
		public static string listBoxMessage3;
		public static string listBoxMessage4;

		public void LdapAccount(string selectedLDAP, string textbox, bool form, int length)
		{
			string password = PasswordGenerator.NewPasswordforFile(length);
			passwordForm = password;
			loginForm = textbox;

			if (string.IsNullOrEmpty(textbox)) // jezeli nie podano nazwy uzytkownika
			{
				MessageBox.Show("Please enter the user account name please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else // utworz uzytkownika zgodnie z wybranym typem
			{
				if (selectedLDAP == "New user")
				{
					if (form == true)
					{
						CreateForm();

						string fileName = "addUser_" + textbox + ".txt";
						string[] lines = { "userName=" + textbox, "password=" + password };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New user LDAP File has been created in: ";
						listBoxMessage2 = path;
						listBoxMessage3 = listBoxMessage_1; //pobieram komunikaty po utworzeniu formularza FTP tylko dla nowego uzytkownika
						listBoxMessage4 = listBoxMessage_2;
					}

					else
					{
						string fileName = "addUser_" + textbox + ".txt";
						string[] lines = { "userName=" + textbox, "password=" + password };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New user LDAP File has been created in: ";
						listBoxMessage2 = path;
						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}

				else if (selectedLDAP == "Bulk user")
				{
					if (form == true)
					{
						CreateForm();

						string fileName = "addBulkUser_" + textbox + ".csv";
						string[] lines = { textbox + "," + password };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New Bulk user LDAP File has been created in: ";
						listBoxMessage2 = path;
						listBoxMessage3 = listBoxMessage_1; //pobieram komunikaty po utworzeniu formularza FTP tylko dla nowego uzytkownika
						listBoxMessage4 = listBoxMessage_2;
					}

					else
					{
						string fileName = "addBulkUser_" + textbox + ".csv";
						string[] lines = { textbox + "," + password };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New Bulk user LDAP File has been created in: ";
						listBoxMessage2 = path;
						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}

				else if (selectedLDAP == "SSHKey user")
				{
					if (form == true)
					{
						CreateForm();

						string fileName = "addSSHKey_" + textbox + ".txt";
						string[] lines = { "userName=" + textbox, "sshPublicKey=" + "Enter your SSH key here" };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New SSH user LDAP File has been created in: ";
						listBoxMessage2 = path;
						listBoxMessage3 = listBoxMessage_1; //pobieram komunikaty po utworzeniu formularza FTP tylko dla nowego uzytkownika
						listBoxMessage4 = listBoxMessage_2;
					}

					else
					{
						string fileName = "addSSHKey_" + textbox + ".txt";
						string[] lines = { "userName=" + textbox, "sshPublicKey=" + "Enter your SSH key here" };
						string path = Path.Combine(@"C:\EDI\", fileName);
						File.WriteAllLines(path, lines);

						listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New SSH user LDAP File has been created in: ";
						listBoxMessage2 = path;
						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}

				else if (selectedLDAP == "Modify user")
				{
					string fileName = "modifyPassword_" + textbox + ".txt";
					string[] lines = { "userName=" + textbox, "password=" + password };
					string path = Path.Combine(@"C:\EDI\", fileName);
					File.WriteAllLines(path, lines);

					listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] Modify user LDAP File has been created in: ";
					listBoxMessage2 = path;
					MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				else if (selectedLDAP == "Delete user")
				{
					string fileName = "deleteUser_" + textbox + ".txt";
					string[] lines = { "userName=" + textbox };
					string path = Path.Combine(@"C:\EDI\", fileName);
					File.WriteAllLines(path, lines);

					listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] Delete user LDAP File has been created in: ";
					listBoxMessage1 = path;
					MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				else if (selectedLDAP == "Remove SSHkey")
				{
					string fileName = "removeSSHKey_" + textbox + ".txt";
					string[] lines = { "userName=" + textbox, "sshPublicKey=" + "Enter your SSH key here" };
					string path = Path.Combine(@"C:\EDI\", fileName);
					File.WriteAllLines(path, lines);

					listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] Remove SSH user LDAP File has been created in: ";
					listBoxMessage1 = path;
					MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
