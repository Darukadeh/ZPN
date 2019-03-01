using Microsoft.AspNetCore.Mvc;
using Zarrin.DataAccess;

namespace Zarrin.Web.Controllers
{
    public class AccountController : Controller
    {
       private readonly UnitOfWork _unitOfWork;
        public AccountController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var users = _unitOfWork.Users.GetAllUsers();
            return View(users);
        }
    }
}