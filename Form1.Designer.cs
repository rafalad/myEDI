namespace EDISupportTool
{
	partial class myEDI
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox textBoxAddUserLDAP;


		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myEDI));
			this.addButton = new System.Windows.Forms.Button();
			this.textBoxAddUserLDAP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.deployComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CreateNoteButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonGenerateRandomPassword = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_modify = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button_SSH = new System.Windows.Forms.Button();
			this.button_reports = new System.Windows.Forms.Button();
			this.button_resources = new System.Windows.Forms.Button();
			this.extractRT_button = new System.Windows.Forms.Button();
			this.button_logs = new System.Windows.Forms.Button();
			this.consoleQuery_button = new System.Windows.Forms.Button();
			this.checkBox_Query = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.richTextBoxSelectedEnv = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button_local_deploy = new System.Windows.Forms.Button();
			this.checkBox_RT = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CHWnumberField = new System.Windows.Forms.TextBox();
			this.SRQidField = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SRQnumberField = new System.Windows.Forms.TextBox();
			this.CreateAnObject = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.buttonCL = new System.Windows.Forms.Button();
			this.codeListComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deployDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eDIDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lightwellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.eventLog1 = new System.Diagnostics.EventLog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.user = new System.Windows.Forms.Label();
			this.ver = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.eventLog2 = new System.Diagnostics.EventLog();
			this.eventLog3 = new System.Diagnostics.EventLog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog3)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.addButton.Location = new System.Drawing.Point(11, 82);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(68, 26);
			this.addButton.TabIndex = 1;
			this.addButton.TabStop = false;
			this.addButton.Text = "New";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// textBoxAddUserLDAP
			// 
			this.textBoxAddUserLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxAddUserLDAP.Location = new System.Drawing.Point(11, 49);
			this.textBoxAddUserLDAP.Name = "textBoxAddUserLDAP";
			this.textBoxAddUserLDAP.Size = new System.Drawing.Size(215, 20);
			this.textBoxAddUserLDAP.TabIndex = 5;
			this.textBoxAddUserLDAP.TabStop = false;
			this.textBoxAddUserLDAP.TextChanged += new System.EventHandler(this.textBoxAddUserLDAP_TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(8, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Please enter your username (cus.xxxx)";
			// 
			// deployComboBox
			// 
			this.deployComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deployComboBox.FormattingEnabled = true;
			this.deployComboBox.Items.AddRange(new object[] {
            "QA only",
            "PROD only",
            "both - QA & PROD"});
			this.deployComboBox.Location = new System.Drawing.Point(9, 56);
			this.deployComboBox.Name = "deployComboBox";
			this.deployComboBox.Size = new System.Drawing.Size(213, 21);
			this.deployComboBox.TabIndex = 9;
			this.deployComboBox.TabStop = false;
			this.deployComboBox.SelectedIndexChanged += new System.EventHandler(this.deployComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(6, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 83);
			this.label3.TabIndex = 10;
			this.label3.Text = "Please select the deployment environments:";
			// 
			// CreateNoteButton
			// 
			this.CreateNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CreateNoteButton.Location = new System.Drawing.Point(9, 162);
			this.CreateNoteButton.Name = "CreateNoteButton";
			this.CreateNoteButton.Size = new System.Drawing.Size(213, 33);
			this.CreateNoteButton.TabIndex = 11;
			this.CreateNoteButton.TabStop = false;
			this.CreateNoteButton.Text = "Create a note";
			this.CreateNoteButton.UseCompatibleTextRendering = true;
			this.CreateNoteButton.UseVisualStyleBackColor = true;
			this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.buttonGenerateRandomPassword);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(269, 295);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(251, 105);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Password Generator";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(19, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(208, 15);
			this.label9.TabIndex = 9;
			this.label9.Text = "Click to copy a password to the clipboard";
			// 
			// buttonGenerateRandomPassword
			// 
			this.buttonGenerateRandomPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonGenerateRandomPassword.Location = new System.Drawing.Point(108, 55);
			this.buttonGenerateRandomPassword.Name = "buttonGenerateRandomPassword";
			this.buttonGenerateRandomPassword.Size = new System.Drawing.Size(118, 26);
			this.buttonGenerateRandomPassword.TabIndex = 23;
			this.buttonGenerateRandomPassword.TabStop = false;
			this.buttonGenerateRandomPassword.Text = "Go";
			this.buttonGenerateRandomPassword.UseVisualStyleBackColor = true;
			this.buttonGenerateRandomPassword.Click += new System.EventHandler(this.buttonGenerateRandomPassword_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button_delete);
			this.groupBox2.Controls.Add(this.button_modify);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxAddUserLDAP);
			this.groupBox2.Controls.Add(this.addButton);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox2.Location = new System.Drawing.Point(269, 418);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(251, 123);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "LDAP user creator";
			// 
			// button_delete
			// 
			this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_delete.Location = new System.Drawing.Point(159, 82);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(68, 26);
			this.button_delete.TabIndex = 10;
			this.button_delete.TabStop = false;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_modify
			// 
			this.button_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_modify.Location = new System.Drawing.Point(85, 82);
			this.button_modify.Name = "button_modify";
			this.button_modify.Size = new System.Drawing.Size(68, 26);
			this.button_modify.TabIndex = 9;
			this.button_modify.TabStop = false;
			this.button_modify.Text = "Modify";
			this.button_modify.UseVisualStyleBackColor = true;
			this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button_SSH);
			this.groupBox3.Controls.Add(this.button_reports);
			this.groupBox3.Controls.Add(this.button_resources);
			this.groupBox3.Controls.Add(this.extractRT_button);
			this.groupBox3.Controls.Add(this.button_logs);
			this.groupBox3.Controls.Add(this.consoleQuery_button);
			this.groupBox3.Controls.Add(this.checkBox_Query);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.richTextBoxSelectedEnv);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.button_local_deploy);
			this.groupBox3.Controls.Add(this.checkBox_RT);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.deployComboBox);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.CreateNoteButton);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox3.Location = new System.Drawing.Point(12, 42);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(241, 364);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Deployment Note Wizard";
			// 
			// button_SSH
			// 
			this.button_SSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_SSH.Location = new System.Drawing.Point(36, 206);
			this.button_SSH.Name = "button_SSH";
			this.button_SSH.Size = new System.Drawing.Size(164, 34);
			this.button_SSH.TabIndex = 35;
			this.button_SSH.TabStop = false;
			this.button_SSH.Text = "Open SSH Session";
			this.button_SSH.UseVisualStyleBackColor = true;
			this.button_SSH.Click += new System.EventHandler(this.button_SSH_Click);
			// 
			// button_reports
			// 
			this.button_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_reports.Location = new System.Drawing.Point(36, 324);
			this.button_reports.Name = "button_reports";
			this.button_reports.Size = new System.Drawing.Size(80, 34);
			this.button_reports.TabIndex = 34;
			this.button_reports.TabStop = false;
			this.button_reports.Text = "Reports";
			this.button_reports.UseVisualStyleBackColor = true;
			this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
			// 
			// button_resources
			// 
			this.button_resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_resources.Location = new System.Drawing.Point(36, 284);
			this.button_resources.Name = "button_resources";
			this.button_resources.Size = new System.Drawing.Size(80, 34);
			this.button_resources.TabIndex = 33;
			this.button_resources.TabStop = false;
			this.button_resources.Text = "Resources";
			this.button_resources.UseVisualStyleBackColor = true;
			this.button_resources.Click += new System.EventHandler(this.button_resources_Click);
			// 
			// extractRT_button
			// 
			this.extractRT_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.extractRT_button.Location = new System.Drawing.Point(120, 246);
			this.extractRT_button.Name = "extractRT_button";
			this.extractRT_button.Size = new System.Drawing.Size(80, 34);
			this.extractRT_button.TabIndex = 27;
			this.extractRT_button.TabStop = false;
			this.extractRT_button.Text = "Extract RT";
			this.extractRT_button.UseVisualStyleBackColor = true;
			this.extractRT_button.Click += new System.EventHandler(this.extractRT_button_Click);
			// 
			// button_logs
			// 
			this.button_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_logs.Location = new System.Drawing.Point(120, 324);
			this.button_logs.Name = "button_logs";
			this.button_logs.Size = new System.Drawing.Size(80, 34);
			this.button_logs.TabIndex = 32;
			this.button_logs.TabStop = false;
			this.button_logs.Text = "Logs";
			this.button_logs.UseVisualStyleBackColor = true;
			this.button_logs.Click += new System.EventHandler(this.button_logs_Click);
			// 
			// consoleQuery_button
			// 
			this.consoleQuery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.consoleQuery_button.Location = new System.Drawing.Point(120, 284);
			this.consoleQuery_button.Name = "consoleQuery_button";
			this.consoleQuery_button.Size = new System.Drawing.Size(80, 34);
			this.consoleQuery_button.TabIndex = 30;
			this.consoleQuery_button.TabStop = false;
			this.consoleQuery_button.Text = "Console query";
			this.consoleQuery_button.UseVisualStyleBackColor = true;
			this.consoleQuery_button.Click += new System.EventHandler(this.consoleQuery_button_Click);
			// 
			// checkBox_Query
			// 
			this.checkBox_Query.AutoSize = true;
			this.checkBox_Query.Checked = true;
			this.checkBox_Query.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBox_Query.Location = new System.Drawing.Point(166, 136);
			this.checkBox_Query.Name = "checkBox_Query";
			this.checkBox_Query.Size = new System.Drawing.Size(44, 17);
			this.checkBox_Query.TabIndex = 29;
			this.checkBox_Query.TabStop = false;
			this.checkBox_Query.Text = "Yes";
			this.checkBox_Query.UseVisualStyleBackColor = true;
			this.checkBox_Query.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(41, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(123, 17);
			this.label11.TabIndex = 28;
			this.label11.Text = "Create a console query:";
			// 
			// richTextBoxSelectedEnv
			// 
			this.richTextBoxSelectedEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBoxSelectedEnv.Location = new System.Drawing.Point(120, 83);
			this.richTextBoxSelectedEnv.Name = "richTextBoxSelectedEnv";
			this.richTextBoxSelectedEnv.ReadOnly = true;
			this.richTextBoxSelectedEnv.Size = new System.Drawing.Size(102, 21);
			this.richTextBoxSelectedEnv.TabIndex = 26;
			this.richTextBoxSelectedEnv.TabStop = false;
			this.richTextBoxSelectedEnv.Text = "not selected";
			this.richTextBoxSelectedEnv.TextChanged += new System.EventHandler(this.richTextBoxSelectedEnv_TextChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(6, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 26;
			this.label5.Text = "Selected env.";
			// 
			// button_local_deploy
			// 
			this.button_local_deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_local_deploy.Location = new System.Drawing.Point(36, 246);
			this.button_local_deploy.Name = "button_local_deploy";
			this.button_local_deploy.Size = new System.Drawing.Size(80, 34);
			this.button_local_deploy.TabIndex = 25;
			this.button_local_deploy.TabStop = false;
			this.button_local_deploy.Text = "Deployment";
			this.button_local_deploy.UseVisualStyleBackColor = true;
			this.button_local_deploy.Click += new System.EventHandler(this.button5_Click);
			// 
			// checkBox_RT
			// 
			this.checkBox_RT.AutoSize = true;
			this.checkBox_RT.Checked = true;
			this.checkBox_RT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_RT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBox_RT.Location = new System.Drawing.Point(166, 120);
			this.checkBox_RT.Name = "checkBox_RT";
			this.checkBox_RT.Size = new System.Drawing.Size(44, 17);
			this.checkBox_RT.TabIndex = 18;
			this.checkBox_RT.TabStop = false;
			this.checkBox_RT.Text = "Yes";
			this.checkBox_RT.UseVisualStyleBackColor = true;
			this.checkBox_RT.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(12, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Copy RT files to separate dirs:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.CHWnumberField);
			this.groupBox4.Controls.Add(this.SRQidField);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.SRQnumberField);
			this.groupBox4.Controls.Add(this.CreateAnObject);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox4.Location = new System.Drawing.Point(269, 42);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(250, 247);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "New SRQ / INC";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(19, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "SRQ / INC no. from Cherwell by copying:";
			// 
			// CHWnumberField
			// 
			this.CHWnumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CHWnumberField.Location = new System.Drawing.Point(22, 60);
			this.CHWnumberField.Name = "CHWnumberField";
			this.CHWnumberField.Size = new System.Drawing.Size(204, 20);
			this.CHWnumberField.TabIndex = 22;
			this.CHWnumberField.TabStop = false;
			this.CHWnumberField.TextChanged += new System.EventHandler(this.CHWnumberField_TextChanged);
			// 
			// SRQidField
			// 
			this.SRQidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SRQidField.Location = new System.Drawing.Point(21, 170);
			this.SRQidField.Name = "SRQidField";
			this.SRQidField.Size = new System.Drawing.Size(205, 20);
			this.SRQidField.TabIndex = 20;
			this.SRQidField.TabStop = false;
			this.SRQidField.TextChanged += new System.EventHandler(this.SRQidField_TextChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(18, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(233, 26);
			this.label7.TabIndex = 19;
			this.label7.Text = "Ticket name:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(18, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(220, 22);
			this.label6.TabIndex = 18;
			this.label6.Text = "SRQ / INC number by keybord: ";
			// 
			// SRQnumberField
			// 
			this.SRQnumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SRQnumberField.Location = new System.Drawing.Point(21, 121);
			this.SRQnumberField.Name = "SRQnumberField";
			this.SRQnumberField.Size = new System.Drawing.Size(206, 20);
			this.SRQnumberField.TabIndex = 18;
			this.SRQnumberField.TabStop = false;
			this.SRQnumberField.TextChanged += new System.EventHandler(this.SRQnumberField_TextChanged);
			// 
			// CreateAnObject
			// 
			this.CreateAnObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CreateAnObject.Location = new System.Drawing.Point(108, 206);
			this.CreateAnObject.Name = "CreateAnObject";
			this.CreateAnObject.Size = new System.Drawing.Size(118, 26);
			this.CreateAnObject.TabIndex = 18;
			this.CreateAnObject.TabStop = false;
			this.CreateAnObject.Text = " Create an object";
			this.CreateAnObject.UseVisualStyleBackColor = true;
			this.CreateAnObject.Click += new System.EventHandler(this.CreateAnObject_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.buttonCL);
			this.groupBox5.Controls.Add(this.codeListComboBox);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox5.Location = new System.Drawing.Point(12, 418);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(241, 123);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Code List Creator";
			// 
			// buttonCL
			// 
			this.buttonCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonCL.Location = new System.Drawing.Point(104, 82);
			this.buttonCL.Name = "buttonCL";
			this.buttonCL.Size = new System.Drawing.Size(118, 26);
			this.buttonCL.TabIndex = 27;
			this.buttonCL.TabStop = false;
			this.buttonCL.Text = "Create CL";
			this.buttonCL.UseVisualStyleBackColor = true;
			this.buttonCL.Click += new System.EventHandler(this.buttonCL_Click);
			// 
			// codeListComboBox
			// 
			this.codeListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.codeListComboBox.FormattingEnabled = true;
			this.codeListComboBox.Items.AddRange(new object[] {
            "Inbound",
            "Outbound",
            "both"});
			this.codeListComboBox.Location = new System.Drawing.Point(9, 49);
			this.codeListComboBox.Name = "codeListComboBox";
			this.codeListComboBox.Size = new System.Drawing.Size(213, 21);
			this.codeListComboBox.TabIndex = 27;
			this.codeListComboBox.TabStop = false;
			this.codeListComboBox.SelectedIndexChanged += new System.EventHandler(this.codeListComboBox_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(6, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(220, 26);
			this.label8.TabIndex = 21;
			this.label8.Text = "Please select the flow direction:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dirsToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(984, 24);
			this.menuStrip1.TabIndex = 22;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.minimizeToolStripMenuItem.Text = "Minimize";
			this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
			// 
			// dirsToolStripMenuItem
			// 
			this.dirsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deployDirsToolStripMenuItem,
            this.eDIDirsToolStripMenuItem});
			this.dirsToolStripMenuItem.Name = "dirsToolStripMenuItem";
			this.dirsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.dirsToolStripMenuItem.Text = "Dirs";
			// 
			// deployDirsToolStripMenuItem
			// 
			this.deployDirsToolStripMenuItem.Name = "deployDirsToolStripMenuItem";
			this.deployDirsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.deployDirsToolStripMenuItem.Text = "Deploy Dirs";
			this.deployDirsToolStripMenuItem.Click += new System.EventHandler(this.deployDirsToolStripMenuItem_Click);
			// 
			// eDIDirsToolStripMenuItem
			// 
			this.eDIDirsToolStripMenuItem.Name = "eDIDirsToolStripMenuItem";
			this.eDIDirsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.eDIDirsToolStripMenuItem.Text = "EDI Dirs";
			this.eDIDirsToolStripMenuItem.Click += new System.EventHandler(this.eDIDirsToolStripMenuItem_Click);
			// 
			// linksToolStripMenuItem
			// 
			this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sIToolStripMenuItem,
            this.lightwellToolStripMenuItem});
			this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
			this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.linksToolStripMenuItem.Text = "Links";
			// 
			// sIToolStripMenuItem
			// 
			this.sIToolStripMenuItem.Name = "sIToolStripMenuItem";
			this.sIToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.sIToolStripMenuItem.Text = "SI";
			this.sIToolStripMenuItem.Click += new System.EventHandler(this.sIToolStripMenuItem_Click);
			// 
			// lightwellToolStripMenuItem
			// 
			this.lightwellToolStripMenuItem.Name = "lightwellToolStripMenuItem";
			this.lightwellToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.lightwellToolStripMenuItem.Text = "Lightwell";
			this.lightwellToolStripMenuItem.Click += new System.EventHandler(this.lightwellToolStripMenuItem_Click);
			// 
			// formsToolStripMenuItem
			// 
			this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
			this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.formsToolStripMenuItem.Text = "Forms";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 544);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(984, 22);
			this.statusStrip1.TabIndex = 28;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(916, 491);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// user
			// 
			this.user.BackColor = System.Drawing.SystemColors.MenuBar;
			this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.user.Location = new System.Drawing.Point(678, 546);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(294, 16);
			this.user.TabIndex = 23;
			this.user.Text = "login";
			this.user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ver
			// 
			this.ver.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ver.Location = new System.Drawing.Point(9, 546);
			this.ver.Name = "ver";
			this.ver.Size = new System.Drawing.Size(294, 16);
			this.ver.TabIndex = 31;
			this.ver.Text = "version";
			this.ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox6.Controls.Add(this.listBox1);
			this.groupBox6.Controls.Add(this.progressBar1);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox6.Location = new System.Drawing.Point(538, 42);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(434, 429);
			this.groupBox6.TabIndex = 32;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Event Viewer";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Info;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalExtent = 1000;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(6, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox1.Size = new System.Drawing.Size(422, 393);
			this.listBox1.TabIndex = 36;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(-268, 269);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(244, 23);
			this.progressBar1.TabIndex = 29;
			// 
			// eventLog2
			// 
			this.eventLog2.SynchronizingObject = this;
			// 
			// eventLog3
			// 
			this.eventLog3.SynchronizingObject = this;
			// 
			// myEDI
			// 
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(984, 566);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.ver);
			this.Controls.Add(this.user);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(1000, 605);
			this.MinimumSize = new System.Drawing.Size(1000, 605);
			this.Name = "myEDI";
			this.Text = "myEDI";
			this.Load += new System.EventHandler(this.EDISupportTool_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>


		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox deployComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CreateNoteButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox SRQnumberField;
		private System.Windows.Forms.Button CreateAnObject;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox SRQidField;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.CheckBox checkBox_RT;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.Button button_local_deploy;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.RichTextBox richTextBoxSelectedEnv;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonCL;
		private System.Windows.Forms.ComboBox codeListComboBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CHWnumberField;
		private System.Windows.Forms.Button extractRT_button;
		private System.Windows.Forms.Button consoleQuery_button;
		private System.Windows.Forms.CheckBox checkBox_Query;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button_logs;
		private System.Windows.Forms.Button button_resources;
		private System.Windows.Forms.Button button_reports;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonGenerateRandomPassword;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button_SSH;
		private System.Windows.Forms.Label user;
		private System.Windows.Forms.Label ver;
		private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.Button button_modify;
		private System.Windows.Forms.ToolStripMenuItem dirsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deployDirsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eDIDirsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lightwellToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Diagnostics.EventLog eventLog2;
		private System.Diagnostics.EventLog eventLog3;
	}
}

