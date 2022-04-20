using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace myEDI
{
    internal class License
    {
		public bool LicenseCheckPoint()
		{
			var request = (FtpWebRequest)WebRequest.Create("ftp://files.000webhost.com/myedi/LICENSE1135.txt");
			request.Credentials = new NetworkCredential("ediapp", "xxx");
			request.Method = WebRequestMethods.Ftp.GetFileSize;

			try
			{
				FtpWebResponse response = (FtpWebResponse)request.GetResponse();
				return true;
			}
			catch (WebException ex)
			{
				FtpWebResponse response = (FtpWebResponse)ex.Response;
				if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
					return false;
			}
			return false;
		}
	}
}
