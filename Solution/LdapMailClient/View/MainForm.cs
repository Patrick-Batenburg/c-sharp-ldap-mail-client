using LdapMailClient.Controller;
using LdapMailClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace LdapMailClient.View
{
	public partial class MainForm : Form, IUsersView
	{
		private UsersController usersController;
		private DirectorySearcher directorySearcher;
		private string displayNameProperty = "cn";
		private string mailProperty = "mail";
		private string passwordProperty = "userPassword";
		private MailAddress mailAddress;
		private string password = "";
		private IList<User> users = new List<User>();

		public MainForm()
		{
			InitializeComponent();
		}

		private string GetSystemDomain()
		{
			try
			{
				return Domain.GetComputerDomain().ToString().ToLower();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
		}

		private DirectorySearcher GetDirectorySearcher(string username, string passowrd, string domain)
		{
			//return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://ldap.forumsys.com/dc=example,dc=com", "", "", AuthenticationTypes.None));
			return directorySearcher = new DirectorySearcher(new DirectoryEntry("LDAP://" + domain, username, passowrd, AuthenticationTypes.None));
		}

		private SearchResultCollection SearchForUsers(DirectorySearcher directorySearcher)
		{
			directorySearcher.Filter = "(uid=*)";
			directorySearcher.SearchScope = SearchScope.Subtree;
			directorySearcher.PropertiesToLoad.Add(displayNameProperty);
			directorySearcher.PropertiesToLoad.Add(mailProperty);
			directorySearcher.PropertiesToLoad.Add(passwordProperty);
			SearchResultCollection results = null;

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

				usersController = new UsersController(this, users);
				usersController.LoadView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to connect to server, please check the credentials or the domain.\n" + ex.Message, "Error info", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				directorySearcher.Dispose();
			}

			return results;
		}

		public void AddUserToGrid(User user)
		{
			ListViewItem item;
			item = this.usersListView.Items.Add(user.ID.ToString());
			item.SubItems.Add(user.MailAddress.ToString());
			item.SubItems.Add(user.Password);
		}

		public void ClearGrid()
		{
			usersListView.Items.Clear();
		}

		public void SetController(UsersController usersController)
		{
			this.usersController = usersController;
		}

		public void SetSelectedUserInGrid(User user)
		{
			foreach (ListViewItem row in this.usersListView.Items)
			{
				if (row.Text == user.ID.ToString())
				{
					row.Selected = true;
					MessageBox.Show(user.ID + " " + user.MailAddress.ToString());
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			domainTextBox.Text = "ldap.forumsys.com/dc=example,dc=com";
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			ClearGrid();
			SearchForUsers(GetDirectorySearcher(usernameTextBox.Text, passwordTextBox.Text, domainTextBox.Text));
		}

		private void fetchLocalDomainButton_Click(object sender, EventArgs e)
		{
			domainTextBox.Text = GetSystemDomain();
		}
	}
}
