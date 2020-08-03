using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AkronWeb.Models;

namespace AkronWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<User> _userList = new List<User>()
        {
            new User{
            Id= Guid.NewGuid(),
            Name = "User1",
            CanCreate = true,
            CanDelete = false,
            CanDownload = true,
            CanModify = false,
            CanRead = false
            },
            new User{
            Id= Guid.NewGuid(),
            Name = "User2",
            CanCreate = false,
            CanDelete = false,
            CanDownload = true,
            CanModify = false,
            CanRead = true
            },
            new User{
            Id= Guid.NewGuid(),
            Name = "User3",
            CanCreate = true,
            CanDelete = true,
            CanDownload = true,
            CanModify = true,
            CanRead = false
            },
            new User{
            Id= Guid.NewGuid(),
            Name = "User4",
            CanCreate = false,
            CanDelete = false,
            CanDownload = true,
            CanModify = false,
            CanRead = false
            },
            new User{
            Id= Guid.NewGuid(),
            Name = "User5",
            CanCreate = false,
            CanDelete = false,
            CanDownload = false,
            CanModify = false,
            CanRead = false
            },
            new User{
            Id= Guid.NewGuid(),
            Name = "User6",
            CanCreate = true,
            CanDelete = false,
            CanDownload = true,
            CanModify = false,
            CanRead = false
            }
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_userList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
