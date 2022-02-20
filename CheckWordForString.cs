using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace myEDI
{
    internal class CheckWordForString : Kit
    {
        public string CheckWordDocuments()
        {
            int day = Day();
            string month = Month();

            int max = NumberOfSRQ();
            int min = 0;

            var dirs = from dir in Directory.EnumerateDirectories(deploymentsdir, month + "*" + day.ToString() + "*") select dir;

            if (dirs.Count<string>() == 0) //jezeli nie ma folderow do wdrozenia
            {

            }
            else // jezeli folder sa
            {
                 // szukam dokumentow Word
                 string[] doc_array = Directory.GetFiles(DeployPath(), "*Request.doc*", SearchOption.AllDirectories);

                 foreach (string file in doc_array)
                 {
                      string fileName = Path.GetFullPath(file);
                      if (CheckWordDocumentForString(file, "SI-TC", true))
                      {
                        min = min + 1;
                        return "The SI-TC was found on file: " + Environment.NewLine + Path.GetFileName(file);

                      }
                      else
                      {
                        min = min + 1;
                      }
                 }              
            }
            return "";
        }

        public static Boolean CheckWordDocumentForString(String documentLocation, String stringToSearchFor, Boolean caseSensitive = true)
        {
            // Create an application object if the passed in object is null
            Word.Application winword = new Word.Application();

            // Use the application object to open our word document in ReadOnly mode
            Word.Document wordDoc = winword.Documents.Open(documentLocation, ReadOnly: true);

            // Search for our string in the document
            Boolean result;
            if (caseSensitive)
                result = wordDoc.Content.Text.IndexOf(stringToSearchFor) >= 0;
            else
                result = wordDoc.Content.Text.IndexOf(stringToSearchFor, StringComparison.CurrentCultureIgnoreCase) >= 0;

            // Close the document and the application since we're done searching
            wordDoc.Close();
            winword.Quit();

            return result;
        }
    }
}
