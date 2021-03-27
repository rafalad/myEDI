using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace myEDI
{
	public partial class Form_bothCL : Form
	{
		public Form_bothCL()
		{
			InitializeComponent();
		}

		private void buttonCreateBothCL_Click(object sender, EventArgs e)
		{
			string parentID = textBoxParentID_both.Text;
			string childID = textBoxChildD_both.Text;

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
				string codelist_SendEncoding = "DSV_CL_SEND_ENCODING_" + parentID + "_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_ReceiveEncoding, codelist_SourceIDLookup, codelist_SendEncoding };
				File.WriteAllLines(pathString, naglowek);

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for both flows." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void textBoxParentID_both_TextChanged(object sender, EventArgs e)
		{
			textBoxParentID_both.CharacterCasing = CharacterCasing.Upper;
		}

		private void textBoxChildD_both_TextChanged(object sender, EventArgs e)
		{
			textBoxChildD_both.CharacterCasing = CharacterCasing.Upper;
		}
	}
}
