using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myEDI
{
    internal class BugChecker
    {
        public string Bug()
        {
            string patch = @"C:\DEPLOYMENTS\Reports\";

            string nofiles = "No reports loaded.";

            StringBuilder builtQuery = new StringBuilder();

            string[] txt_array = Directory.GetFiles(patch, "*.txt", SearchOption.AllDirectories);

            //sprawdz czy sa raporty
            if (txt_array.Length > 0)
            {
                foreach (string file in txt_array)
                {
                    string fileName = Path.GetFullPath(file);

                    foreach (string line in File.ReadAllLines(fileName))
                    {
                        if (line.Contains("error") || line.Contains("fail"))
                            builtQuery.Append(fileName + "\n");
                    }
                }
                return builtQuery.ToString();
            }
            else //jezeli nie ma to daj informacje
            {
                return nofiles;
            }
        }
    }
}
