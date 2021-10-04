using introDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;
            return View();
        }

        public IActionResult Rsvp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Rsvp(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                IncomingUsers incomingUsers = new IncomingUsers();
                incomingUsers.AddUsers(userResponse);
                return View("Thanks",incomingUsers);
            }
            return View();
        }
    }
}
