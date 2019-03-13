using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zarrin.Models.Entities.Identity;

namespace Zarrin.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<AppIdentityUser> _userManager;

        public UsersController(
            UserManager<AppIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var viewModel = _userManager.Users.ToList();
            return View(viewModel);
        }
    }
}