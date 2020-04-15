using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net;
using System.Net.Mail;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class ChatEmailController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string SendEmail(string Name, string Email, string Message)
        {

            try
            {
                // Credentials
                var credentials = new NetworkCredential("travelcompanionn3@gmail.com", "iNzynI3rk@24");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("travelcompanionn3@gmail.com"),
                    Subject = "Wiadomosc prywatna od użytkownika z TravelCompanion.",
                    Body = "Użytkownik maciejs1112@gmail.com z serwisu TravelCompanion napisał do Ciebie wiadomość: " + Message
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(Email));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }
    }
}
