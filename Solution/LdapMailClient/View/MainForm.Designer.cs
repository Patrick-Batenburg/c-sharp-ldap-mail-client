namespace LdapMailClient.View
{
	partial class MainForm
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
			this.usersListView = new System.Windows.Forms.ListView();
			this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnMailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.connectionGroupBox = new System.Windows.Forms.GroupBox();
			this.ldapUsernameTextBox = new System.Windows.Forms.TextBox();
			this.ldapUsernameLabel = new System.Windows.Forms.Label();
			this.ldapTlsCheckBox = new System.Windows.Forms.CheckBox();
			this.ldapPasswordTextBox = new System.Windows.Forms.TextBox();
			this.ldapPasswordLabel = new System.Windows.Forms.Label();
			this.ldapAuthenticationLabel = new System.Windows.Forms.Label();
			this.ldapSslCheckBox = new System.Windows.Forms.CheckBox();
			this.ldapBaseLabel = new System.Windows.Forms.Label();
			this.ldapHostTextBox = new System.Windows.Forms.TextBox();
			this.ldapBaseTextBox = new System.Windows.Forms.TextBox();
			this.ldapHostLabel = new System.Windows.Forms.Label();
			this.searchGroupBox = new System.Windows.Forms.GroupBox();
			this.searchForUsersButton = new System.Windows.Forms.Button();
			this.latestMailsGroupBox = new System.Windows.Forms.GroupBox();
			this.latestMailsTextBox = new System.Windows.Forms.TextBox();
			this.searchForMailsButton = new System.Windows.Forms.Button();
			this.imapHostLlabel = new System.Windows.Forms.Label();
			this.imapTlsCheckBox = new System.Windows.Forms.CheckBox();
			this.imapHostTextBox = new System.Windows.Forms.TextBox();
			this.imapPortTextBox = new System.Windows.Forms.TextBox();
			this.imapPortLabel = new System.Windows.Forms.Label();
			this.imapAuthenticationLabel = new System.Windows.Forms.Label();
			this.imapSslCheckBox = new System.Windows.Forms.CheckBox();
			this.SendMailGroupBox = new System.Windows.Forms.GroupBox();
			this.smtpUsernameTextBox = new System.Windows.Forms.TextBox();
			this.smtpIdTextBox = new System.Windows.Forms.TextBox();
			this.smtpUsernameLabel = new System.Windows.Forms.Label();
			this.smtpIdLabel = new System.Windows.Forms.Label();
			this.smtpPasswordTextBox = new System.Windows.Forms.TextBox();
			this.smtpPasswordLabel = new System.Windows.Forms.Label();
			this.smtpMessageBodyLabel = new System.Windows.Forms.Label();
			this.smtpToTextBox = new System.Windows.Forms.TextBox();
			this.smtpToLabel = new System.Windows.Forms.Label();
			this.smtpSubjectLabel = new System.Windows.Forms.Label();
			this.smtpSubjectTextBox = new System.Windows.Forms.TextBox();
			this.smtpMessageBodyTextBox = new System.Windows.Forms.TextBox();
			this.smtpTlsCheckBox = new System.Windows.Forms.CheckBox();
			this.smtpPortTextBox = new System.Windows.Forms.TextBox();
			this.smtpAuthenticationLabel = new System.Windows.Forms.Label();
			this.smtpSslCheckBox = new System.Windows.Forms.CheckBox();
			this.smtpPortLabel = new System.Windows.Forms.Label();
			this.smtpHostTextBox = new System.Windows.Forms.TextBox();
			this.smtpHostLabel = new System.Windows.Forms.Label();
			this.sendMailButton = new System.Windows.Forms.Button();
			this.connectionGroupBox.SuspendLayout();
			this.searchGroupBox.SuspendLayout();
			this.latestMailsGroupBox.SuspendLayout();
			this.SendMailGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// usersListView
			// 
			this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnMailAddress,
            this.columnPassword});
			this.usersListView.FullRowSelect = true;
			this.usersListView.GridLines = true;
			this.usersListView.Location = new System.Drawing.Point(6, 48);
			this.usersListView.MultiSelect = false;
			this.usersListView.Name = "usersListView";
			this.usersListView.Size = new System.Drawing.Size(414, 165);
			this.usersListView.TabIndex = 0;
			this.usersListView.UseCompatibleStateImageBehavior = false;
			this.usersListView.View = System.Windows.Forms.View.Details;
			this.usersListView.SelectedIndexChanged += new System.EventHandler(this.UsersListView_SelectedIndexChanged);
			// 
			// columnID
			// 
			this.columnID.Text = "ID";
			this.columnID.Width = 33;
			// 
			// columnMailAddress
			// 
			this.columnMailAddress.Text = "Mail Address";
			this.columnMailAddress.Width = 276;
			// 
			// columnPassword
			// 
			this.columnPassword.Text = "Password";
			this.columnPassword.Width = 96;
			// 
			// connectionGroupBox
			// 
			this.connectionGroupBox.Controls.Add(this.ldapUsernameTextBox);
			this.connectionGroupBox.Controls.Add(this.ldapUsernameLabel);
			this.connectionGroupBox.Controls.Add(this.ldapTlsCheckBox);
			this.connectionGroupBox.Controls.Add(this.ldapPasswordTextBox);
			this.connectionGroupBox.Controls.Add(this.ldapPasswordLabel);
			this.connectionGroupBox.Controls.Add(this.ldapAuthenticationLabel);
			this.connectionGroupBox.Controls.Add(this.ldapSslCheckBox);
			this.connectionGroupBox.Controls.Add(this.ldapBaseLabel);
			this.connectionGroupBox.Controls.Add(this.ldapHostTextBox);
			this.connectionGroupBox.Controls.Add(this.ldapBaseTextBox);
			this.connectionGroupBox.Controls.Add(this.ldapHostLabel);
			this.connectionGroupBox.Location = new System.Drawing.Point(12, 12);
			this.connectionGroupBox.Name = "connectionGroupBox";
			this.connectionGroupBox.Size = new System.Drawing.Size(426, 219);
			this.connectionGroupBox.TabIndex = 1;
			this.connectionGroupBox.TabStop = false;
			this.connectionGroupBox.Text = "Connection";
			// 
			// ldapUsernameTextBox
			// 
			this.ldapUsernameTextBox.Location = new System.Drawing.Point(71, 75);
			this.ldapUsernameTextBox.Name = "ldapUsernameTextBox";
			this.ldapUsernameTextBox.Size = new System.Drawing.Size(207, 20);
			this.ldapUsernameTextBox.TabIndex = 10;
			// 
			// ldapUsernameLabel
			// 
			this.ldapUsernameLabel.AutoSize = true;
			this.ldapUsernameLabel.Location = new System.Drawing.Point(6, 78);
			this.ldapUsernameLabel.Name = "ldapUsernameLabel";
			this.ldapUsernameLabel.Size = new System.Drawing.Size(61, 13);
			this.ldapUsernameLabel.TabIndex = 9;
			this.ldapUsernameLabel.Text = "Username: ";
			// 
			// ldapTlsCheckBox
			// 
			this.ldapTlsCheckBox.AutoSize = true;
			this.ldapTlsCheckBox.Location = new System.Drawing.Point(150, 127);
			this.ldapTlsCheckBox.Name = "ldapTlsCheckBox";
			this.ldapTlsCheckBox.Size = new System.Drawing.Size(46, 17);
			this.ldapTlsCheckBox.TabIndex = 8;
			this.ldapTlsCheckBox.Text = "TLS";
			this.ldapTlsCheckBox.UseVisualStyleBackColor = true;
			this.ldapTlsCheckBox.Click += new System.EventHandler(this.LdapTlsCheckBox_Click);
			// 
			// ldapPasswordTextBox
			// 
			this.ldapPasswordTextBox.Location = new System.Drawing.Point(71, 101);
			this.ldapPasswordTextBox.Name = "ldapPasswordTextBox";
			this.ldapPasswordTextBox.Size = new System.Drawing.Size(207, 20);
			this.ldapPasswordTextBox.TabIndex = 5;
			// 
			// ldapPasswordLabel
			// 
			this.ldapPasswordLabel.AutoSize = true;
			this.ldapPasswordLabel.Location = new System.Drawing.Point(6, 104);
			this.ldapPasswordLabel.Name = "ldapPasswordLabel";
			this.ldapPasswordLabel.Size = new System.Drawing.Size(59, 13);
			this.ldapPasswordLabel.TabIndex = 1;
			this.ldapPasswordLabel.Text = "Password: ";
			// 
			// ldapAuthenticationLabel
			// 
			this.ldapAuthenticationLabel.AutoSize = true;
			this.ldapAuthenticationLabel.Location = new System.Drawing.Point(6, 128);
			this.ldapAuthenticationLabel.Name = "ldapAuthenticationLabel";
			this.ldapAuthenticationLabel.Size = new System.Drawing.Size(81, 13);
			this.ldapAuthenticationLabel.TabIndex = 7;
			this.ldapAuthenticationLabel.Text = "Authentication: ";
			// 
			// ldapSslCheckBox
			// 
			this.ldapSslCheckBox.AutoSize = true;
			this.ldapSslCheckBox.Location = new System.Drawing.Point(93, 127);
			this.ldapSslCheckBox.Name = "ldapSslCheckBox";
			this.ldapSslCheckBox.Size = new System.Drawing.Size(46, 17);
			this.ldapSslCheckBox.TabIndex = 7;
			this.ldapSslCheckBox.Text = "SSL";
			this.ldapSslCheckBox.UseVisualStyleBackColor = true;
			this.ldapSslCheckBox.Click += new System.EventHandler(this.LdapSslCheckBox_Click);
			// 
			// ldapBaseLabel
			// 
			this.ldapBaseLabel.AutoSize = true;
			this.ldapBaseLabel.Location = new System.Drawing.Point(6, 52);
			this.ldapBaseLabel.Name = "ldapBaseLabel";
			this.ldapBaseLabel.Size = new System.Drawing.Size(37, 13);
			this.ldapBaseLabel.TabIndex = 0;
			this.ldapBaseLabel.Text = "Base: ";
			// 
			// ldapHostTextBox
			// 
			this.ldapHostTextBox.Location = new System.Drawing.Point(71, 23);
			this.ldapHostTextBox.Name = "ldapHostTextBox";
			this.ldapHostTextBox.Size = new System.Drawing.Size(207, 20);
			this.ldapHostTextBox.TabIndex = 2;
			// 
			// ldapBaseTextBox
			// 
			this.ldapBaseTextBox.Location = new System.Drawing.Point(71, 49);
			this.ldapBaseTextBox.Name = "ldapBaseTextBox";
			this.ldapBaseTextBox.Size = new System.Drawing.Size(207, 20);
			this.ldapBaseTextBox.TabIndex = 3;
			// 
			// ldapHostLabel
			// 
			this.ldapHostLabel.AutoSize = true;
			this.ldapHostLabel.Location = new System.Drawing.Point(6, 26);
			this.ldapHostLabel.Name = "ldapHostLabel";
			this.ldapHostLabel.Size = new System.Drawing.Size(35, 13);
			this.ldapHostLabel.TabIndex = 4;
			this.ldapHostLabel.Text = "Host: ";
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Controls.Add(this.searchForUsersButton);
			this.searchGroupBox.Controls.Add(this.usersListView);
			this.searchGroupBox.Location = new System.Drawing.Point(444, 12);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(426, 219);
			this.searchGroupBox.TabIndex = 6;
			this.searchGroupBox.TabStop = false;
			this.searchGroupBox.Text = "Search Users";
			// 
			// searchForUsersButton
			// 
			this.searchForUsersButton.Location = new System.Drawing.Point(6, 19);
			this.searchForUsersButton.Name = "searchForUsersButton";
			this.searchForUsersButton.Size = new System.Drawing.Size(75, 23);
			this.searchForUsersButton.TabIndex = 1;
			this.searchForUsersButton.Text = "Search";
			this.searchForUsersButton.UseVisualStyleBackColor = true;
			this.searchForUsersButton.Click += new System.EventHandler(this.SearchForUsersButton_Click);
			// 
			// latestMailsGroupBox
			// 
			this.latestMailsGroupBox.Controls.Add(this.latestMailsTextBox);
			this.latestMailsGroupBox.Controls.Add(this.searchForMailsButton);
			this.latestMailsGroupBox.Controls.Add(this.imapHostLlabel);
			this.latestMailsGroupBox.Controls.Add(this.imapTlsCheckBox);
			this.latestMailsGroupBox.Controls.Add(this.imapHostTextBox);
			this.latestMailsGroupBox.Controls.Add(this.imapPortTextBox);
			this.latestMailsGroupBox.Controls.Add(this.imapPortLabel);
			this.latestMailsGroupBox.Controls.Add(this.imapAuthenticationLabel);
			this.latestMailsGroupBox.Controls.Add(this.imapSslCheckBox);
			this.latestMailsGroupBox.Location = new System.Drawing.Point(12, 237);
			this.latestMailsGroupBox.Name = "latestMailsGroupBox";
			this.latestMailsGroupBox.Size = new System.Drawing.Size(426, 352);
			this.latestMailsGroupBox.TabIndex = 7;
			this.latestMailsGroupBox.TabStop = false;
			this.latestMailsGroupBox.Text = "Latest Mails";
			// 
			// latestMailsTextBox
			// 
			this.latestMailsTextBox.Location = new System.Drawing.Point(6, 105);
			this.latestMailsTextBox.Multiline = true;
			this.latestMailsTextBox.Name = "latestMailsTextBox";
			this.latestMailsTextBox.ReadOnly = true;
			this.latestMailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.latestMailsTextBox.Size = new System.Drawing.Size(414, 241);
			this.latestMailsTextBox.TabIndex = 14;
			// 
			// searchForMailsButton
			// 
			this.searchForMailsButton.Enabled = false;
			this.searchForMailsButton.Location = new System.Drawing.Point(9, 76);
			this.searchForMailsButton.Name = "searchForMailsButton";
			this.searchForMailsButton.Size = new System.Drawing.Size(102, 23);
			this.searchForMailsButton.TabIndex = 2;
			this.searchForMailsButton.Text = "Show latest mails";
			this.searchForMailsButton.UseVisualStyleBackColor = true;
			this.searchForMailsButton.Click += new System.EventHandler(this.SearchForMailsButton_Click);
			// 
			// imapHostLlabel
			// 
			this.imapHostLlabel.AutoSize = true;
			this.imapHostLlabel.Location = new System.Drawing.Point(6, 24);
			this.imapHostLlabel.Name = "imapHostLlabel";
			this.imapHostLlabel.Size = new System.Drawing.Size(35, 13);
			this.imapHostLlabel.TabIndex = 23;
			this.imapHostLlabel.Text = "Host: ";
			// 
			// imapTlsCheckBox
			// 
			this.imapTlsCheckBox.AutoSize = true;
			this.imapTlsCheckBox.Location = new System.Drawing.Point(150, 47);
			this.imapTlsCheckBox.Name = "imapTlsCheckBox";
			this.imapTlsCheckBox.Size = new System.Drawing.Size(46, 17);
			this.imapTlsCheckBox.TabIndex = 31;
			this.imapTlsCheckBox.Text = "TLS";
			this.imapTlsCheckBox.UseVisualStyleBackColor = true;
			// 
			// imapHostTextBox
			// 
			this.imapHostTextBox.Location = new System.Drawing.Point(71, 21);
			this.imapHostTextBox.Name = "imapHostTextBox";
			this.imapHostTextBox.Size = new System.Drawing.Size(207, 20);
			this.imapHostTextBox.TabIndex = 22;
			// 
			// imapPortTextBox
			// 
			this.imapPortTextBox.Location = new System.Drawing.Point(335, 21);
			this.imapPortTextBox.Name = "imapPortTextBox";
			this.imapPortTextBox.Size = new System.Drawing.Size(51, 20);
			this.imapPortTextBox.TabIndex = 24;
			// 
			// imapPortLabel
			// 
			this.imapPortLabel.AutoSize = true;
			this.imapPortLabel.Location = new System.Drawing.Point(297, 24);
			this.imapPortLabel.Name = "imapPortLabel";
			this.imapPortLabel.Size = new System.Drawing.Size(32, 13);
			this.imapPortLabel.TabIndex = 25;
			this.imapPortLabel.Text = "Port: ";
			// 
			// imapAuthenticationLabel
			// 
			this.imapAuthenticationLabel.AutoSize = true;
			this.imapAuthenticationLabel.Location = new System.Drawing.Point(6, 48);
			this.imapAuthenticationLabel.Name = "imapAuthenticationLabel";
			this.imapAuthenticationLabel.Size = new System.Drawing.Size(81, 13);
			this.imapAuthenticationLabel.TabIndex = 27;
			this.imapAuthenticationLabel.Text = "Authentication: ";
			// 
			// imapSslCheckBox
			// 
			this.imapSslCheckBox.AutoSize = true;
			this.imapSslCheckBox.Location = new System.Drawing.Point(93, 47);
			this.imapSslCheckBox.Name = "imapSslCheckBox";
			this.imapSslCheckBox.Size = new System.Drawing.Size(46, 17);
			this.imapSslCheckBox.TabIndex = 29;
			this.imapSslCheckBox.Text = "SSL";
			this.imapSslCheckBox.UseVisualStyleBackColor = true;
			// 
			// SendMailGroupBox
			// 
			this.SendMailGroupBox.Controls.Add(this.smtpUsernameTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpIdTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpUsernameLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpIdLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpPasswordTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpPasswordLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpMessageBodyLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpToTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpToLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpSubjectLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpSubjectTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpMessageBodyTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpTlsCheckBox);
			this.SendMailGroupBox.Controls.Add(this.smtpPortTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpAuthenticationLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpSslCheckBox);
			this.SendMailGroupBox.Controls.Add(this.smtpPortLabel);
			this.SendMailGroupBox.Controls.Add(this.smtpHostTextBox);
			this.SendMailGroupBox.Controls.Add(this.smtpHostLabel);
			this.SendMailGroupBox.Controls.Add(this.sendMailButton);
			this.SendMailGroupBox.Location = new System.Drawing.Point(444, 237);
			this.SendMailGroupBox.Name = "SendMailGroupBox";
			this.SendMailGroupBox.Size = new System.Drawing.Size(426, 352);
			this.SendMailGroupBox.TabIndex = 15;
			this.SendMailGroupBox.TabStop = false;
			this.SendMailGroupBox.Text = "Send Mail";
			// 
			// smtpUsernameTextBox
			// 
			this.smtpUsernameTextBox.Location = new System.Drawing.Point(73, 48);
			this.smtpUsernameTextBox.Name = "smtpUsernameTextBox";
			this.smtpUsernameTextBox.Size = new System.Drawing.Size(207, 20);
			this.smtpUsernameTextBox.TabIndex = 14;
			// 
			// smtpIdTextBox
			// 
			this.smtpIdTextBox.Location = new System.Drawing.Point(369, 166);
			this.smtpIdTextBox.Name = "smtpIdTextBox";
			this.smtpIdTextBox.ReadOnly = true;
			this.smtpIdTextBox.Size = new System.Drawing.Size(51, 20);
			this.smtpIdTextBox.TabIndex = 21;
			// 
			// smtpUsernameLabel
			// 
			this.smtpUsernameLabel.AutoSize = true;
			this.smtpUsernameLabel.Location = new System.Drawing.Point(6, 51);
			this.smtpUsernameLabel.Name = "smtpUsernameLabel";
			this.smtpUsernameLabel.Size = new System.Drawing.Size(61, 13);
			this.smtpUsernameLabel.TabIndex = 13;
			this.smtpUsernameLabel.Text = "Username: ";
			// 
			// smtpIdLabel
			// 
			this.smtpIdLabel.AutoSize = true;
			this.smtpIdLabel.Location = new System.Drawing.Point(339, 169);
			this.smtpIdLabel.Name = "smtpIdLabel";
			this.smtpIdLabel.Size = new System.Drawing.Size(24, 13);
			this.smtpIdLabel.TabIndex = 20;
			this.smtpIdLabel.Text = "ID: ";
			// 
			// smtpPasswordTextBox
			// 
			this.smtpPasswordTextBox.Location = new System.Drawing.Point(73, 74);
			this.smtpPasswordTextBox.Name = "smtpPasswordTextBox";
			this.smtpPasswordTextBox.Size = new System.Drawing.Size(207, 20);
			this.smtpPasswordTextBox.TabIndex = 12;
			// 
			// smtpPasswordLabel
			// 
			this.smtpPasswordLabel.AutoSize = true;
			this.smtpPasswordLabel.Location = new System.Drawing.Point(6, 76);
			this.smtpPasswordLabel.Name = "smtpPasswordLabel";
			this.smtpPasswordLabel.Size = new System.Drawing.Size(59, 13);
			this.smtpPasswordLabel.TabIndex = 11;
			this.smtpPasswordLabel.Text = "Password: ";
			// 
			// smtpMessageBodyLabel
			// 
			this.smtpMessageBodyLabel.AutoSize = true;
			this.smtpMessageBodyLabel.Location = new System.Drawing.Point(6, 189);
			this.smtpMessageBodyLabel.Name = "smtpMessageBodyLabel";
			this.smtpMessageBodyLabel.Size = new System.Drawing.Size(56, 13);
			this.smtpMessageBodyLabel.TabIndex = 19;
			this.smtpMessageBodyLabel.Text = "Message: ";
			// 
			// smtpToTextBox
			// 
			this.smtpToTextBox.Location = new System.Drawing.Point(73, 166);
			this.smtpToTextBox.Name = "smtpToTextBox";
			this.smtpToTextBox.ReadOnly = true;
			this.smtpToTextBox.Size = new System.Drawing.Size(260, 20);
			this.smtpToTextBox.TabIndex = 18;
			// 
			// smtpToLabel
			// 
			this.smtpToLabel.AutoSize = true;
			this.smtpToLabel.Location = new System.Drawing.Point(6, 169);
			this.smtpToLabel.Name = "smtpToLabel";
			this.smtpToLabel.Size = new System.Drawing.Size(26, 13);
			this.smtpToLabel.TabIndex = 17;
			this.smtpToLabel.Text = "To: ";
			// 
			// smtpSubjectLabel
			// 
			this.smtpSubjectLabel.AutoSize = true;
			this.smtpSubjectLabel.Location = new System.Drawing.Point(6, 143);
			this.smtpSubjectLabel.Name = "smtpSubjectLabel";
			this.smtpSubjectLabel.Size = new System.Drawing.Size(49, 13);
			this.smtpSubjectLabel.TabIndex = 16;
			this.smtpSubjectLabel.Text = "Subject: ";
			// 
			// smtpSubjectTextBox
			// 
			this.smtpSubjectTextBox.Location = new System.Drawing.Point(73, 140);
			this.smtpSubjectTextBox.Name = "smtpSubjectTextBox";
			this.smtpSubjectTextBox.Size = new System.Drawing.Size(260, 20);
			this.smtpSubjectTextBox.TabIndex = 15;
			// 
			// smtpMessageBodyTextBox
			// 
			this.smtpMessageBodyTextBox.Location = new System.Drawing.Point(6, 205);
			this.smtpMessageBodyTextBox.Multiline = true;
			this.smtpMessageBodyTextBox.Name = "smtpMessageBodyTextBox";
			this.smtpMessageBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.smtpMessageBodyTextBox.Size = new System.Drawing.Size(414, 112);
			this.smtpMessageBodyTextBox.TabIndex = 14;
			// 
			// smtpTlsCheckBox
			// 
			this.smtpTlsCheckBox.AutoSize = true;
			this.smtpTlsCheckBox.Location = new System.Drawing.Point(150, 100);
			this.smtpTlsCheckBox.Name = "smtpTlsCheckBox";
			this.smtpTlsCheckBox.Size = new System.Drawing.Size(46, 17);
			this.smtpTlsCheckBox.TabIndex = 13;
			this.smtpTlsCheckBox.Text = "TLS";
			this.smtpTlsCheckBox.UseVisualStyleBackColor = true;
			this.smtpTlsCheckBox.CheckedChanged += new System.EventHandler(this.SmtpTlsCheckBox_CheckedChanged);
			// 
			// smtpPortTextBox
			// 
			this.smtpPortTextBox.Location = new System.Drawing.Point(335, 21);
			this.smtpPortTextBox.Name = "smtpPortTextBox";
			this.smtpPortTextBox.Size = new System.Drawing.Size(51, 20);
			this.smtpPortTextBox.TabIndex = 7;
			// 
			// smtpAuthenticationLabel
			// 
			this.smtpAuthenticationLabel.AutoSize = true;
			this.smtpAuthenticationLabel.Location = new System.Drawing.Point(6, 101);
			this.smtpAuthenticationLabel.Name = "smtpAuthenticationLabel";
			this.smtpAuthenticationLabel.Size = new System.Drawing.Size(81, 13);
			this.smtpAuthenticationLabel.TabIndex = 11;
			this.smtpAuthenticationLabel.Text = "Authentication: ";
			// 
			// smtpSslCheckBox
			// 
			this.smtpSslCheckBox.AutoSize = true;
			this.smtpSslCheckBox.Location = new System.Drawing.Point(93, 100);
			this.smtpSslCheckBox.Name = "smtpSslCheckBox";
			this.smtpSslCheckBox.Size = new System.Drawing.Size(46, 17);
			this.smtpSslCheckBox.TabIndex = 12;
			this.smtpSslCheckBox.Text = "SSL";
			this.smtpSslCheckBox.UseVisualStyleBackColor = true;
			this.smtpSslCheckBox.CheckedChanged += new System.EventHandler(this.SmtpSslCheckBox_CheckedChanged);
			// 
			// smtpPortLabel
			// 
			this.smtpPortLabel.AutoSize = true;
			this.smtpPortLabel.Location = new System.Drawing.Point(297, 24);
			this.smtpPortLabel.Name = "smtpPortLabel";
			this.smtpPortLabel.Size = new System.Drawing.Size(32, 13);
			this.smtpPortLabel.TabIndex = 8;
			this.smtpPortLabel.Text = "Port: ";
			// 
			// smtpHostTextBox
			// 
			this.smtpHostTextBox.Location = new System.Drawing.Point(73, 21);
			this.smtpHostTextBox.Name = "smtpHostTextBox";
			this.smtpHostTextBox.Size = new System.Drawing.Size(207, 20);
			this.smtpHostTextBox.TabIndex = 5;
			// 
			// smtpHostLabel
			// 
			this.smtpHostLabel.AutoSize = true;
			this.smtpHostLabel.Location = new System.Drawing.Point(6, 24);
			this.smtpHostLabel.Name = "smtpHostLabel";
			this.smtpHostLabel.Size = new System.Drawing.Size(35, 13);
			this.smtpHostLabel.TabIndex = 6;
			this.smtpHostLabel.Text = "Host: ";
			// 
			// sendMailButton
			// 
			this.sendMailButton.Enabled = false;
			this.sendMailButton.Location = new System.Drawing.Point(6, 323);
			this.sendMailButton.Name = "sendMailButton";
			this.sendMailButton.Size = new System.Drawing.Size(102, 23);
			this.sendMailButton.TabIndex = 2;
			this.sendMailButton.Text = "Send";
			this.sendMailButton.UseVisualStyleBackColor = true;
			this.sendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 602);
			this.Controls.Add(this.SendMailGroupBox);
			this.Controls.Add(this.latestMailsGroupBox);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.connectionGroupBox);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.connectionGroupBox.ResumeLayout(false);
			this.connectionGroupBox.PerformLayout();
			this.searchGroupBox.ResumeLayout(false);
			this.latestMailsGroupBox.ResumeLayout(false);
			this.latestMailsGroupBox.PerformLayout();
			this.SendMailGroupBox.ResumeLayout(false);
			this.SendMailGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView usersListView;
		private System.Windows.Forms.ColumnHeader columnID;
		private System.Windows.Forms.ColumnHeader columnMailAddress;
		private System.Windows.Forms.ColumnHeader columnPassword;
		private System.Windows.Forms.GroupBox connectionGroupBox;
		private System.Windows.Forms.TextBox ldapHostTextBox;
		private System.Windows.Forms.Label ldapPasswordLabel;
		private System.Windows.Forms.Label ldapBaseLabel;
		private System.Windows.Forms.TextBox ldapPasswordTextBox;
		private System.Windows.Forms.Label ldapHostLabel;
		private System.Windows.Forms.TextBox ldapBaseTextBox;
		private System.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.Button searchForUsersButton;
		private System.Windows.Forms.CheckBox ldapSslCheckBox;
		private System.Windows.Forms.Label ldapAuthenticationLabel;
		private System.Windows.Forms.CheckBox ldapTlsCheckBox;
		private System.Windows.Forms.TextBox ldapUsernameTextBox;
		private System.Windows.Forms.Label ldapUsernameLabel;
		private System.Windows.Forms.GroupBox latestMailsGroupBox;
		private System.Windows.Forms.Button searchForMailsButton;
		private System.Windows.Forms.TextBox latestMailsTextBox;
		private System.Windows.Forms.GroupBox SendMailGroupBox;
		private System.Windows.Forms.TextBox smtpUsernameTextBox;
		private System.Windows.Forms.TextBox smtpIdTextBox;
		private System.Windows.Forms.Label smtpUsernameLabel;
		private System.Windows.Forms.Label smtpIdLabel;
		private System.Windows.Forms.TextBox smtpPasswordTextBox;
		private System.Windows.Forms.Label smtpPasswordLabel;
		private System.Windows.Forms.Label smtpMessageBodyLabel;
		private System.Windows.Forms.TextBox smtpToTextBox;
		private System.Windows.Forms.Label smtpToLabel;
		private System.Windows.Forms.Label smtpSubjectLabel;
		private System.Windows.Forms.TextBox smtpSubjectTextBox;
		private System.Windows.Forms.TextBox smtpMessageBodyTextBox;
		private System.Windows.Forms.CheckBox smtpTlsCheckBox;
		private System.Windows.Forms.TextBox smtpPortTextBox;
		private System.Windows.Forms.Label smtpAuthenticationLabel;
		private System.Windows.Forms.CheckBox smtpSslCheckBox;
		private System.Windows.Forms.Label smtpPortLabel;
		private System.Windows.Forms.TextBox smtpHostTextBox;
		private System.Windows.Forms.Label smtpHostLabel;
		private System.Windows.Forms.Button sendMailButton;
		private System.Windows.Forms.Label imapHostLlabel;
		private System.Windows.Forms.CheckBox imapTlsCheckBox;
		private System.Windows.Forms.TextBox imapHostTextBox;
		private System.Windows.Forms.TextBox imapPortTextBox;
		private System.Windows.Forms.Label imapPortLabel;
		private System.Windows.Forms.Label imapAuthenticationLabel;
		private System.Windows.Forms.CheckBox imapSslCheckBox;
	}
}