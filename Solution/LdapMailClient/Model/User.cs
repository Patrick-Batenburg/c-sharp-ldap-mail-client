using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace LdapMailClient.Model
{
	public class User
	{
		private MailAddress mailAddress;
		private string password;
		private int _ID;

		public User(MailAddress mailAddress, string password)
		{
			this.mailAddress = mailAddress;
			this.password = password;
		}

		public User(int ID, MailAddress mailAddress, string password)
		{
			this.ID = ID;
			this.mailAddress = mailAddress;
			this.password = password;
		}

		public MailAddress MailAddress { get => mailAddress; }
		public string Password { get => password; }
		public int ID { get => _ID; set => _ID = value; }
	}
}