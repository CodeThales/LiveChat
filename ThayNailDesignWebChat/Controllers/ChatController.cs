using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Data;
using ThayNailDesign.Hubs;
using ThayNailDesign.Models;


namespace ThayNailDesign.Controllers
{
    public class ChatController : Controller
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly ThayNailDesignContext _context;

        public ChatController(UserManager<AppUser> userManager, ThayNailDesignContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.CurrentUserName = currentUser.UserName;
            ViewBag.Messages = _context.Message.Where(m => m.TargetName == null).ToList();
            return View();
        }

        public async Task<IActionResult> Private()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            List<IdentityUser> allUsers = _context.Users.Where(u => u.UserName != currentUser.UserName).ToList();
            return View(allUsers);
        }

        public async Task<IActionResult> PrivateMessage(string usuario)
        {
            var current = await _userManager.GetUserAsync(User);
            var target = await _userManager.FindByNameAsync(usuario);

            var sentMessages = _context.Message.Where(m => m.UserName == current.UserName && m.TargetName == target.UserName).ToList();
            var receivedMessages = _context.Message.Where(m => m.UserName == target.UserName && m.TargetName == current.UserName).ToList();
            var messages = sentMessages.Concat(receivedMessages).ToList();

            ViewBag.Messages = messages;
            ViewBag.CurrentUser = current;
            ViewBag.TargetUser = target;
            return View();
        }

        public async Task<IActionResult> SendMessage(string Text, [FromServices] IHubContext<ChatHub> chat)
        {
            var sender = await _userManager.GetUserAsync(User);
            Message message = new Message
            {
                Text = Text,
                UserName = User.Identity.Name,
                UserId = sender.Id,
                Date_time = DateTime.Now
            };

            _context.Message.Add(message);
            _context.SaveChanges();

            await chat.Clients.All.SendAsync("ReceiveMessage", message);

            return Ok();
        }
    }
}
