namespace EDISupportTool
{
	partial class Form_OutboundCL
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OutboundCL));
			this.buttonCreateOutboundCL = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxParentID_outbound = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCreateOutboundCL
			// 
			this.buttonCreateOutboundCL.Location = new System.Drawing.Point(79, 99);
			this.buttonCreateOutboundCL.Name = "buttonCreateOutboundCL";
			this.buttonCreateOutboundCL.Size = new System.Drawing.Size(131, 23);
			this.buttonCreateOutboundCL.TabIndex = 15;
			this.buttonCreateOutboundCL.Text = "Create";
			this.buttonCreateOutboundCL.UseVisualStyleBackColor = true;
			this.buttonCreateOutboundCL.Click += new System.EventHandler(this.buttonCreateOutboundCL_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "Parent name:";
			// 
			// textBoxParentID_outbound
			// 
			this.textBoxParentID_outbound.Location = new System.Drawing.Point(85, 45);
			this.textBoxParentID_outbound.Name = "textBoxParentID_outbound";
			this.textBoxParentID_outbound.Size = new System.Drawing.Size(187, 20);
			this.textBoxParentID_outbound.TabIndex = 13;
			this.textBoxParentID_outbound.TextChanged += new System.EventHandler(this.textBoxParentID_outbound_TextChanged);
			// 
			// Form_OutboundCL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 141);
			this.Controls.Add(this.buttonCreateOutboundCL);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxParentID_outbound);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_OutboundCL";
			this.Text = "myEDI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCreateOutboundCL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxParentID_outbound;
	}
}