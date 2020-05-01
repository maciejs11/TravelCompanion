using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net;
using System.Net.Mail;
using Inzynierka.Models.ChatEmail;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Inzynierka.Models.ApplicationUsers;
using Microsoft.AspNetCore.Identity;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class ChatEmailController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public readonly IHttpContextAccessor _httpContextAccessor;

        public ChatEmailController(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        
        public string SendEmailForm(string email, string Message )
        {
            try
            {
                string userEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
                // Credentials
                var credentials = new NetworkCredential("travelcompanionn3@gmail.com", "iNzynI3rk@24");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("travelcompanionn3@gmail.com"),
                    Subject = "Wiadomosc prywatna od użytkownika z TravelCompanion.",
                    Body = "Użytkownik " + userEmail + " z serwisu TravelCompanion napisał do Ciebie wiadomość: " + "\n" + "\n" + "\"" +Message + "\"" +
                            "\n" + "\n" + "Możesz odpisać mu na jego e-mail " + userEmail + " lub napisać mu wiadomość wyszukując go i wchodząc na jego profil w serwisie TravelCompanion."
                };
                mail.IsBodyHtml = false;
                mail.To.Add(new MailAddress(email));
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
                return "Wysłano Email!";
            }
            catch(System.Exception e)
            {
                return e.Message;
            }
        }


    }
}

