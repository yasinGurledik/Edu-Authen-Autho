using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace Edu_Authen_Autho
{
	public class EmailSender : IEmailSender
	{
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
			{
				Credentials = new NetworkCredential("ac9957c9282262", "pasword"),
				EnableSsl = true
			};
			client.Send("from@example.com", email, subject, htmlMessage);

			return Task.CompletedTask;
		}
	}
}
