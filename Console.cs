using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDISupportTool
{
	public class ConsoleQuery
	{

		public void Query()
		{
			Kit set = new Kit();

			string pathString = Path.Combine(set.deploymentsdir, "query.txt");

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
				// szukam nazw RT, buduje składnie i dodaje do wygenerowanej notatki
				string[] rt_array = Directory.GetFiles(set.DeployPath(), "*exp.xml", SearchOption.AllDirectories);
				foreach (string file in rt_array)
				{
					string fileName = Path.GetFileName(file);
					File.AppendAllText(pathString, "dsvimport.sh " + fileName + "; ", Encoding.UTF8);
				}

				File.AppendAllText(pathString, Environment.NewLine +
												Environment.NewLine, Encoding.UTF8);

				// szukam plików SQL, buduje składnie i dodaje do wygenerowanej notatki
				string[] sql_array = Directory.GetFiles(set.DeployPath(), "*.sql", SearchOption.AllDirectories);
				foreach (string file in sql_array)
				{
					string fileName = Path.GetFileName(file);
					File.AppendAllText(pathString, "run_sql.sh " + fileName + "; ", Encoding.UTF8);
				}

				Process.Start(pathString);
			}
		}
	}
}
