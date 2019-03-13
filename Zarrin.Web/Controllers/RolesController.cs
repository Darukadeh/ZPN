using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zarrin.Models.Entities.Identity;

namespace Zarrin.Web.Controllers
{
    public class RolesController : Controller
    {
        private readonly UserManager<AppIdentityUser> _userManager;
        private readonly RoleManager<AppIdentityRole> _roleManager;
        public RolesController(
            UserManager<AppIdentityUser> userManager,
            RoleManager<AppIdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //var role = new AppIdentityRole
            //{
            //    Name="admin2",
            //    NormalizedName="administrator2",
            //};
            //// var result = await userManager.CreateAsync(user, model.Password);
            //var result = await _roleManager.CreateAsync(role);
            //if (result.Succeeded)
            //{
            //    var u =await _userManager.GetUserAsync(User);
            //    var r = _userManager.AddToRoleAsync(u, "admin2");

            //    return View();
            //}
            var u = await _userManager.GetUserAsync(User);
            var r = await _userManager.AddToRoleAsync(u, "admin");
            if (r.Succeeded)
            {

            }
            return View();
        }
    }
}