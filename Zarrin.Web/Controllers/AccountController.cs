namespace Zarrin.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Zarrin.DataAccess;
    using Zarrin.Models.Entities;
    using Zarrin.Services.Services;

    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: Users
        public IActionResult Index()
        {
            var allUsers = _accountService.GetAllUsers();
            return View(allUsers);
        }
    }
}
