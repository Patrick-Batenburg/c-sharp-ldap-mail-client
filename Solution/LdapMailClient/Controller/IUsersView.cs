using LdapMailClient.Model;
using System.Net.Mail;

namespace LdapMailClient.Controller
{
	public interface IUsersView
	{
		/// <summary>
		/// Sets the controller context.
		/// </summary>
		/// <param name="controller">The <see cref="MailsController"/> to set.</param>
		void SetController(UsersController controller);

		/// <summary>
		/// Removes all <see cref="User"/> objects from the view.
		/// </summary>
		void ClearGrid();

		/// <summary>
		/// Adds a <see cref="User"/> object to the view.
		/// </summary>
		/// <param name="user">The <see cref="User"/> object to be added.</param>
		void AddUserToGrid(User user);

		/// <summary>
		/// Sets the selected <see cref="User"/> object.
		/// </summary>
		/// <param name="user">The <see cref="User"/> object to set.</param>
		void SetSelectedUserInGrid(User user);

		/// <summary>
		/// Returns the <see cref="User.ID"/> property of the selected <see cref="User"/> object.
		/// </summary>
		/// <returns>The <see cref="User.ID"/> for the currently selected object.</returns>
		int GetIdOfSelectedUserInGrid();
	}
}
