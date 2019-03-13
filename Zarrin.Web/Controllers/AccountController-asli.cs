namespace Zarrin.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Zarrin.DataAccess;
    using Zarrin.Models.Entities;
    using Zarrin.Services.Services;

    public class AccountControllerasli : Controller
    {
        private readonly AccountService _accountService;
        public AccountControllerasli(AccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: Users
        public IActionResult Index()
        {
            var allUsers = _accountService.GetAllUsers();
            return View(allUsers);
        }

         public IActionResult Login()
        {
            return View();
        }
    }
}
