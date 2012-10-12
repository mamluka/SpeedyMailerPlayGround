using System;
using System.Net.Mail;

namespace MailTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Settings up");
			
			var email = new MailMessage();
			email.To.Add("davidm@delver.com");
			email.Subject = "testing this";
			email.Body = "test";
			email.From = new MailAddress("david@xomixinc.com", "david the great");

			var client = new SmtpClient();
			client.Send(email);
			
			Console.WriteLine ("Sent!");
		}
	}
}
