using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace myEDI
{
	public partial class cleanerDownloads : Form
	{
		public int counter;
		public string result;

		public cleanerDownloads()
		{
			InitializeComponent();
		}

		private void cleanerDownloads_Load(object sender, EventArgs e)
		{
			groupBox1.Paint += GroupBox_Paint;
		}

		private void GroupBox_Paint(object sender, PaintEventArgs e)
		{
			GroupBox box = sender as GroupBox;
			DrawGroupBox(box, e.Graphics, Color.MidnightBlue, Color.DarkGray);
		}

		private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
		{
			if (box != null)
			{
				Brush textBrush = new SolidBrush(textColor);
				Brush borderBrush = new SolidBrush(borderColor);
				Pen borderPen = new Pen(borderBrush);
				SizeF strSize = g.MeasureString(box.Text, box.Font);
				Rectangle rect = new Rectangle(box.ClientRectangle.X,
											   box.ClientRectangle.Y + (int)(strSize.Height / 2),
											   box.ClientRectangle.Width - 1,
											   box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

				g.Clear(BackColor);

				g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

				// Drawing Border
				//Left
				g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
				//Right
				g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
				//Bottom
				g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
				//Top1
				g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
				//Top2
				g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
			}
		}

		private void buttonScan_Click(object sender, EventArgs e)
		{
			//jezeli wyszukano wiadomosci, to nie szukaj ponownie
			if (counter > 0)
			{

			}
			else
			{
				if (ALLcheckBox.Checked)
					Scan("*.*");
				if (XMLcheckBox.Checked)
					Scan("*.xml");
				if (TXTcheckBox.Checked)
					Scan("*.txt");
				if (EDIcheckBox.Checked)
					Scan("*.edi");
				if (MAPcheckBox.Checked)
					Scan("*.map");
				if (DOCcheckBox.Checked)
					Scan("*.doc");
				if (DOCXcheckBox.Checked)
					Scan("*.docx");
				if (XLScheckBox.Checked)
					Scan("*.xls");
				if (XLSXcheckBox.Checked)
					Scan("*.xlsx");
				if (EXEcheckBox.Checked)
					Scan("*.exe");
				if (PNGcheckBox.Checked)
					Scan("*.png");
				if (CSVcheckBox.Checked)
					Scan("*.csv");
			}
		}

		string ListOfFiles(string[] array) //ConvertStringArrayToString
		{
			StringBuilder strinbuilder = new StringBuilder();
			foreach (string value in array)
			{
				strinbuilder.Append(value);
				strinbuilder.Append('\n');
			}
			return strinbuilder.ToString();
		}

		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Scan(string ext)
		{
			int n = 0;
			string user = SystemInformation.UserName;
			string dir = @"C:\Users\" + user + @"\Downloads";
			string[] files = Directory.GetFiles(dir, ext);

			foreach (string file in files)
			{
				FileInfo fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Now.AddMonths(-3))
				{
					n++;
					ListBox2.Items.Add(fi.FullName);
				}
			}
			ListBox2.Items.Add("\n");

			//Przypisuje zliczone typy plikow do licznika
			counter = counter + n;

		}

		private void Delete(string ext)
		{
			string user = SystemInformation.UserName;
			string dir = @"C:\Users\" + user + @"\Downloads";
			string[] files = Directory.GetFiles(dir, ext);

			foreach (string file in files)
			{

				FileInfo fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Now.AddMonths(-3))
				{
					ListBox2.Items.Add(fi.FullName);
				}
			}
			ListBox2.Items.Clear();
			ListBox2.Items.Add("...files have been cleaned up.");

		}

		private void ALLcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ALLcheckBox.Checked)
			{
				XMLcheckBox.Checked = false;
				XMLcheckBox.Enabled = false;
				TXTcheckBox.Checked = false;
				TXTcheckBox.Enabled = false;
				EDIcheckBox.Checked = false;
				EDIcheckBox.Enabled = false;
				MAPcheckBox.Checked = false;
				MAPcheckBox.Enabled = false;
				DOCcheckBox.Checked = false;
				DOCcheckBox.Enabled = false;
				DOCXcheckBox.Checked = false;
				DOCXcheckBox.Enabled = false;
				XLScheckBox.Checked = false;
				XLScheckBox.Enabled = false;
				XLSXcheckBox.Checked = false;
				XLSXcheckBox.Enabled = false;
				EXEcheckBox.Checked = false;
				EXEcheckBox.Enabled = false;
				PNGcheckBox.Checked = false;
				PNGcheckBox.Enabled = false;
				CSVcheckBox.Checked = false;
				CSVcheckBox.Enabled = false;
			}
			else
			{
				XMLcheckBox.Enabled = true;
				TXTcheckBox.Enabled = true;
				EDIcheckBox.Enabled = true;
				MAPcheckBox.Enabled = true;
				DOCcheckBox.Enabled = true;
				DOCXcheckBox.Enabled = true;
				XLScheckBox.Enabled = true;
				XLSXcheckBox.Enabled = true;
				EXEcheckBox.Enabled = true;
				PNGcheckBox.Enabled = true;
				CSVcheckBox.Enabled = true;
				ALLcheckBox.Checked = false;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			string question = "Are you sure you want to delete all ";

			if (MessageBox.Show(question + counter + " files?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					if (ALLcheckBox.Checked)
						Delete("*.*");
					if (XMLcheckBox.Checked)
						Delete("*.xml");
					if (TXTcheckBox.Checked)
						Delete("*.txt");
					if (EDIcheckBox.Checked)
						Delete("*.edi");
					if (MAPcheckBox.Checked)
						Delete("*.map");
					if (DOCcheckBox.Checked)
						Delete("*.doc");
					if (DOCXcheckBox.Checked)
						Delete("*.docx");
					if (XLScheckBox.Checked)
						Delete("*.xls");
					if (XLSXcheckBox.Checked)
						Delete("*.xlsx");
					if (EXEcheckBox.Checked)
						Delete("*.exe");
					if (PNGcheckBox.Checked)
						Delete("*.png");
					if (CSVcheckBox.Checked)
						Delete("*.csv");

					MessageBox.Show(@"Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//result = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + counter + " files have been cleaned up.";
				}
				catch
				{
				}
			}

			//resetuje licznik
			counter = 0;
		}
	}
}

