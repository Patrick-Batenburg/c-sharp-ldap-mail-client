using LdapMailClient.Model;
using System.Net.Mail;

namespace LdapMailClient.Controller
{
	public interface IUsersView
	{
		void SetController(UsersController controller);
		void ClearGrid();
		void AddUserToGrid(User user);
		void SetSelectedUserInGrid(User user);
	}
}
