using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MimeKit;
using Backend.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly EmailSettings _emailSettings;

        public ContactController(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] ContactRequest request)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress(request.Name, _emailSettings.SenderEmail));
                email.To.Add(new MailboxAddress("Georgios", _emailSettings.ReceiverEmail));
                email.Subject = string.IsNullOrEmpty(request.Subject)
                    ? $"Portfolio Contact from {request.Name}"
                    : request.Subject;

                email.Body = new TextPart("html")
                {
                    Text = $@"
                        <h2 style='color:#4f46e5'>New Portfolio Message!</h2>
                        <p><strong>Name:</strong> {request.Name}</p>
                        <p><strong>Email:</strong> {request.Email}</p>
                        <p><strong>Subject:</strong> {request.Subject}</p>
                        <hr/>
                        <p><strong>Message:</strong></p>
                        <p>{request.Message}</p>
                    "
                };

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(
                    _emailSettings.SmtpServer,
                    _emailSettings.SmtpPort,
                    MailKit.Security.SecureSocketOptions.StartTls
                );
                await smtp.AuthenticateAsync(
                    _emailSettings.SenderEmail,
                    _emailSettings.SenderPassword
                );
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);

                return Ok(new { message = "Email sent!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Failed", error = ex.Message });
            }
        }
    }
}