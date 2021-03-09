using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EDISupportTool;

namespace myEDI
{
	class Ldap
	{
        public static string passwordForm;
        public static string loginForm;
        public static string listBoxMessage1;
        public static string listBoxMessage2;
        public static string listBoxMessage3;
        public static string listBoxMessage4;

        public void LdapAccount(string selectedLDAP, string textbox, bool form)
		{
            string password = PasswordGenerator.NewPasswordforFile();
            passwordForm = password;
            loginForm = textbox;

            if (String.IsNullOrEmpty(textbox)) // jezeli nie podano nazwy uzytkownika
            {
                MessageBox.Show("Please enter the user account name please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else // utworz uzytkownika zgodnie z wybranym typem
            {
                if (selectedLDAP == "New user")
                {
                    if (form == true)
                    {
                        LdapForm formFTP = new LdapForm();
                        formFTP.CreateForm();

                        string fileName = "addUser_" + textbox + ".txt";
                        string[] lines = { "userName=" + textbox, "password=" + password };
                        string path = Path.Combine(@"C:\EDI\", fileName);
                        File.WriteAllLines(path, lines);

                        listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New user LDAP File has been created in: ";
                        listBoxMessage2 = path;
                        listBoxMessage3 = LdapForm.listBoxMessage1;
                        listBoxMessage4 = LdapForm.listBoxMessage2;

                        MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    string fileName = "deletePassword_" + textbox + ".txt";
                    string[] lines = { "userName=" + textbox, "password=" + password };
                    string path = Path.Combine(@"C:\EDI\", fileName);
                    File.WriteAllLines(path, lines);

                    listBoxMessage1 = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] Delete user LDAP File has been created in: ";
                    listBoxMessage1 = path;
                    MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
	}
}
