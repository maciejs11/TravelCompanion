using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Data;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.Chat;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    
    public class ChatController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly AppDbContext _appDbContext;

        public ChatController(UserManager<ApplicationUser> userManager, AppDbContext appDbContex)
        {
            _userManager = userManager;
            _appDbContext = appDbContex;
        }

        public async Task<IActionResult> ChatIndex()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.CurrentUserName = currentUser.UserName;
            var messages = await _appDbContext.Messages.ToListAsync();
            return View();
        }

        public async Task<IActionResult> Create(Message message)
        {
            if(ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _appDbContext.Messages.AddAsync(message);
                await _appDbContext.SaveChangesAsync();
                return Ok();
            }
            return View("NotFoundUser");
        }
    }
}
