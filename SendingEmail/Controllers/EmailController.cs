using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SendingEmail.Models;
using SendingEmail.Services;

namespace SendingEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailServiceSmtp _emailService;

        public EmailController(IEmailServiceSmtp emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("/EmailSender")]
        public IActionResult SendEmail(EmailDetails EmailRequest)
        {
            _emailService.SendEmail(EmailRequest);
            return Ok();
        }
    }
}
