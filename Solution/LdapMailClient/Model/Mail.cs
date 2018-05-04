using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapMailClient.Model
{
	public class Mail
	{
		private MimeMessage message;
		private uint size;
		private int _ID;

		/// <summary>
		/// Initializes a new instance of the <see cref="Mail"/> class by using the specified mail message.
		/// </summary>
		/// <param name="message">A MIME message.</param>
		public Mail(MimeMessage message)
		{
			this.message = message;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Mail"/> class by using the specified identifier and mail message.
		/// </summary>
		/// <param name="ID">an identifier</param>
		/// <param name="message">A MIME message.</param>
		public Mail(int ID, MimeMessage message)
		{
			_ID = ID;
			this.message = message;
		}

		/// <summary>
		/// Gets or sets the MIME message.
		/// </summary>
		public MimeMessage Message { get => message; set => message = value; }

		/// <summary>
		/// Gets or sets the size of the message.
		/// </summary>
		public uint Size { get => size; set => size = value; }
		
		/// <summary>
		/// Gets or sets the identifier of the message.
		/// </summary>
		public int ID { get => _ID; set => _ID = value; }

		/// <summary>
		/// Returns a <see cref="string"/> that represents the current object.
		/// </summary>
		/// <returns>A <see cref="System.String"/> containing the from, subject and body of the mail.</returns>
		public override string ToString()
		{
			StringBuilder mail = new StringBuilder();
			mail.Append("From: " + message.From);
			mail.AppendLine();
			mail.Append("Subject: " + message.Subject);
			mail.AppendLine();
			mail.Append("Message: " + message.TextBody);
			return mail.ToString();
		}
	}
}
