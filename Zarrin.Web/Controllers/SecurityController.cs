using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zarrin.Models.Entities.Identity;
using Zarrin.Services.DataTransferObjects;

namespace Zarrin.Web.Controllers
{
    public class SecurityController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly SignInManager<AppIdentityUser> signInManager;

        public SecurityController(
            UserManager<AppIdentityUser> userManager,
            SignInManager<AppIdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await signInManager.PasswordSignInAsync(
                model.Username, model.Password,
                isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError(string.Empty, "Login Failed");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //------------------------------------------------------------

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = new AppIdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
                Age = model.Age
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var confrimationCode =
                     await userManager.GenerateEmailConfirmationTokenAsync(user);
                Url.Action(
                    controller: "Security",
                    action: "ConfirmEmail",
                    values: new { userId = user.Id, code = confrimationCode },
                    protocol: Request.Scheme);

                //await this.emailSender.SendEmailAsync(
                //    email: user.Email,
                //    subject: "Confirm Email",
                //    message: callbackurl);

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}