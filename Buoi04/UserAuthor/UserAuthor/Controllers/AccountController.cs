using Microsoft.AspNetCore.Mvc;
using UserAuthor.Models;

namespace UserAuthor.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Registered = true;
                return View(user);
            }

            ViewBag.Failure = "Đăng ký thất bại. Vui lòng kiểm tra thông tin bên dưới.";
            return View(user);
        }
    }
}
