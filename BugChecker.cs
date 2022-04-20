using System.IO;
using System.Text;

namespace myEDI
{
    internal class BugChecker
    {
        public string Bug()
        {
            return ReadReports();
        }
        private string ReadReports()
        {
            StringBuilder builtQuery = new StringBuilder();

            string[] files_array = Directory.GetFiles(@"C:\DEPLOYMENTS\Reports\", "*.*", SearchOption.AllDirectories);

            //sprawdz czy sa raporty txt
            if (files_array.Length > 0)
            {
                foreach (string file in files_array)
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
                return "No reports loaded.";
            }
        }
    }
}
