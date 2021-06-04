using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace myEDI
{
	public class Qa : Kit
	{
		public Qa()
		{
			string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

			string wiersz1 = Time1();
			string wiersz2 = "\nFollowing SRQs are now deployed to QA system successfully:\n";

			string[] naglowek = { wiersz1, wiersz2 };
			File.WriteAllLines(pathString, naglowek);

			string[] foldery = Directory.GetDirectories(DeployPath(), "S*", SearchOption.TopDirectoryOnly);
			foreach (string folder in foldery)
			{
				string appendText = Path.GetFileName(folder) + Environment.NewLine;
				File.AppendAllText(pathString, appendText, Encoding.UTF8);
			}

			string[] pliki = Directory.GetFiles(DeployPath(), "*.xls*");
			foreach (string plik in pliki)
			{
				string appendText = Path.GetFileName(plik) + Environment.NewLine;
				File.AppendAllText(pathString, appendText, Encoding.UTF8);
			}

			Process.Start(pathString);

			///Logs section ////

			DateTime thisDay = DateTime.Today;
			string logPath = @"C:\DEPLOYMENTS\my_logs.txt";

			string[] lines = File.ReadAllLines(pathString);

			using (StreamWriter outputFile = new StreamWriter(logPath, true))
			{
				if (!logPath.Contains(" "))
				{
					outputFile.WriteLine("\n\n>>>>> Deployed on " + thisDay.ToString("d") + " <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n");
					foreach (string line in lines)
					{
						outputFile.WriteLine(line);
					}
				}
			}
		}
	}
}
