using LdapMailClient.Controller;
using LdapMailClient.Model;
using MailKit;
using MailKit.Net.Imap;
using MailKitSmtp = MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DirectoryServicesProtocols = System.DirectoryServices.Protocols;

namespace LdapMailClient.View
{
	public partial class MainForm : Form, IUsersView, IMailsView
	{
		private UsersController usersController;
		private MailsController mailsController;
		private DirectorySearcher directorySearcher;
		private string displayNameProperty;
		private string mailProperty;
		private string passwordProperty;
		private ICollection<User> users;
		private ICollection<Mail> mails;
		private bool recievedMailsWithErrors;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			displayNameProperty = "cn";
			mailProperty = "mail";
			passwordProperty = "userPassword";
			recievedMailsWithErrors = false;
			users = new List<User>();
			mails = new List<Mail>();
			usersController = new UsersController(this, users);
			mailsController = new MailsController(this, mails);
		}

		/// <summary>
		/// Sets the controller context.
		/// </summary>
		/// <param name="controller">The <see cref="MailsController"/> to set.</param>
		public void SetController(UsersController usersController)
		{
			this.usersController = usersController;
		}

		/// <summary>
		/// Adds a <see cref="User"/> object to the view.
		/// </summary>
		/// <param name="user">The <see cref="User"/> object to be added.</param>
		public void AddUserToGrid(User user)
		{
			ListViewItem item;
			item = this.usersListView.Items.Add(user.ID.ToString());
			item.SubItems.Add(user.MailAddress.ToString());
			item.SubItems.Add(user.Password);
		}

		/// <summary>
		/// Removes all <see cref="User"/> objects from the view.
		/// </summary>
		public void ClearGrid()
		{
			usersListView.Items.Clear();
			ClearMails();
		}

		/// <summary>
		/// Sets the selected <see cref="User"/> object.
		/// </summary>
		/// <param name="user">The <see cref="User"/> object to set.</param>
		public void SetSelectedUserInGrid(User user)
		{
			foreach (ListViewItem row in usersListView.Items)
			{
				if (row.Text == user.ID.ToString())
				{
					row.Selected = true;
				}
			}
		}

		/// <summary>
		/// Returns the <see cref="User.ID"/> property of the selected <see cref="User"/> object.
		/// </summary>
		/// <returns>The <see cref="User.ID"/> for the currently selected object.</returns>
		public int GetIdOfSelectedUserInGrid()
		{
			Int32.TryParse(usersListView.SelectedItems[0].Text, out int result);
			return result;
		}

		/// <summary>
		/// Sets the controller context.
		/// </summary>
		/// <param name="controller">The <see cref="MailsController"/> to set.</param>
		public void SetController(MailsController mailsController)
		{
			this.mailsController = mailsController;
		}

		/// <summary>
		/// Adds a <see cref="Mail"/> object to the view.
		/// </summary>
		/// <param name="mail">The <see cref="Mail"/> object to be added.</param>
		public void AddMail(Mail mail)
		{
			latestMailsTextBox.AppendText(String.Format("Message {0}, size={1}\r\n", mail.ID, mail.Size));
			latestMailsTextBox.AppendText(mail.ToString() + "\r\n\r\n");
		}

		/// <summary>
		/// Removes all <see cref="Mail"/> objects from the view.
		/// </summary>
		public void ClearMails()
		{
			latestMailsTextBox.Text = "";
		}

		/// <summary>
		/// Returns a <see cref="DirectorySearcher"/> object by using the specified host, base distinguished name, username and password.
		/// </summary>
		/// <param name="host">The name of the host.</param>
		/// <param name="_base">The base distinguished name.</param>
		/// <param name="username">The username to connect.</param>
		/// <param name="passowrd">The password to connect.</param>
		/// <returns></returns>
		private DirectorySearcher GetDirectorySearcher(string host, string _base, string username, string passowrd)
		{
			//return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://ldap.forumsys.com/dc=example,dc=com", "", "", AuthenticationTypes.None));

			if (ldapSslCheckBox.Checked)
			{
				return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://" + host + "/" + _base, username, passowrd, AuthenticationTypes.SecureSocketsLayer));
			}

			if (ldapTlsCheckBox.Checked)
			{
				//return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://" + host + "/" + _base, username, passowrd, AuthenticationTypes.));
				//throw new NotImplementedException();
				return null;
			}

			return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://" + host + "/" + _base, username, passowrd, AuthenticationTypes.None));
		}

		/// <summary>
		/// Returns a <see cref="SearchResultCollection"/> object consisting of users by using the specified <see cref="DirectorySearcher"/> object.
		/// </summary>
		/// <param name="directorySearcher"></param>
		/// <returns></returns>
		private SearchResultCollection SearchForUsers(DirectorySearcher directorySearcher)
		{
			if (directorySearcher == null)
			{
				return null;
			}

			directorySearcher.Filter = "(uid=*)";
			directorySearcher.SearchScope = SearchScope.Subtree;
			directorySearcher.PropertiesToLoad.Add(displayNameProperty);
			directorySearcher.PropertiesToLoad.Add(mailProperty);
			directorySearcher.PropertiesToLoad.Add(passwordProperty);
			SearchResultCollection results = null;
			MailAddress mailAddress;
			string password = "";
			users.Clear();

			try
			{
				results = directorySearcher.FindAll();

				for (int i = 0; i < results.Count; i++)
				{
					if (results[i].Properties.Contains(mailProperty))
					{
						if (results[i].Properties.Contains(displayNameProperty))
						{
							mailAddress = new MailAddress(results[i].Properties[mailProperty][0].ToString(), results[i].Properties[displayNameProperty][0].ToString());
						}
						else
						{
							mailAddress = new MailAddress(results[i].Properties[mailProperty][0].ToString());
						}

						if (results[i].Properties.Contains(passwordProperty))
						{
							password = results[i].Properties[passwordProperty][0].ToString();
						}

						if (mailAddress != null)
						{
							users.Add(new User(i, mailAddress, password));
							mailAddress = null;
							password = "";
						}
					}
				}

				usersController.LoadView();
				searchForMailsButton.Enabled = true;
				sendMailButton.Enabled = true;
			}
			catch (Exception ex) when (ex is DirectoryServicesCOMException || ex is COMException)
			{
				MessageBox.Show(ex.Message + "\nUnable to connect to server, please check the connection.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				searchForMailsButton.Enabled = false;
				sendMailButton.Enabled = false;
			}
			finally
			{
				directorySearcher.Dispose();
			}

			return results;
		}

		/// <summary>
		/// Searches for the latest 10 mails for all the elements within the entire <see cref="IEnumerable{T}"/>.
		/// </summary>
		/// <param name="users"></param>
		private void FindLatestMails(IEnumerable<User> users)
		{
			mails.Clear();

			foreach (User user in users)
			{
				GetMessages(user);
			}

			if (recievedMailsWithErrors)
			{
				MessageBox.Show("Unable to recieve one or more messages.", "Mail error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Gets the messages from the specified user.
		/// </summary>
		/// <param name="user">The <see cref="User"/> instance to retrive messages from.</param>
		private void GetMessages(User user)
		{
			try
			{
				using (ImapClient client = new ImapClient())
				{
					Mail mail;
					Int32.TryParse(imapPortTextBox.Text, out int port);
					client.ServerCertificateValidationCallback = (s, c, h, e) => true;

					if (imapSslCheckBox.Enabled)
					{
						client.Connect(imapHostTextBox.Text, port, true);
					}
					else if (imapTlsCheckBox.Enabled)
					{
						client.Connect(imapHostTextBox.Text, port, SecureSocketOptions.StartTlsWhenAvailable);
					}
					else
					{
						client.Connect(imapHostTextBox.Text, port, SecureSocketOptions.Auto);
					}

					client.Authenticate(user.MailAddress.Address, user.Password);
					IMailFolder inbox = client.Inbox;
					inbox.Open(FolderAccess.ReadOnly);

					for (int i = 0; i < 10; i++)
					{
						mail = new Mail(inbox.GetMessage(i))
						{
							Size = (uint)inbox.Fetch(0, -1, MessageSummaryItems.Size).ElementAt(i).Size
						};

						mails.Add(mail);
					}

					client.Disconnect(true);
				}

				mailsController.LoadView();
			}
			catch (Exception)
			{
				recievedMailsWithErrors = true;
			}
		}

		/// <summary>
		/// Occurs before a form is displayed for the first time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			ldapHostTextBox.Text = "ldap.forumsys.com";
			ldapBaseTextBox.Text = "dc=example,dc=com";
			usersListView.Columns[usersListView.Columns.Count - 1].Width = -2;
		}

		/// <summary>
		/// Occurs when the <see cref="ListView.SelectedIndexChanged"/> property has changed.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void UsersListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (usersListView.SelectedItems.Count == 0)
			{
				return;
			}

			int ID = GetIdOfSelectedUserInGrid();
			smtpToTextBox.Text = users.ElementAt(ID).MailAddress.ToString();
			smtpIdTextBox.Text = ID.ToString();
		}

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LdapSslCheckBox_Click(object sender, EventArgs e)
		{
			switch (ldapSslCheckBox.CheckState)
			{
				case CheckState.Checked:
					ldapTlsCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SearchForMailsButton_Click(object sender, EventArgs e)
		{
			if (users.Count < 9)
			{
				FindLatestMails(users.Take(users.Count));
			}
			else
			{
				FindLatestMails(users.Take(10));
			}
		}

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LdapTlsCheckBox_Click(object sender, EventArgs e)
		{
			switch (ldapTlsCheckBox.CheckState)
			{
				case CheckState.Checked:
					ldapSslCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SearchForUsersButton_Click(object sender, EventArgs e)
		{
			SearchForUsers(GetDirectorySearcher(ldapHostTextBox.Text, ldapBaseTextBox.Text, ldapUsernameTextBox.Text, ldapPasswordTextBox.Text));
		}

		/// <summary>
		/// Occurs when the value of the <see cref="CheckBox.Checked"/> property changes.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ImapSslCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			switch (imapSslCheckBox.CheckState)
			{
				case CheckState.Checked:
					imapTlsCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}

		/// <summary>
		/// Occurs when the value of the <see cref="CheckBox.Checked"/> property changes.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ImapTlsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			switch (imapTlsCheckBox.CheckState)
			{
				case CheckState.Checked:
					imapSslCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SendMailButton_Click(object sender, EventArgs e)
		{
			Int32.TryParse(imapPortTextBox.Text, out int port);
			MimeMessage message = new MimeMessage();
			message.From.Add(new MailboxAddress(smtpUsernameTextBox.Text));
			message.To.Add(new MailboxAddress(users.ElementAt(GetIdOfSelectedUserInGrid()).MailAddress.Address));
			message.Subject = smtpSubjectTextBox.Text;
			message.Body = new TextPart("plain")
			{
				Text = smtpMessageBodyTextBox.Text
			};

			try
			{
				using (MailKitSmtp.SmtpClient client = new MailKitSmtp.SmtpClient())
				{
					client.ServerCertificateValidationCallback = (s, c, h, err) => true;

					if (smtpSslCheckBox.Enabled)
					{
						client.Connect(smtpHostTextBox.Text, port, true);
					}
					else if (smtpTlsCheckBox.Enabled)
					{
						client.Connect(smtpHostTextBox.Text, port, SecureSocketOptions.StartTlsWhenAvailable);
					}
					else
					{
						client.Connect(smtpHostTextBox.Text, port, SecureSocketOptions.Auto);
					}

					client.Authenticate(smtpUsernameTextBox.Text, smtpPasswordTextBox.Text);
					client.Send(message);
					client.Disconnect(true);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Unable to send message, please check the connection.", "Mail error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Occurs when the value of the <see cref="CheckBox.Checked"/> property changes.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SmtpSslCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			switch (smtpSslCheckBox.CheckState)
			{
				case CheckState.Checked:
					smtpTlsCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}

		/// <summary>
		/// Occurs when the value of the <see cref="CheckBox.Checked"/> property changes.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SmtpTlsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			switch (smtpTlsCheckBox.CheckState)
			{
				case CheckState.Checked:
					smtpSslCheckBox.Checked = false;
					break;
				case CheckState.Unchecked:
					break;
			}
		}
	}
}
