using LdapMailClient.Model;
using System.Collections.Generic;
using System.Linq;

namespace LdapMailClient.Controller
{
	public class UsersController
	{
		private IUsersView view;
		private IEnumerable<User> users;
		private User selectedUser;

		/// <summary>
		/// Initializes a new instance of the <see cref="UsersController"/> class by using the specified view context and data source.
		/// </summary>
		/// <param name="view">The view context.</param>
		/// <param name="mails">The data source.</param>
		public UsersController(IUsersView view, IEnumerable<User> users)
		{
			this.view = view;
			this.users = users;
			view.SetController(this);
		}

		/// <summary>
		/// Returns a read-only <see cref="System.Collections.ObjectModel.ReadOnlyCollection{T}"/> wrapper for the current collection.
		/// </summary>
		public IEnumerable<User> Users => users.ToList().AsReadOnly();

		/// <summary>
		/// Causes the control to redraw the invalidated regions within its client area.
		/// </summary>
		public void LoadView()
		{	
			view.ClearGrid();

			foreach (User user in users)
			{ 
				view.AddUserToGrid(user);
			}

			view.SetSelectedUserInGrid(users.ElementAt(0));
		}

		/// <summary>
		/// Occurs when the selected <see cref="User"/> changes.
		/// </summary>
		/// <param name="ID">The <see cref="User.ID"/> of the <see cref="User"/> object.</param>
		public void SelectedUserChanged(int ID)
		{
			foreach (User user in this.users)
			{
				if (user.ID == ID)
				{
					selectedUser = user;
					view.SetSelectedUserInGrid(user);
					break;
				}
			}
		}
	}
}