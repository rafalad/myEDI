using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace myEDI
{
	class Resources
	{
		public static string listBoxMessageDris = string.Empty; //jezeli foldery nie zostaly utworzone (bo wczesnij istnialy) nie zwracaj komunikatu.

		public void Dirs()
		{
			if (Directory.Exists(@"C:\EDI") &&
				Directory.Exists(@"C:\EDI\SETUPS") &&
				Directory.Exists(@"C:\EDI\CODELIST") &&
				Directory.Exists(@"C:\EDI\Other") &&
				Directory.Exists(@"C:\EDI\Temp") &&
				Directory.Exists(@"C:\DEPLOYMENTS\") &&
				Directory.Exists(@"C:\DEPLOYMENTS\DEPLOY") &&
				Directory.Exists(@"C:\DEPLOYMENTS\REPORTS") &&
				Directory.Exists(@"C:\DEPLOYMENTS\REPORTS\QA") &&
				Directory.Exists(@"C:\DEPLOYMENTS\REPORTS\PROD") &&
				Directory.Exists(@"C:\DEPLOYMENTS\Resources"))
			{

			}
			else
			{
				Directory.CreateDirectory(@"C:\EDI");
				Directory.CreateDirectory(@"C:\EDI\SETUPS");
				Directory.CreateDirectory(@"C:\EDI\CODELIST");
				Directory.CreateDirectory(@"C:\EDI\Other");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\DEPLOY");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\REPORTS");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\REPORTS\QA");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\REPORTS\PROD");
				Directory.CreateDirectory(@"C:\DEPLOYMENTS\Resources");

				// Ukryj temp
				DirectoryInfo di = Directory.CreateDirectory(@"C:\EDI\Temp");
				di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

				//Zwróć komunikat o utworzeniu folderów
				listBoxMessageDris = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New dir resources have been created.";
			}

			if (!Directory.Exists(@"C:\EDI\temp"))
			{
				DirectoryInfo di = Directory.CreateDirectory(@"C:\EDI\temp");
				di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
			}
		}

		public void PrepareDirs()
		{
			if (Directory.Exists(@"C:\DEPLOYMENTS\Resources"))
			{
				try
				{
					Directory.Delete(@"C:\DEPLOYMENTS\Resources", true);
				}

				catch (IOException e)
				{
					MessageBox.Show(e.Message, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			Directory.CreateDirectory(@"C:\DEPLOYMENTS\Resources");

			if (Directory.Exists(@"C:\DEPLOYMENTS\Reports"))
			{
				try
				{
					Directory.Delete(@"C:\DEPLOYMENTS\Reports", true);
				}

				catch (IOException e)
				{
					MessageBox.Show(e.Message, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports");
			Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports\QA");
			Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports\PROD");
		}

		public void DocDirCleanUp()
		{
			if (Directory.Exists(@"C:\EDI\doc_temp"))
			{
				try
				{
					Directory.Delete(@"C:\EDI\doc_temp", true);
				}

				catch (IOException e)
				{
					MessageBox.Show(e.Message, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void DocDir2CleanUp()
		{
			if (Directory.Exists(@"C:\EDI\doc_temp2"))
			{
				try
				{
					Directory.Delete(@"C:\EDI\doc_temp2", true);
				}

				catch (IOException e)
				{
					MessageBox.Show(e.Message, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void LogToFTP() //Metoda zapisujaca logi do pliku log.txt na serwerze FTP
		{
			LoginDSV login = new LoginDSV();

			string date = DateTime.Today.ToString("dd-MM-yyyy");
			string time = DateTime.Now.ToString("HH:mm:ss");
			string who = login.Login();
			string name = SystemInformation.UserName;
			string ver = "v" + Application.ProductVersion;

			string input = "[" + date + "][" + time + "][" + name + "][" + who + "][" + ver + "]\n";

			byte[] data = Encoding.ASCII.GetBytes(input);

			try
			{
				FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://files.000webhost.com/myedi/log.txt");
				request.Credentials = new NetworkCredential("ediapp", "w8EtQdvNMJ8vXbt");
				request.Method = WebRequestMethods.Ftp.AppendFile;

				Stream requestStream = request.GetRequestStream();
				requestStream.Write(data, 0, data.Length);
				requestStream.Close();
				FtpWebResponse response = (FtpWebResponse)request.GetResponse();
				response.Close();
			}
			catch
			{
			}
		}

		public string CheckVersion()
		{
			WebClient client = new WebClient();
			string versionMessage;

			try
			{
				if (client.DownloadString("https://pastebin.com/raw/qiJ05NWB").Contains("1.1.2.0"))
				{
					versionMessage = "[ you're using the latest version. ]";
				}
				else
				{
					versionMessage = "[ a new version is available! ]";
				}
			}
			catch
			{
				versionMessage = "[ failed to get the version info... ]";
			}

			return versionMessage;

		}
	}
}
