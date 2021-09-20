
namespace myEDI
{
    partial class cleanerDownloads
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cleanerDownloads));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ALLcheckBox = new System.Windows.Forms.CheckBox();
            this.CSVcheckBox = new System.Windows.Forms.CheckBox();
            this.XLSXcheckBox = new System.Windows.Forms.CheckBox();
            this.XLScheckBox = new System.Windows.Forms.CheckBox();
            this.DOCXcheckBox = new System.Windows.Forms.CheckBox();
            this.DOCcheckBox = new System.Windows.Forms.CheckBox();
            this.PNGcheckBox = new System.Windows.Forms.CheckBox();
            this.EXEcheckBox = new System.Windows.Forms.CheckBox();
            this.MAPcheckBox = new System.Windows.Forms.CheckBox();
            this.EDIcheckBox = new System.Windows.Forms.CheckBox();
            this.TXTcheckBox = new System.Windows.Forms.CheckBox();
            this.XMLcheckBox = new System.Windows.Forms.CheckBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.ALLcheckBox);
            this.groupBox1.Controls.Add(this.CSVcheckBox);
            this.groupBox1.Controls.Add(this.XLSXcheckBox);
            this.groupBox1.Controls.Add(this.XLScheckBox);
            this.groupBox1.Controls.Add(this.DOCXcheckBox);
            this.groupBox1.Controls.Add(this.DOCcheckBox);
            this.groupBox1.Controls.Add(this.PNGcheckBox);
            this.groupBox1.Controls.Add(this.EXEcheckBox);
            this.groupBox1.Controls.Add(this.MAPcheckBox);
            this.groupBox1.Controls.Add(this.EDIcheckBox);
            this.groupBox1.Controls.Add(this.TXTcheckBox);
            this.groupBox1.Controls.Add(this.XMLcheckBox);
            this.groupBox1.Controls.Add(this.ListBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonScan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 425);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cleanerDownloads";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Files older than 3 months will be processed only.";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(473, 95);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 26);
            this.buttonDelete.TabIndex = 53;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ALLcheckBox
            // 
            this.ALLcheckBox.AutoSize = true;
            this.ALLcheckBox.Checked = true;
            this.ALLcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ALLcheckBox.Location = new System.Drawing.Point(28, 63);
            this.ALLcheckBox.Name = "ALLcheckBox";
            this.ALLcheckBox.Size = new System.Drawing.Size(48, 17);
            this.ALLcheckBox.TabIndex = 52;
            this.ALLcheckBox.Text = "ALL";
            this.ALLcheckBox.UseVisualStyleBackColor = true;
            this.ALLcheckBox.CheckedChanged += new System.EventHandler(this.ALLcheckBox_CheckedChanged);
            // 
            // CSVcheckBox
            // 
            this.CSVcheckBox.AutoSize = true;
            this.CSVcheckBox.Enabled = false;
            this.CSVcheckBox.Location = new System.Drawing.Point(234, 109);
            this.CSVcheckBox.Name = "CSVcheckBox";
            this.CSVcheckBox.Size = new System.Drawing.Size(50, 17);
            this.CSVcheckBox.TabIndex = 51;
            this.CSVcheckBox.Text = ".csv";
            this.CSVcheckBox.UseVisualStyleBackColor = true;
            // 
            // XLSXcheckBox
            // 
            this.XLSXcheckBox.AutoSize = true;
            this.XLSXcheckBox.Enabled = false;
            this.XLSXcheckBox.Location = new System.Drawing.Point(234, 86);
            this.XLSXcheckBox.Name = "XLSXcheckBox";
            this.XLSXcheckBox.Size = new System.Drawing.Size(51, 17);
            this.XLSXcheckBox.TabIndex = 50;
            this.XLSXcheckBox.Text = ".xlsx";
            this.XLSXcheckBox.UseVisualStyleBackColor = true;
            // 
            // XLScheckBox
            // 
            this.XLScheckBox.AutoSize = true;
            this.XLScheckBox.Enabled = false;
            this.XLScheckBox.Location = new System.Drawing.Point(234, 63);
            this.XLScheckBox.Name = "XLScheckBox";
            this.XLScheckBox.Size = new System.Drawing.Size(45, 17);
            this.XLScheckBox.TabIndex = 49;
            this.XLScheckBox.Text = ".xls";
            this.XLScheckBox.UseVisualStyleBackColor = true;
            // 
            // DOCXcheckBox
            // 
            this.DOCXcheckBox.AutoSize = true;
            this.DOCXcheckBox.Enabled = false;
            this.DOCXcheckBox.Location = new System.Drawing.Point(133, 88);
            this.DOCXcheckBox.Name = "DOCXcheckBox";
            this.DOCXcheckBox.Size = new System.Drawing.Size(57, 17);
            this.DOCXcheckBox.TabIndex = 48;
            this.DOCXcheckBox.Text = ".docx";
            this.DOCXcheckBox.UseVisualStyleBackColor = true;
            // 
            // DOCcheckBox
            // 
            this.DOCcheckBox.AutoSize = true;
            this.DOCcheckBox.Enabled = false;
            this.DOCcheckBox.Location = new System.Drawing.Point(133, 63);
            this.DOCcheckBox.Name = "DOCcheckBox";
            this.DOCcheckBox.Size = new System.Drawing.Size(51, 17);
            this.DOCcheckBox.TabIndex = 47;
            this.DOCcheckBox.Text = ".doc";
            this.DOCcheckBox.UseVisualStyleBackColor = true;
            // 
            // PNGcheckBox
            // 
            this.PNGcheckBox.AutoSize = true;
            this.PNGcheckBox.Enabled = false;
            this.PNGcheckBox.Location = new System.Drawing.Point(133, 132);
            this.PNGcheckBox.Name = "PNGcheckBox";
            this.PNGcheckBox.Size = new System.Drawing.Size(51, 17);
            this.PNGcheckBox.TabIndex = 46;
            this.PNGcheckBox.Text = ".png";
            this.PNGcheckBox.UseVisualStyleBackColor = true;
            // 
            // EXEcheckBox
            // 
            this.EXEcheckBox.AutoSize = true;
            this.EXEcheckBox.Enabled = false;
            this.EXEcheckBox.Location = new System.Drawing.Point(133, 109);
            this.EXEcheckBox.Name = "EXEcheckBox";
            this.EXEcheckBox.Size = new System.Drawing.Size(50, 17);
            this.EXEcheckBox.TabIndex = 45;
            this.EXEcheckBox.Text = ".exe";
            this.EXEcheckBox.UseVisualStyleBackColor = true;
            // 
            // MAPcheckBox
            // 
            this.MAPcheckBox.AutoSize = true;
            this.MAPcheckBox.Enabled = false;
            this.MAPcheckBox.Location = new System.Drawing.Point(28, 132);
            this.MAPcheckBox.Name = "MAPcheckBox";
            this.MAPcheckBox.Size = new System.Drawing.Size(53, 17);
            this.MAPcheckBox.TabIndex = 44;
            this.MAPcheckBox.Text = ".map";
            this.MAPcheckBox.UseVisualStyleBackColor = true;
            // 
            // EDIcheckBox
            // 
            this.EDIcheckBox.AutoSize = true;
            this.EDIcheckBox.Enabled = false;
            this.EDIcheckBox.Location = new System.Drawing.Point(28, 109);
            this.EDIcheckBox.Name = "EDIcheckBox";
            this.EDIcheckBox.Size = new System.Drawing.Size(47, 17);
            this.EDIcheckBox.TabIndex = 43;
            this.EDIcheckBox.Text = ".edi";
            this.EDIcheckBox.UseVisualStyleBackColor = true;
            // 
            // TXTcheckBox
            // 
            this.TXTcheckBox.AutoSize = true;
            this.TXTcheckBox.Enabled = false;
            this.TXTcheckBox.Location = new System.Drawing.Point(28, 86);
            this.TXTcheckBox.Name = "TXTcheckBox";
            this.TXTcheckBox.Size = new System.Drawing.Size(44, 17);
            this.TXTcheckBox.TabIndex = 42;
            this.TXTcheckBox.Text = ".txt";
            this.TXTcheckBox.UseVisualStyleBackColor = true;
            // 
            // XMLcheckBox
            // 
            this.XMLcheckBox.AutoSize = true;
            this.XMLcheckBox.Enabled = false;
            this.XMLcheckBox.Location = new System.Drawing.Point(234, 132);
            this.XMLcheckBox.Name = "XMLcheckBox";
            this.XMLcheckBox.Size = new System.Drawing.Size(48, 17);
            this.XMLcheckBox.TabIndex = 41;
            this.XMLcheckBox.Text = ".xml";
            this.XMLcheckBox.UseVisualStyleBackColor = true;
            // 
            // ListBox2
            // 
            this.ListBox2.BackColor = System.Drawing.Color.Azure;
            this.ListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListBox2.ForeColor = System.Drawing.Color.Navy;
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.HorizontalExtent = 1000;
            this.ListBox2.IntegralHeight = false;
            this.ListBox2.Location = new System.Drawing.Point(0, 165);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox2.Size = new System.Drawing.Size(688, 260);
            this.ListBox2.TabIndex = 40;
            this.ListBox2.TabStop = false;
            this.ListBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(590, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Select the file extensions you would like to delete from the Downloads folder.";
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScan.Location = new System.Drawing.Point(473, 63);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(118, 26);
            this.buttonScan.TabIndex = 23;
            this.buttonScan.TabStop = false;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // cleanerDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(712, 449);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cleanerDownloads";
            this.Text = "myEDI";
            this.Load += new System.EventHandler(this.cleanerDownloads_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.CheckBox ALLcheckBox;
        private System.Windows.Forms.CheckBox CSVcheckBox;
        private System.Windows.Forms.CheckBox XLSXcheckBox;
        private System.Windows.Forms.CheckBox XLScheckBox;
        private System.Windows.Forms.CheckBox DOCXcheckBox;
        private System.Windows.Forms.CheckBox DOCcheckBox;
        private System.Windows.Forms.CheckBox PNGcheckBox;
        private System.Windows.Forms.CheckBox EXEcheckBox;
        private System.Windows.Forms.CheckBox MAPcheckBox;
        private System.Windows.Forms.CheckBox EDIcheckBox;
        private System.Windows.Forms.CheckBox TXTcheckBox;
        private System.Windows.Forms.CheckBox XMLcheckBox;
        public System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
    }
}