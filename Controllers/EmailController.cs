using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SimpleEmailApp.Models;
using SimpleEmailApp.Services.EmailService;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            //var subject = request.Subject;
            //for (int i = 0; i < 20; i++)
            //{
            //request.Subject = $"#{i} {subject}";
            //Thread.Sleep(200);
            _emailService.SendEmail(request);
            //}
            return Ok();
        }
    }
}
