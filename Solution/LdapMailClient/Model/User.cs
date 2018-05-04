using System.Net.Mail;

namespace LdapMailClient.Model
{
	public class User
	{
		private MailAddress mailAddress;
		private string password;
		private int _ID;

		/// <summary>
		/// Initializes a new instance of the <see cref="Mail"/> class by using the specified mail address and password.
		/// </summary>
		/// <param name="mailAddress">A mail address.</param>
		/// <param name="password">A password.</param>
		public User(MailAddress mailAddress, string password)
		{
			this.mailAddress = mailAddress;
			this.password = password;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Mail"/> class by using the specified identifier, mail address and password.
		/// </summary>
		/// <param name="ID">A identifier.</param>
		/// <param name="mailAddress">A mail address.</param>
		/// <param name="password">A password.</param>
		public User(int ID, MailAddress mailAddress, string password)
		{
			_ID = ID;
			this.mailAddress = mailAddress;
			this.password = password;
		}

		/// <summary>
		/// Returns the <see cref="System.Net.Mail.MailAddress"/> object for the current object.
		/// </summary>
		public MailAddress MailAddress { get => mailAddress; }

		/// <summary>
		/// Returns the password for the current object.
		/// </summary>
		public string Password { get => password; }

		/// <summary>
		/// Gets or sets the identifier for the current object.
		/// </summary>
		public int ID { get => _ID; set => _ID = value; }
	}
}