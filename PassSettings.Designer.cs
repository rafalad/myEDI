
namespace myEDI
{
	partial class PassSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCL = new System.Windows.Forms.CheckBox();
            this.checkBoxSL = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxSC = new System.Windows.Forms.CheckBox();
            this.buttonConfirmPassword = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Capital letters:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Small letters:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Digits:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Special characters:";
            // 
            // checkBoxCL
            // 
            this.checkBoxCL.AutoSize = true;
            this.checkBoxCL.Checked = true;
            this.checkBoxCL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCL.Location = new System.Drawing.Point(133, 33);
            this.checkBoxCL.Name = "checkBoxCL";
            this.checkBoxCL.Size = new System.Drawing.Size(44, 17);
            this.checkBoxCL.TabIndex = 37;
            this.checkBoxCL.TabStop = false;
            this.checkBoxCL.Text = "Yes";
            this.checkBoxCL.UseVisualStyleBackColor = true;
            // 
            // checkBoxSL
            // 
            this.checkBoxSL.AutoSize = true;
            this.checkBoxSL.Checked = true;
            this.checkBoxSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxSL.Location = new System.Drawing.Point(133, 60);
            this.checkBoxSL.Name = "checkBoxSL";
            this.checkBoxSL.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSL.TabIndex = 38;
            this.checkBoxSL.TabStop = false;
            this.checkBoxSL.Text = "Yes";
            this.checkBoxSL.UseVisualStyleBackColor = true;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Checked = true;
            this.checkBoxD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxD.Location = new System.Drawing.Point(133, 85);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(44, 17);
            this.checkBoxD.TabIndex = 39;
            this.checkBoxD.TabStop = false;
            this.checkBoxD.Text = "Yes";
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.CheckedChanged += new System.EventHandler(this.checkBoxD_CheckedChanged);
            // 
            // checkBoxSC
            // 
            this.checkBoxSC.AutoSize = true;
            this.checkBoxSC.Checked = true;
            this.checkBoxSC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxSC.Location = new System.Drawing.Point(133, 112);
            this.checkBoxSC.Name = "checkBoxSC";
            this.checkBoxSC.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSC.TabIndex = 40;
            this.checkBoxSC.TabStop = false;
            this.checkBoxSC.Text = "Yes";
            this.checkBoxSC.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmPassword
            // 
            this.buttonConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirmPassword.Location = new System.Drawing.Point(187, 164);
            this.buttonConfirmPassword.Name = "buttonConfirmPassword";
            this.buttonConfirmPassword.Size = new System.Drawing.Size(118, 26);
            this.buttonConfirmPassword.TabIndex = 41;
            this.buttonConfirmPassword.TabStop = false;
            this.buttonConfirmPassword.Text = "Go";
            this.buttonConfirmPassword.UseVisualStyleBackColor = true;
            this.buttonConfirmPassword.Click += new System.EventHandler(this.buttonGenerateRandomPassword_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(207, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Length: ";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(203, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "Amount:";
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Items.AddRange(new object[] {
            "16",
            "24",
            "32",
            "8"});
            this.comboBoxLength.Location = new System.Drawing.Point(260, 59);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(45, 21);
            this.comboBoxLength.Sorted = true;
            this.comboBoxLength.TabIndex = 45;
            this.comboBoxLength.Text = "8";
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.comboBoxAmount.Location = new System.Drawing.Point(260, 32);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(45, 21);
            this.comboBoxAmount.Sorted = true;
            this.comboBoxAmount.TabIndex = 44;
            this.comboBoxAmount.Text = "10";
            this.comboBoxAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmount_SelectedIndexChanged);
            // 
            // PassSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxLength);
            this.Controls.Add(this.comboBoxAmount);
            this.Controls.Add(this.buttonConfirmPassword);
            this.Controls.Add(this.checkBoxSC);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxSL);
            this.Controls.Add(this.checkBoxCL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassSettings";
            this.Text = "myEDI";
            this.Load += new System.EventHandler(this.PassSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxCL;
		private System.Windows.Forms.CheckBox checkBoxSL;
		private System.Windows.Forms.CheckBox checkBoxD;
		private System.Windows.Forms.CheckBox checkBoxSC;
		private System.Windows.Forms.Button buttonConfirmPassword;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox comboBoxLength;
		private System.Windows.Forms.ComboBox comboBoxAmount;
	}
}