namespace myEDI
{
	partial class Form_InboundCL
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InboundCL));
			this.textBoxParentID_inbound = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonCreateInboundCL = new System.Windows.Forms.Button();
			this.textBoxChildD_inbound = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxParentID_inbound
			// 
			this.textBoxParentID_inbound.Location = new System.Drawing.Point(88, 20);
			this.textBoxParentID_inbound.Name = "textBoxParentID_inbound";
			this.textBoxParentID_inbound.Size = new System.Drawing.Size(187, 20);
			this.textBoxParentID_inbound.TabIndex = 0;
			this.textBoxParentID_inbound.TextChanged += new System.EventHandler(this.textBoxParentID_inbound_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Parent name:";
			// 
			// buttonCreateInboundCL
			// 
			this.buttonCreateInboundCL.Location = new System.Drawing.Point(80, 100);
			this.buttonCreateInboundCL.Name = "buttonCreateInboundCL";
			this.buttonCreateInboundCL.Size = new System.Drawing.Size(131, 23);
			this.buttonCreateInboundCL.TabIndex = 10;
			this.buttonCreateInboundCL.Text = "Create";
			this.buttonCreateInboundCL.UseVisualStyleBackColor = true;
			this.buttonCreateInboundCL.Click += new System.EventHandler(this.buttonCreateInboundCL_Click);
			// 
			// textBoxChildD_inbound
			// 
			this.textBoxChildD_inbound.Location = new System.Drawing.Point(88, 55);
			this.textBoxChildD_inbound.Name = "textBoxChildD_inbound";
			this.textBoxChildD_inbound.Size = new System.Drawing.Size(187, 20);
			this.textBoxChildD_inbound.TabIndex = 11;
			this.textBoxChildD_inbound.TextChanged += new System.EventHandler(this.textBoxChildD_inbound_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "Child name:";
			// 
			// Form_InboundCL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 141);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxChildD_inbound);
			this.Controls.Add(this.buttonCreateInboundCL);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxParentID_inbound);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_InboundCL";
			this.Text = "myEDI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxParentID_inbound;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCreateInboundCL;
		private System.Windows.Forms.TextBox textBoxChildD_inbound;
		private System.Windows.Forms.Label label1;
	}
}