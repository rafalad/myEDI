using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Updater_myEDI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			WebClient webClient = new WebClient();
			var client = new WebClient();

			try
			{
				//System.Threading.Thread.Sleep(5000);
				File.Delete(@".\myEDI.exe");
				client.DownloadFile("https://u1p1d1a1t1e1r1.000webhostapp.com/updater/myEDI.zip", @"myEDI.zip");

					string zipPath = @".\myEDI.zip";
					string extractPath = @".\";
					ZipFile.ExtractToDirectory(zipPath, extractPath);
				
				File.Delete(@".\myEDI.zip");
				Process.Start(@".\myEDI.exe");
				this.Close();
			}
			catch
			{
				Process.Start("myEDI.exe");
				this.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
