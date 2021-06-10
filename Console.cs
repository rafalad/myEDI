using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace myEDI
{
	class ConsoleQuery : Kit
	{
		public void Query()
		{
			//Kit set = new Kit();

			string pathString = @"C:\DEPLOYMENTS\query.txt";

			int day = Day();
			string month = Month();

			var dirs = from dir in Directory.EnumerateDirectories(deploymentsdir, month + "*" + day.ToString() + "*") select dir;

			if (dirs.Count<string>() == 0) //jezeli nie ma folderow do wdrozenia
			{

			}
			else // jezeli folder sa
			{
				// szukam nazw RT, buduje składnie i dodaje do wygenerowanej notatki
				string[] rt_array = Directory.GetFiles(DeployPath(), "*exp.xml", SearchOption.AllDirectories);
				foreach (string file in rt_array)
				{
					string fileName = Path.GetFileName(file);
					File.AppendAllText(pathString, "dsvimport.sh " + fileName + "; ", Encoding.UTF8);
				}

				File.AppendAllText(pathString, Environment.NewLine + Environment.NewLine, Encoding.UTF8);

				Process.Start(pathString);
			}
		}
	}
}
