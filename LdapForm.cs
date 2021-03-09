using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDISupportTool;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using myEDI;

namespace EDISupportTool
{
	class LdapForm
	{
        public static string listBoxMessage1;
        public static string listBoxMessage2;

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Creeate the Doc Method
        public void CreateWordDocument(object filename, object SaveAs)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                object missing = Missing.Value;
                Word.Document myWordDoc = null;

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();
                    //find and replace
                    this.FindAndReplace(wordApp, "<loginid>", Ldap.loginForm);
                    this.FindAndReplace(wordApp, "<password>", Ldap.passwordForm);

                }
                else
                {
                    MessageBox.Show("Template file not Found!");
                }

                //Save as, tworzenie pliku

                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CreateForm()
        {
            string login = Ldap.loginForm;
            string customer = login.Substring(4);

            CreateWordDocument(@"C:\EDI\Templates\procedureftp.doc", @"C:\EDI\Procedure for making FTP from "+customer.ToUpper()+" to DSV.doc");

            listBoxMessage1 = "The FTP document for Requestor generated successfully. Link below:";
            listBoxMessage2 = @"C:\EDI\Procedure for making FTP from " + customer.ToUpper() + " to DSV.doc";
        }
    }
}
