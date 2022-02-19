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
			string pathString = @"C:\DEPLOYMENTS\query.txt";

			int day = Day();
			string month = Month();
			string command;

			StringBuilder builtCommand = new StringBuilder();

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
					builtCommand.Append("dsvimport.sh " + fileName + "; ");
				}

				//usuwam ; z ostatniego RT
				command = builtCommand.ToString().Remove(builtCommand.ToString().Length - 2);

				File.WriteAllText(pathString, command);

				Process.Start(pathString);
			}
		}
	}
}
