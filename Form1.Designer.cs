namespace myEDI
{
	partial class MyEDI
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEDI));
            this.textBoxAddUserLDAP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deployComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMoreSettings = new System.Windows.Forms.Button();
            this.comboBoxPass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGenerateRandomPassword = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLDAPno = new System.Windows.Forms.CheckBox();
            this.checkBoxPass24 = new System.Windows.Forms.CheckBox();
            this.checkBoxPass16 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxPass8 = new System.Windows.Forms.CheckBox();
            this.checkBoxLDAP = new System.Windows.Forms.CheckBox();
            this.comboBoxLDAP = new System.Windows.Forms.ComboBox();
            this.buttonGoLDAP = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.checkBox_maps = new System.Windows.Forms.CheckBox();
            this.comboBox_setup = new System.Windows.Forms.ComboBox();
            this.checkBoxSRQ = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_other = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CHWnumberField = new System.Windows.Forms.TextBox();
            this.SRQidField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_cl = new System.Windows.Forms.CheckBox();
            this.CreateAnObject = new System.Windows.Forms.Button();
            this.checkBox_setup = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_cl_both = new System.Windows.Forms.CheckBox();
            this.buttonCL = new System.Windows.Forms.Button();
            this.checkBox_cl_out = new System.Windows.Forms.CheckBox();
            this.checkBox_cl_in = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanEventViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleEntriesCLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gentranGenericListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDIDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightwellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ver = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.eventLog3 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.latest_ver = new System.Windows.Forms.Label();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanerDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // textBoxAddUserLDAP
            // 
            this.textBoxAddUserLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddUserLDAP.Location = new System.Drawing.Point(11, 57);
            this.textBoxAddUserLDAP.Name = "textBoxAddUserLDAP";
            this.textBoxAddUserLDAP.Size = new System.Drawing.Size(256, 20);
            this.textBoxAddUserLDAP.TabIndex = 4;
            this.textBoxAddUserLDAP.TextChanged += new System.EventHandler(this.TextBoxAddUserLDAP_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please enter your username (cus.xxxx)";
            // 
            // deployComboBox
            // 
            this.deployComboBox.AccessibleName = "";
            this.deployComboBox.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.deployComboBox.Text = "QA only";
            this.deployComboBox.SelectedIndexChanged += new System.EventHandler(this.DeployComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please select the deployment environments:";
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNoteButton.Location = new System.Drawing.Point(9, 192);
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
            this.groupBox1.Controls.Add(this.buttonMoreSettings);
            this.groupBox1.Controls.Add(this.comboBoxPass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonGenerateRandomPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(537, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 121);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // buttonMoreSettings
            // 
            this.buttonMoreSettings.Enabled = false;
            this.buttonMoreSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoreSettings.Location = new System.Drawing.Point(198, 47);
            this.buttonMoreSettings.Name = "buttonMoreSettings";
            this.buttonMoreSettings.Size = new System.Drawing.Size(69, 21);
            this.buttonMoreSettings.TabIndex = 35;
            this.buttonMoreSettings.TabStop = false;
            this.buttonMoreSettings.Text = "settings";
            this.buttonMoreSettings.UseVisualStyleBackColor = true;
            this.buttonMoreSettings.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxPass
            // 
            this.comboBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPass.FormattingEnabled = true;
            this.comboBoxPass.Items.AddRange(new object[] {
            "multiple",
            "single"});
            this.comboBoxPass.Location = new System.Drawing.Point(198, 20);
            this.comboBoxPass.Name = "comboBoxPass";
            this.comboBoxPass.Size = new System.Drawing.Size(69, 21);
            this.comboBoxPass.Sorted = true;
            this.comboBoxPass.TabIndex = 39;
            this.comboBoxPass.Text = "single";
            this.comboBoxPass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(89, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Type of password:";
            // 
            // buttonGenerateRandomPassword
            // 
            this.buttonGenerateRandomPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateRandomPassword.Location = new System.Drawing.Point(149, 79);
            this.buttonGenerateRandomPassword.Name = "buttonGenerateRandomPassword";
            this.buttonGenerateRandomPassword.Size = new System.Drawing.Size(118, 26);
            this.buttonGenerateRandomPassword.TabIndex = 23;
            this.buttonGenerateRandomPassword.TabStop = false;
            this.buttonGenerateRandomPassword.Text = "Go";
            this.buttonGenerateRandomPassword.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomPassword.Click += new System.EventHandler(this.ButtonGenerateRandomPassword_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.checkBoxLDAPno);
            this.groupBox2.Controls.Add(this.checkBoxPass24);
            this.groupBox2.Controls.Add(this.checkBoxPass16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.checkBoxPass8);
            this.groupBox2.Controls.Add(this.checkBoxLDAP);
            this.groupBox2.Controls.Add(this.comboBoxLDAP);
            this.groupBox2.Controls.Add(this.buttonGoLDAP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxAddUserLDAP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(537, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 282);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LDAP";
            // 
            // checkBoxLDAPno
            // 
            this.checkBoxLDAPno.AutoSize = true;
            this.checkBoxLDAPno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLDAPno.Location = new System.Drawing.Point(229, 161);
            this.checkBoxLDAPno.Name = "checkBoxLDAPno";
            this.checkBoxLDAPno.Size = new System.Drawing.Size(40, 17);
            this.checkBoxLDAPno.TabIndex = 40;
            this.checkBoxLDAPno.TabStop = false;
            this.checkBoxLDAPno.Text = "No";
            this.checkBoxLDAPno.UseVisualStyleBackColor = true;
            this.checkBoxLDAPno.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // checkBoxPass24
            // 
            this.checkBoxPass24.AutoSize = true;
            this.checkBoxPass24.Checked = true;
            this.checkBoxPass24.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPass24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPass24.Location = new System.Drawing.Point(229, 138);
            this.checkBoxPass24.Name = "checkBoxPass24";
            this.checkBoxPass24.Size = new System.Drawing.Size(38, 17);
            this.checkBoxPass24.TabIndex = 24;
            this.checkBoxPass24.TabStop = false;
            this.checkBoxPass24.Text = "24";
            this.checkBoxPass24.UseVisualStyleBackColor = true;
            this.checkBoxPass24.CheckedChanged += new System.EventHandler(this.CheckBoxPass24_CheckedChanged);
            // 
            // checkBoxPass16
            // 
            this.checkBoxPass16.AutoSize = true;
            this.checkBoxPass16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPass16.Location = new System.Drawing.Point(185, 138);
            this.checkBoxPass16.Name = "checkBoxPass16";
            this.checkBoxPass16.Size = new System.Drawing.Size(38, 17);
            this.checkBoxPass16.TabIndex = 39;
            this.checkBoxPass16.TabStop = false;
            this.checkBoxPass16.Text = "16";
            this.checkBoxPass16.UseVisualStyleBackColor = true;
            this.checkBoxPass16.CheckedChanged += new System.EventHandler(this.CheckBoxPass16_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(19, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 38;
            this.label14.Text = "Password length:";
            // 
            // checkBoxPass8
            // 
            this.checkBoxPass8.AutoSize = true;
            this.checkBoxPass8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPass8.Location = new System.Drawing.Point(147, 138);
            this.checkBoxPass8.Name = "checkBoxPass8";
            this.checkBoxPass8.Size = new System.Drawing.Size(32, 17);
            this.checkBoxPass8.TabIndex = 37;
            this.checkBoxPass8.TabStop = false;
            this.checkBoxPass8.Text = "8";
            this.checkBoxPass8.UseVisualStyleBackColor = true;
            this.checkBoxPass8.CheckedChanged += new System.EventHandler(this.CheckBoxPass8_CheckedChanged);
            // 
            // checkBoxLDAP
            // 
            this.checkBoxLDAP.AutoSize = true;
            this.checkBoxLDAP.Checked = true;
            this.checkBoxLDAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLDAP.Location = new System.Drawing.Point(185, 161);
            this.checkBoxLDAP.Name = "checkBoxLDAP";
            this.checkBoxLDAP.Size = new System.Drawing.Size(44, 17);
            this.checkBoxLDAP.TabIndex = 36;
            this.checkBoxLDAP.TabStop = false;
            this.checkBoxLDAP.Text = "Yes";
            this.checkBoxLDAP.UseVisualStyleBackColor = true;
            this.checkBoxLDAP.CheckedChanged += new System.EventHandler(this.CheckBoxLDAP_CheckedChanged);
            // 
            // comboBoxLDAP
            // 
            this.comboBoxLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxLDAP.FormattingEnabled = true;
            this.comboBoxLDAP.Items.AddRange(new object[] {
            "New user",
            "Bulk user",
            "SSHKey user",
            "Modify user",
            "Delete user",
            "Remove SSHkey"});
            this.comboBoxLDAP.Location = new System.Drawing.Point(149, 99);
            this.comboBoxLDAP.Name = "comboBoxLDAP";
            this.comboBoxLDAP.Size = new System.Drawing.Size(118, 21);
            this.comboBoxLDAP.TabIndex = 5;
            this.comboBoxLDAP.Text = "New user";
            this.comboBoxLDAP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLDAP_SelectedIndexChanged);
            // 
            // buttonGoLDAP
            // 
            this.buttonGoLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoLDAP.Location = new System.Drawing.Point(149, 192);
            this.buttonGoLDAP.Name = "buttonGoLDAP";
            this.buttonGoLDAP.Size = new System.Drawing.Size(118, 26);
            this.buttonGoLDAP.TabIndex = 24;
            this.buttonGoLDAP.TabStop = false;
            this.buttonGoLDAP.Text = "Go";
            this.buttonGoLDAP.UseVisualStyleBackColor = true;
            this.buttonGoLDAP.Click += new System.EventHandler(this.ButtonGoLDAP_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(19, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 27);
            this.label12.TabIndex = 36;
            this.label12.Text = "+ Word Doc credentials Form?";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(73, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Type of file:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.groupBox3.Location = new System.Drawing.Point(9, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 409);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deployment";
            // 
            // button_reports
            // 
            this.button_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reports.Location = new System.Drawing.Point(36, 326);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(80, 34);
            this.button_reports.TabIndex = 34;
            this.button_reports.TabStop = false;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.Button_reports_Click);
            // 
            // button_resources
            // 
            this.button_resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_resources.Location = new System.Drawing.Point(36, 286);
            this.button_resources.Name = "button_resources";
            this.button_resources.Size = new System.Drawing.Size(80, 34);
            this.button_resources.TabIndex = 33;
            this.button_resources.TabStop = false;
            this.button_resources.Text = "Resources";
            this.button_resources.UseVisualStyleBackColor = true;
            this.button_resources.Click += new System.EventHandler(this.Button_resources_Click);
            // 
            // extractRT_button
            // 
            this.extractRT_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extractRT_button.Location = new System.Drawing.Point(120, 248);
            this.extractRT_button.Name = "extractRT_button";
            this.extractRT_button.Size = new System.Drawing.Size(80, 34);
            this.extractRT_button.TabIndex = 27;
            this.extractRT_button.TabStop = false;
            this.extractRT_button.Text = "Extract RT";
            this.extractRT_button.UseVisualStyleBackColor = true;
            this.extractRT_button.Click += new System.EventHandler(this.ExtractRT_button_Click);
            // 
            // button_logs
            // 
            this.button_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logs.Location = new System.Drawing.Point(120, 326);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(80, 34);
            this.button_logs.TabIndex = 32;
            this.button_logs.TabStop = false;
            this.button_logs.Text = "Logs";
            this.button_logs.UseVisualStyleBackColor = true;
            this.button_logs.Click += new System.EventHandler(this.Button_logs_Click);
            // 
            // consoleQuery_button
            // 
            this.consoleQuery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.consoleQuery_button.Location = new System.Drawing.Point(120, 286);
            this.consoleQuery_button.Name = "consoleQuery_button";
            this.consoleQuery_button.Size = new System.Drawing.Size(80, 34);
            this.consoleQuery_button.TabIndex = 30;
            this.consoleQuery_button.TabStop = false;
            this.consoleQuery_button.Text = "Console query";
            this.consoleQuery_button.UseVisualStyleBackColor = true;
            this.consoleQuery_button.Click += new System.EventHandler(this.ConsoleQuery_button_Click);
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
            this.checkBox_Query.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(41, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 34);
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
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Selected env.";
            // 
            // button_local_deploy
            // 
            this.button_local_deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_local_deploy.Location = new System.Drawing.Point(36, 248);
            this.button_local_deploy.Name = "button_local_deploy";
            this.button_local_deploy.Size = new System.Drawing.Size(80, 34);
            this.button_local_deploy.TabIndex = 25;
            this.button_local_deploy.TabStop = false;
            this.button_local_deploy.Text = "Storage";
            this.button_local_deploy.UseVisualStyleBackColor = true;
            this.button_local_deploy.Click += new System.EventHandler(this.Button5_Click);
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
            this.checkBox_RT.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Copy RT files to separate dirs:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.checkBox_maps);
            this.groupBox4.Controls.Add(this.comboBox_setup);
            this.groupBox4.Controls.Add(this.checkBoxSRQ);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.checkBox_other);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CHWnumberField);
            this.groupBox4.Controls.Add(this.SRQidField);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.checkBox_cl);
            this.groupBox4.Controls.Add(this.CreateAnObject);
            this.groupBox4.Controls.Add(this.checkBox_setup);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(256, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 282);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Workspace";
            // 
            // checkBox_maps
            // 
            this.checkBox_maps.AutoSize = true;
            this.checkBox_maps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_maps.Location = new System.Drawing.Point(88, 154);
            this.checkBox_maps.Name = "checkBox_maps";
            this.checkBox_maps.Size = new System.Drawing.Size(52, 17);
            this.checkBox_maps.TabIndex = 44;
            this.checkBox_maps.TabStop = false;
            this.checkBox_maps.Text = "Maps";
            this.checkBox_maps.UseVisualStyleBackColor = true;
            this.checkBox_maps.CheckedChanged += new System.EventHandler(this.checkBox_maps_CheckedChanged);
            // 
            // comboBox_setup
            // 
            this.comboBox_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_setup.FormattingEnabled = true;
            this.comboBox_setup.Items.AddRange(new object[] {
            "CL both flows",
            "CL in",
            "CL out",
            "CW both flows",
            "CW in",
            "CW out",
            "CW1 both flows",
            "CW1 in",
            "CW1 out",
            "myDSV",
            "other",
            "Passthrough"});
            this.comboBox_setup.Location = new System.Drawing.Point(154, 134);
            this.comboBox_setup.Name = "comboBox_setup";
            this.comboBox_setup.Size = new System.Drawing.Size(99, 21);
            this.comboBox_setup.Sorted = true;
            this.comboBox_setup.TabIndex = 40;
            this.comboBox_setup.Text = "CL both flows";
            // 
            // checkBoxSRQ
            // 
            this.checkBoxSRQ.AutoSize = true;
            this.checkBoxSRQ.Checked = true;
            this.checkBoxSRQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSRQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxSRQ.Location = new System.Drawing.Point(216, 218);
            this.checkBoxSRQ.Name = "checkBoxSRQ";
            this.checkBoxSRQ.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSRQ.TabIndex = 38;
            this.checkBoxSRQ.TabStop = false;
            this.checkBoxSRQ.Text = "Yes";
            this.checkBoxSRQ.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(86, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "+ Deploy Request Form?";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Type of dir for:";
            // 
            // checkBox_other
            // 
            this.checkBox_other.AutoSize = true;
            this.checkBox_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_other.Location = new System.Drawing.Point(88, 191);
            this.checkBox_other.Name = "checkBox_other";
            this.checkBox_other.Size = new System.Drawing.Size(52, 17);
            this.checkBox_other.TabIndex = 41;
            this.checkBox_other.TabStop = false;
            this.checkBox_other.Text = "Other";
            this.checkBox_other.UseVisualStyleBackColor = true;
            this.checkBox_other.CheckedChanged += new System.EventHandler(this.checkBox_other_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "SRQ / INC no. from Cherwell by copying:";
            // 
            // CHWnumberField
            // 
            this.CHWnumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CHWnumberField.Location = new System.Drawing.Point(9, 56);
            this.CHWnumberField.Name = "CHWnumberField";
            this.CHWnumberField.Size = new System.Drawing.Size(244, 20);
            this.CHWnumberField.TabIndex = 1;
            // 
            // SRQidField
            // 
            this.SRQidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SRQidField.Location = new System.Drawing.Point(9, 100);
            this.SRQidField.Name = "SRQidField";
            this.SRQidField.Size = new System.Drawing.Size(244, 20);
            this.SRQidField.TabIndex = 2;
            this.SRQidField.TextChanged += new System.EventHandler(this.SRQidField_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(5, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ticket name:";
            // 
            // checkBox_cl
            // 
            this.checkBox_cl.AutoSize = true;
            this.checkBox_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_cl.Location = new System.Drawing.Point(88, 172);
            this.checkBox_cl.Name = "checkBox_cl";
            this.checkBox_cl.Size = new System.Drawing.Size(63, 17);
            this.checkBox_cl.TabIndex = 43;
            this.checkBox_cl.TabStop = false;
            this.checkBox_cl.Text = "Codelist";
            this.checkBox_cl.UseVisualStyleBackColor = true;
            this.checkBox_cl.CheckedChanged += new System.EventHandler(this.checkBox_cl_CheckedChanged);
            // 
            // CreateAnObject
            // 
            this.CreateAnObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAnObject.Location = new System.Drawing.Point(135, 247);
            this.CreateAnObject.Name = "CreateAnObject";
            this.CreateAnObject.Size = new System.Drawing.Size(118, 26);
            this.CreateAnObject.TabIndex = 18;
            this.CreateAnObject.TabStop = false;
            this.CreateAnObject.Text = " Create";
            this.CreateAnObject.UseVisualStyleBackColor = true;
            this.CreateAnObject.Click += new System.EventHandler(this.CreateAnObject_Click);
            // 
            // checkBox_setup
            // 
            this.checkBox_setup.AutoSize = true;
            this.checkBox_setup.Checked = true;
            this.checkBox_setup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_setup.Location = new System.Drawing.Point(88, 136);
            this.checkBox_setup.Name = "checkBox_setup";
            this.checkBox_setup.Size = new System.Drawing.Size(62, 17);
            this.checkBox_setup.TabIndex = 42;
            this.checkBox_setup.TabStop = false;
            this.checkBox_setup.Text = "SETUP";
            this.checkBox_setup.UseVisualStyleBackColor = true;
            this.checkBox_setup.CheckedChanged += new System.EventHandler(this.checkBox_setup_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_cl_both);
            this.groupBox5.Controls.Add(this.buttonCL);
            this.groupBox5.Controls.Add(this.checkBox_cl_out);
            this.groupBox5.Controls.Add(this.checkBox_cl_in);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(256, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 121);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Code List";
            // 
            // checkBox_cl_both
            // 
            this.checkBox_cl_both.AutoSize = true;
            this.checkBox_cl_both.Checked = true;
            this.checkBox_cl_both.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_cl_both.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_cl_both.Location = new System.Drawing.Point(206, 49);
            this.checkBox_cl_both.Name = "checkBox_cl_both";
            this.checkBox_cl_both.Size = new System.Drawing.Size(47, 17);
            this.checkBox_cl_both.TabIndex = 41;
            this.checkBox_cl_both.TabStop = false;
            this.checkBox_cl_both.Text = "both";
            this.checkBox_cl_both.UseVisualStyleBackColor = true;
            this.checkBox_cl_both.CheckedChanged += new System.EventHandler(this.checkBox_cl_both_CheckedChanged);
            // 
            // buttonCL
            // 
            this.buttonCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCL.Location = new System.Drawing.Point(135, 79);
            this.buttonCL.Name = "buttonCL";
            this.buttonCL.Size = new System.Drawing.Size(118, 26);
            this.buttonCL.TabIndex = 27;
            this.buttonCL.TabStop = false;
            this.buttonCL.Text = "Create";
            this.buttonCL.UseVisualStyleBackColor = true;
            this.buttonCL.Click += new System.EventHandler(this.ButtonCL_Click);
            // 
            // checkBox_cl_out
            // 
            this.checkBox_cl_out.AutoSize = true;
            this.checkBox_cl_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_cl_out.Location = new System.Drawing.Point(127, 49);
            this.checkBox_cl_out.Name = "checkBox_cl_out";
            this.checkBox_cl_out.Size = new System.Drawing.Size(73, 17);
            this.checkBox_cl_out.TabIndex = 43;
            this.checkBox_cl_out.TabStop = false;
            this.checkBox_cl_out.Text = "Outbound";
            this.checkBox_cl_out.UseVisualStyleBackColor = true;
            this.checkBox_cl_out.CheckedChanged += new System.EventHandler(this.checkBox_cl_out_CheckedChanged);
            // 
            // checkBox_cl_in
            // 
            this.checkBox_cl_in.AutoSize = true;
            this.checkBox_cl_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_cl_in.Location = new System.Drawing.Point(56, 49);
            this.checkBox_cl_in.Name = "checkBox_cl_in";
            this.checkBox_cl_in.Size = new System.Drawing.Size(65, 17);
            this.checkBox_cl_in.TabIndex = 42;
            this.checkBox_cl_in.TabStop = false;
            this.checkBox_cl_in.Text = "Inbound";
            this.checkBox_cl_in.UseVisualStyleBackColor = true;
            this.checkBox_cl_in.CheckedChanged += new System.EventHandler(this.checkBox_cl_in_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Flow direction:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem1,
            this.dirsToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.linksToolStripMenuItem1,
            this.formsToolStripMenuItem1,
            this.aboutToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem1,
            this.cleanEventViewerToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // minimizeToolStripMenuItem1
            // 
            this.minimizeToolStripMenuItem1.Name = "minimizeToolStripMenuItem1";
            this.minimizeToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.minimizeToolStripMenuItem1.Text = "Minimize";
            this.minimizeToolStripMenuItem1.Click += new System.EventHandler(this.MinimizeToolStripMenuItem1_Click);
            // 
            // cleanEventViewerToolStripMenuItem
            // 
            this.cleanEventViewerToolStripMenuItem.Name = "cleanEventViewerToolStripMenuItem";
            this.cleanEventViewerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cleanEventViewerToolStripMenuItem.Text = "Clean Event Viewer";
            this.cleanEventViewerToolStripMenuItem.Click += new System.EventHandler(this.CleanEventViewerToolStripMenuItem_Click);
            // 
            // dirsToolStripMenuItem1
            // 
            this.dirsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDirResourcesToolStripMenuItem});
            this.dirsToolStripMenuItem1.Name = "dirsToolStripMenuItem1";
            this.dirsToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.dirsToolStripMenuItem1.Text = "Dirs";
            // 
            // createDirResourcesToolStripMenuItem
            // 
            this.createDirResourcesToolStripMenuItem.Name = "createDirResourcesToolStripMenuItem";
            this.createDirResourcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createDirResourcesToolStripMenuItem.Text = "Create dir resources";
            this.createDirResourcesToolStripMenuItem.Click += new System.EventHandler(this.CreateDirResourcesToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem1
            // 
            this.linksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lWToolStripMenuItem,
            this.sIToolStripMenuItem2});
            this.linksToolStripMenuItem1.Name = "linksToolStripMenuItem1";
            this.linksToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.linksToolStripMenuItem1.Text = "Links";
            // 
            // lWToolStripMenuItem
            // 
            this.lWToolStripMenuItem.Name = "lWToolStripMenuItem";
            this.lWToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.lWToolStripMenuItem.Text = "LW";
            this.lWToolStripMenuItem.Click += new System.EventHandler(this.LWToolStripMenuItem_Click);
            // 
            // sIToolStripMenuItem2
            // 
            this.sIToolStripMenuItem2.Name = "sIToolStripMenuItem2";
            this.sIToolStripMenuItem2.Size = new System.Drawing.Size(90, 22);
            this.sIToolStripMenuItem2.Text = "SI";
            this.sIToolStripMenuItem2.Click += new System.EventHandler(this.SIToolStripMenuItem2_Click);
            // 
            // formsToolStripMenuItem1
            // 
            this.formsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTPProcedureToolStripMenuItem,
            this.multipleEntriesCLToolStripMenuItem,
            this.deployRequestToolStripMenuItem,
            this.gentranGenericListToolStripMenuItem});
            this.formsToolStripMenuItem1.Name = "formsToolStripMenuItem1";
            this.formsToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem1.Text = "Forms";
            // 
            // fTPProcedureToolStripMenuItem
            // 
            this.fTPProcedureToolStripMenuItem.Name = "fTPProcedureToolStripMenuItem";
            this.fTPProcedureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fTPProcedureToolStripMenuItem.Text = "FTP procedure";
            this.fTPProcedureToolStripMenuItem.Click += new System.EventHandler(this.FTPProcedureToolStripMenuItem_Click);
            // 
            // multipleEntriesCLToolStripMenuItem
            // 
            this.multipleEntriesCLToolStripMenuItem.Name = "multipleEntriesCLToolStripMenuItem";
            this.multipleEntriesCLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multipleEntriesCLToolStripMenuItem.Text = "Multiple entries CL";
            this.multipleEntriesCLToolStripMenuItem.Click += new System.EventHandler(this.MultipleEntriesCLToolStripMenuItem_Click);
            // 
            // deployRequestToolStripMenuItem
            // 
            this.deployRequestToolStripMenuItem.Name = "deployRequestToolStripMenuItem";
            this.deployRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deployRequestToolStripMenuItem.Text = "Deploy Request";
            this.deployRequestToolStripMenuItem.Click += new System.EventHandler(this.DeployRequestToolStripMenuItem_Click);
            // 
            // gentranGenericListToolStripMenuItem
            // 
            this.gentranGenericListToolStripMenuItem.Name = "gentranGenericListToolStripMenuItem";
            this.gentranGenericListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gentranGenericListToolStripMenuItem.Text = "Gentran Generic List";
            this.gentranGenericListToolStripMenuItem.Click += new System.EventHandler(this.GentranGenericListToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem3});
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // aboutToolStripMenuItem3
            // 
            this.aboutToolStripMenuItem3.Name = "aboutToolStripMenuItem3";
            this.aboutToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem3.Text = "About";
            this.aboutToolStripMenuItem3.Click += new System.EventHandler(this.AboutToolStripMenuItem3_Click);
            // 
            // sIToolStripMenuItem1
            // 
            this.sIToolStripMenuItem1.Name = "sIToolStripMenuItem1";
            this.sIToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.sIToolStripMenuItem1.Text = "SI";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItem_Click);
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
            // 
            // eDIDirsToolStripMenuItem
            // 
            this.eDIDirsToolStripMenuItem.Name = "eDIDirsToolStripMenuItem";
            this.eDIDirsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eDIDirsToolStripMenuItem.Text = "EDI Dirs";
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sIToolStripMenuItem1,
            this.lightwellToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // lightwellToolStripMenuItem
            // 
            this.lightwellToolStripMenuItem.Name = "lightwellToolStripMenuItem";
            this.lightwellToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.lightwellToolStripMenuItem.Text = "Lightwell";
            // 
            // sIToolStripMenuItem
            // 
            this.sIToolStripMenuItem.Name = "sIToolStripMenuItem";
            this.sIToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sIToolStripMenuItem.Text = "SI";
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
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
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
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ver.Location = new System.Drawing.Point(15, 639);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(54, 18);
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
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox6.Location = new System.Drawing.Point(9, 457);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(823, 174);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Event Viewer";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Azure;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1000;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(0, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(823, 155);
            this.listBox1.TabIndex = 36;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
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
            // latest_ver
            // 
            this.latest_ver.BackColor = System.Drawing.SystemColors.MenuBar;
            this.latest_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latest_ver.Location = new System.Drawing.Point(98, 639);
            this.latest_ver.Name = "latest_ver";
            this.latest_ver.Size = new System.Drawing.Size(299, 18);
            this.latest_ver.TabIndex = 33;
            this.latest_ver.Text = "version";
            this.latest_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanerDownloadsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // cleanerDownloadsToolStripMenuItem
            // 
            this.cleanerDownloadsToolStripMenuItem.Name = "cleanerDownloadsToolStripMenuItem";
            this.cleanerDownloadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cleanerDownloadsToolStripMenuItem.Text = "cleanerDownloads";
            this.cleanerDownloadsToolStripMenuItem.Click += new System.EventHandler(this.cleanerDownloadsToolStripMenuItem_Click);
            // 
            // MyEDI
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.latest_ver);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ver);
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
            this.MaximumSize = new System.Drawing.Size(860, 700);
            this.MinimumSize = new System.Drawing.Size(860, 700);
            this.Name = "MyEDI";
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
            this.groupBox5.PerformLayout();
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
		private System.Windows.Forms.Label ver;
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
		private System.Windows.Forms.Button buttonGoLDAP;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxLDAP;
		private System.Windows.Forms.CheckBox checkBoxLDAP;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem dirsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sIToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem lWToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem3;
		public System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ToolStripMenuItem createDirResourcesToolStripMenuItem;
		private System.Windows.Forms.Label latest_ver;
		private System.Windows.Forms.ToolStripMenuItem cleanEventViewerToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBoxSRQ;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fTPProcedureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multipleEntriesCLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deployRequestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gentranGenericListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sIToolStripMenuItem2;
		private System.Windows.Forms.ComboBox comboBoxPass;
		private System.Windows.Forms.Button buttonMoreSettings;
		private System.Windows.Forms.CheckBox checkBoxPass24;
		private System.Windows.Forms.CheckBox checkBoxPass16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkBoxPass8;
		private System.Windows.Forms.CheckBox checkBoxLDAPno;
        private System.Windows.Forms.ComboBox comboBox_setup;
        private System.Windows.Forms.CheckBox checkBox_other;
        private System.Windows.Forms.CheckBox checkBox_cl;
        private System.Windows.Forms.CheckBox checkBox_setup;
        private System.Windows.Forms.CheckBox checkBox_cl_both;
        private System.Windows.Forms.CheckBox checkBox_cl_out;
        private System.Windows.Forms.CheckBox checkBox_cl_in;
        private System.Windows.Forms.CheckBox checkBox_maps;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanerDownloadsToolStripMenuItem;
    }
}