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
			this.credentialsGroupBox = new System.Windows.Forms.GroupBox();
			this.domainTextBox = new System.Windows.Forms.TextBox();
			this.domainLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.fetchLocalDomainButton = new System.Windows.Forms.Button();
			this.credentialsGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.usersListView.Location = new System.Drawing.Point(9, 48);
			this.usersListView.Name = "usersListView";
			this.usersListView.Size = new System.Drawing.Size(466, 230);
			this.usersListView.TabIndex = 0;
			this.usersListView.UseCompatibleStateImageBehavior = false;
			this.usersListView.View = System.Windows.Forms.View.Details;
			// 
			// columnID
			// 
			this.columnID.Text = "ID";
			// 
			// columnMailAddress
			// 
			this.columnMailAddress.Text = "Mail Address";
			this.columnMailAddress.Width = 264;
			// 
			// columnPassword
			// 
			this.columnPassword.Text = "Password";
			this.columnPassword.Width = 119;
			// 
			// credentialsGroupBox
			// 
			this.credentialsGroupBox.Controls.Add(this.fetchLocalDomainButton);
			this.credentialsGroupBox.Controls.Add(this.domainTextBox);
			this.credentialsGroupBox.Controls.Add(this.domainLabel);
			this.credentialsGroupBox.Controls.Add(this.passwordTextBox);
			this.credentialsGroupBox.Controls.Add(this.usernameTextBox);
			this.credentialsGroupBox.Controls.Add(this.passwordLabel);
			this.credentialsGroupBox.Controls.Add(this.usernameLabel);
			this.credentialsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.credentialsGroupBox.Name = "credentialsGroupBox";
			this.credentialsGroupBox.Size = new System.Drawing.Size(519, 127);
			this.credentialsGroupBox.TabIndex = 1;
			this.credentialsGroupBox.TabStop = false;
			this.credentialsGroupBox.Text = "Credentials";
			// 
			// domainTextBox
			// 
			this.domainTextBox.Location = new System.Drawing.Point(73, 83);
			this.domainTextBox.Name = "domainTextBox";
			this.domainTextBox.Size = new System.Drawing.Size(186, 20);
			this.domainTextBox.TabIndex = 5;
			// 
			// domainLabel
			// 
			this.domainLabel.AutoSize = true;
			this.domainLabel.Location = new System.Drawing.Point(6, 86);
			this.domainLabel.Name = "domainLabel";
			this.domainLabel.Size = new System.Drawing.Size(49, 13);
			this.domainLabel.TabIndex = 4;
			this.domainLabel.Text = "Domain: ";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(73, 57);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(186, 20);
			this.passwordTextBox.TabIndex = 3;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(73, 29);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(186, 20);
			this.usernameTextBox.TabIndex = 2;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(6, 60);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(59, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password: ";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(6, 32);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(61, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "Username: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.searchButton);
			this.groupBox1.Controls.Add(this.usersListView);
			this.groupBox1.Location = new System.Drawing.Point(12, 154);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(519, 284);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search users";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(9, 19);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// fetchLocalDomainButton
			// 
			this.fetchLocalDomainButton.Location = new System.Drawing.Point(265, 80);
			this.fetchLocalDomainButton.Name = "fetchLocalDomainButton";
			this.fetchLocalDomainButton.Size = new System.Drawing.Size(113, 23);
			this.fetchLocalDomainButton.TabIndex = 6;
			this.fetchLocalDomainButton.Text = "Fetch local domain";
			this.fetchLocalDomainButton.UseVisualStyleBackColor = true;
			this.fetchLocalDomainButton.Click += new System.EventHandler(this.fetchLocalDomainButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.credentialsGroupBox);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.credentialsGroupBox.ResumeLayout(false);
			this.credentialsGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView usersListView;
		private System.Windows.Forms.ColumnHeader columnID;
		private System.Windows.Forms.ColumnHeader columnMailAddress;
		private System.Windows.Forms.ColumnHeader columnPassword;
		private System.Windows.Forms.GroupBox credentialsGroupBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox domainTextBox;
		private System.Windows.Forms.Label domainLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button fetchLocalDomainButton;
	}
}