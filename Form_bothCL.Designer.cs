namespace myEDI
{
	partial class Form_bothCL
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_bothCL));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxChildD_both = new System.Windows.Forms.TextBox();
			this.buttonCreateBothCL = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxParentID_both = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "Child name:";
			// 
			// textBoxChildD_both
			// 
			this.textBoxChildD_both.Location = new System.Drawing.Point(87, 54);
			this.textBoxChildD_both.Name = "textBoxChildD_both";
			this.textBoxChildD_both.Size = new System.Drawing.Size(187, 20);
			this.textBoxChildD_both.TabIndex = 16;
			this.textBoxChildD_both.TextChanged += new System.EventHandler(this.textBoxChildD_both_TextChanged);
			// 
			// buttonCreateBothCL
			// 
			this.buttonCreateBothCL.Location = new System.Drawing.Point(79, 99);
			this.buttonCreateBothCL.Name = "buttonCreateBothCL";
			this.buttonCreateBothCL.Size = new System.Drawing.Size(131, 23);
			this.buttonCreateBothCL.TabIndex = 15;
			this.buttonCreateBothCL.Text = "Create";
			this.buttonCreateBothCL.UseVisualStyleBackColor = true;
			this.buttonCreateBothCL.Click += new System.EventHandler(this.buttonCreateBothCL_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "Parent name:";
			// 
			// textBoxParentID_both
			// 
			this.textBoxParentID_both.Location = new System.Drawing.Point(87, 19);
			this.textBoxParentID_both.Name = "textBoxParentID_both";
			this.textBoxParentID_both.Size = new System.Drawing.Size(187, 20);
			this.textBoxParentID_both.TabIndex = 13;
			this.textBoxParentID_both.TextChanged += new System.EventHandler(this.textBoxParentID_both_TextChanged);
			// 
			// Form_bothCL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 141);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxChildD_both);
			this.Controls.Add(this.buttonCreateBothCL);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxParentID_both);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_bothCL";
			this.Text = "myEDI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxChildD_both;
		private System.Windows.Forms.Button buttonCreateBothCL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxParentID_both;
	}
}