using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace myEDI
{
	class SRQform : Resources
	{
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

		public void CreateWordDocument(object filename, object SaveAs, string no, string file1, string file2, string file3, string file4)
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

					//Data                                                                                                                      
					DateTime dateAndTime = DateTime.Now;
					//Użytkownik
					string userName = Environment.UserName;


					this.FindAndReplace(wordApp, "<user>", userName.Replace(".", " "));
					this.FindAndReplace(wordApp, "2000-01-01", dateAndTime.ToString("yyyy-MM-dd"));
					this.FindAndReplace(wordApp, "<srqno>", no);
					this.FindAndReplace(wordApp, "<si>", "SI:");
					this.FindAndReplace(wordApp, "<file1>", file1 + ".xml");
					this.FindAndReplace(wordApp, "<lw>", "LW:");
					this.FindAndReplace(wordApp, "<file2>", file2 + ".xml");
					this.FindAndReplace(wordApp, "<file3>", file3 + ".xml");
					this.FindAndReplace(wordApp, "<file4>", file4 + ".xml");

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

		//Ta metoda utworzy formularz, który przyjmuje 7 zmiennych z klasy Ticket (wywołuje tą metodę) - numer zadania, koncept nazwy pliku, nazwe folderu docelowego oraz nazwy plikow.
		public void CreateForm(string no, string docName, string dirName, string file1, string file2, string file3, string file4)
		{
			try
			{
				CreateWordDocument(@"C:\EDI\doc_temp\deploy_request.docx", dirName + docName, no, file1, file2, file3, file4);
			}

			catch
			{
				MessageBox.Show("Failed. Please try again", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				DocDirCleanUp();
			}
		}
	}
}
