using LdapMailClient.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapMailClient.Controller
{
	public class UsersController
	{
		IUsersView view;
		IList<User> users;
		User selectedUser;

		public UsersController(IUsersView view, IList<User> users)
		{
			this.view = view;
			this.users = users;
			view.SetController(this);
		}

		public IList<User> Users
		{
			get { return users.ToList<User>(); }
		}

		public void LoadView()
		{
			view.ClearGrid();

			foreach (User user in users)
			{ 
				view.AddUserToGrid(user);
			}

			view.SetSelectedUserInGrid((User)users[0]);
		}

		public void SelectedUserChanged(int selectedUserId)
		{
			foreach (User user in this.users)
			{
				if (user.ID == selectedUserId)
				{
					selectedUser = user;
					view.SetSelectedUserInGrid(user);
					break;
				}
			}
		}
	}
}
