using LdapMailClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapMailClient.Controller
{
	public interface IMailsView
	{
		/// <summary>
		/// Sets the controller context.
		/// </summary>
		/// <param name="controller">The <see cref="MailsController"/> to set.</param>
		void SetController(MailsController controller);

		/// <summary>
		/// Removes all <see cref="Mail"/> objects from the view.
		/// </summary>
		void ClearMails();

		/// <summary>
		/// Adds a <see cref="Mail"/> object to the view.
		/// </summary>
		/// <param name="mail">The <see cref="Mail"/> object to be added.</param>
		void AddMail(Mail mail);
	}
}
