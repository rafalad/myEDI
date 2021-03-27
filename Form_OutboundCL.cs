using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace myEDI
{
	public partial class Form_OutboundCL : Form
	{
		public Form_OutboundCL()
		{
			InitializeComponent();
		}

		private void buttonCreateOutboundCL_Click(object sender, EventArgs e)
		{
			string parentID = textBoxParentID_outbound.Text;

			if (String.IsNullOrEmpty(parentID))
			{
				MessageBox.Show("Enter the parent name, please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				string codelist_SendEncoding = "DSV_CL_SEND_ENCODING_" + parentID + "_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_SendEncoding };
				File.WriteAllLines(pathString, naglowek);

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for the Outbound flow." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void textBoxParentID_outbound_TextChanged(object sender, EventArgs e)
		{
			textBoxParentID_outbound.CharacterCasing = CharacterCasing.Upper;
		}
	}
}
