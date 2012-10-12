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
			email.To.Add("david.mazvovsky@gmail.com");
			email.Subject = "testing this";
			email.Body = "test";
			email.From = new MailAddress("not-really-a-real-address@xomixinc.com", "david the great");
			email.Sender=new MailAddress("VERP@xomixinc.com","VERP");

			var client = new SmtpClient("localhost");
			client.Send(email);
			
			Console.WriteLine ("Sent!");
		}
	}
}
