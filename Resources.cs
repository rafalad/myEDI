using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace myEDI
{

	class Resources
	{
        public static string listBoxMessageDris = string.Empty; //jezeli foldery nie zostaly utworzone (bo wczesnij istnialy) nie zwracaj komunikatu.
        public static string listBoxMessageFTPdoc = string.Empty;

        public void Dirs()
        {
            if (Directory.Exists(@"C:\EDI") ||
                Directory.Exists(@"C:\EDI\Templates") ||
                Directory.Exists(@"C:\DEPLOYMENTS\") ||
                Directory.Exists(@"C:\DEPLOYMENTS\DEPLOY") ||
                Directory.Exists(@"C:\DEPLOYMENTS\Reports") ||
                Directory.Exists(@"C:\DEPLOYMENTS\Reports\QA") ||
                Directory.Exists(@"C:\DEPLOYMENTS\Reports\PROD") ||
                Directory.Exists(@"C:\DEPLOYMENTS\Resources"))
            {

            }
            else
            {
                Directory.CreateDirectory(@"C:\EDI");
                Directory.CreateDirectory(@"C:\EDI\Templates");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\DEPLOY");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports\QA");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\Reports\PROD");
                Directory.CreateDirectory(@"C:\DEPLOYMENTS\Resources");

                listBoxMessageDris = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] New dir resources have been created.";
            }
        }

        public void FTPdoc()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile("https://ediapp.000webhostapp.com/procedureftp.doc", @"C:\EDI\Templates\procedureftp.doc");

                listBoxMessageFTPdoc = "[" + DateTime.Now.ToString("HH:mm:ss") + @"] The template file has been downloaded. The file is being processed.";
            }

            catch (Exception ex)
            {
                MessageBox.Show("I cannot connect to a network resource to download a template. Skipping this step. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
