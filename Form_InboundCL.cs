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
	public partial class Form_InboundCL : Form
	{
		public Form_InboundCL()
		{
			InitializeComponent();
		}

		private void textBoxChildD_inbound_TextChanged(object sender, EventArgs e)
		{
			textBoxChildD_inbound.CharacterCasing = CharacterCasing.Upper;
		}

		private void textBoxParentID_inbound_TextChanged(object sender, EventArgs e)
		{
			textBoxParentID_inbound.CharacterCasing = CharacterCasing.Upper;
		}

		private void buttonCreateInboundCL_Click(object sender, EventArgs e)
		{
			string parentID = textBoxParentID_inbound.Text;
			string childID = textBoxChildD_inbound.Text;

			if (String.IsNullOrEmpty(parentID))
			{
				MessageBox.Show("Enter the parent name, please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (String.IsNullOrEmpty(childID))
			{
				MessageBox.Show("Enter the child name, please.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				string codelist_ReceiveEncoding = "DSV_CL_RECEIVE_ENCODING_" + childID + "_cl";
				string codelist_SourceIDLookup = "DSV_CL_SourceIDLookup_" + parentID + "_D10B_CDM_V2_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_ReceiveEncoding, codelist_SourceIDLookup };
				File.WriteAllLines(pathString, naglowek);

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for the Inbound flow." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
