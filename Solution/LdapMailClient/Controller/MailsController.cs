using LdapMailClient.Model;
using System.Collections.Generic;
using System.Linq;

namespace LdapMailClient.Controller
{
	public class MailsController
	{
		private IMailsView view;
		private IEnumerable<Mail> mails;

		/// <summary>
		/// Initializes a new instance of the <see cref="MailsController"/> class by using the specified view context and data source.
		/// </summary>
		/// <param name="view">The view context.</param>
		/// <param name="mails">The data source.</param>
		public MailsController(IMailsView view, IEnumerable<Mail> mails)
		{
			this.view = view;
			this.mails = mails;
			view.SetController(this);
		}

		/// <summary>
		/// Returns a read-only <see cref="System.Collections.ObjectModel.ReadOnlyCollection{T}"/> wrapper for the current collection.
		/// </summary>
		public IEnumerable<Mail> Mails => mails.ToList().AsReadOnly();

		/// <summary>
		/// Causes the control to redraw the invalidated regions within its client area.
		/// </summary>
		public void LoadView()
		{
			view.ClearMails();

			foreach (Mail mail in mails)
			{
				view.AddMail(mail);
			}
		}
	}
}