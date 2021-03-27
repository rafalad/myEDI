using System.Windows.Forms;

namespace myEDI
{
	public class LoginDSV
	{
		public string Login()
		{
			string credentials = SystemInformation.UserName;

			try
			{
				int dot = credentials.IndexOf("."); //wyliczam kropke

				string name = credentials.Remove(dot);
				string lastname = credentials.Substring(dot + 1);

				string login = name.Remove(2) + lastname.Remove(2);
				return login.ToLower();
			}

			catch //w przypadku bledu konwersji zwroc cala nazwe uzytkownika
			{
				return SystemInformation.UserName;
			}
		}
	}
}
