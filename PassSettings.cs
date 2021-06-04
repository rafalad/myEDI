using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace myEDI
{
	public partial class PassSettings : Form
	{
		static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
		public PassSettings()
		{
			InitializeComponent();
		}

		public void TypeOfPassword(string type)
		{
			Option _Amount = new Option();

			if (type == "single")
			{
				_Amount.Amount = 1;
				comboBoxAmount.Enabled = false;
			}
			else
			{
				comboBoxAmount.Enabled = true;
			}

		}

		//ta metoda zapisuje do zmiennych ustawienia hasla
		private void buttonGenerateRandomPassword_Click(object sender, EventArgs e)
		{
			Option _Length = new Option();
			Option _Amount = new Option();
			Option _CL = new Option();
			Option _SL = new Option();
			Option _D = new Option();
			Option _SC = new Option();

			_Length.Length = Convert.ToInt32(comboBoxLength.GetItemText(this.comboBoxLength.SelectedItem));
			_Amount.Amount = Convert.ToInt32(comboBoxAmount.GetItemText(this.comboBoxAmount.SelectedItem));

			// sprawdzam warunki, jezeli wybrano duze litery
			_CL.CL = checkBoxCL.Checked;

			// jezeli wybrano male litery
			_SL.SL = checkBoxSL.Checked;

			// jeżeli wybrano cyfry
			_D.D = checkBoxSL.Checked;

			// jezeli wybrano znaki specjalne
			_SC.SC = checkBoxSC.Checked;

			Multipass(_Amount.Amount, _Length.Length, _CL.CL, _SL.SL, _D.D, _SC.SC);

			Close();
		}

		public void Multipass(int Amount, int Length, bool CL, bool SL, bool D, bool SC)
		{
			DateTime thisDay = DateTime.Today;

			string path = @"C:\EDI\passwords_" + thisDay.ToString("ddMMyyyyhhmmss") + ".txt";

			string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
			string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
			string Digits = "0123456789";
			string SpecialCharacters = "!@#$%^&*_+";

			string[] AllPasswords = new string[Amount];

			//jezeli wszystkie warunki sa prawdziwe
			if (CL && SL && D && SC == true)
			{
				string AllChar1 = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar1));
					}

					AllPasswords[i] = sb.ToString();
				}

				foreach (string singlePassword in AllPasswords)
				{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);

				}

				MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Process.Start(path);

			}

			//jezeli nie wybrano znakow specjalnych
			else if (CL && SL && D == true || SC == false)
			{
				string AllChar2 = CapitalLetters + SmallLetters + Digits;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar2));
					}

					AllPasswords[i] = sb.ToString();
				}

				foreach (string singlePassword in AllPasswords)
				{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);

				}

				MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Process.Start(path);
			}

			// jezeli wybrano tylko duze i male litery
			else if (CL && SL == true || D && SC == false)
			{
				string AllChar3 = CapitalLetters + SmallLetters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar3));
					}

					AllPasswords[i] = sb.ToString();
				}

				foreach (string singlePassword in AllPasswords)
				{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);

				}

				MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Process.Start(path);

			}

			// jezeli wybrano tylko duze litery
			else if (CL == true || SL && D && SC == false)
			{
				string AllChar = CapitalLetters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar));
					}

					AllPasswords[i] = sb.ToString();
				}

				foreach (string singlePassword in AllPasswords)
				{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);

				}

				MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Process.Start(path);
			}
			else
			{
				MessageBox.Show("Please choose any password component and try again.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private static char GenerateChar(string availableChars)
		{
			var byteArray = new byte[1];
			char c;
			do
			{
				provider.GetBytes(byteArray);
				c = (char)byteArray[0];

			} while (!availableChars.Any(x => x == c));

			return c;
		}

		private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxD_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
	class Option
	{
		public int Length { get; set; }
		public int Amount { get; set; }
		public bool CL { get; set; }
		public bool SL { get; set; }
		public bool D { get; set; }
		public bool SC { get; set; }
	}
}
