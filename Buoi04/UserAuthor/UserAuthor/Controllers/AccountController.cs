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
                ViewBag.Success = "Đăng ký thành công!";
                ModelState.Clear();
                return View();
            }

            // Debug: log ra lỗi (tùy chọn)
            foreach (var modelState in ModelState)
            {
                foreach (var error in modelState.Value.Errors)
                {
                    Console.WriteLine($"Lỗi ở {modelState.Key}: {error.ErrorMessage}");
                }
            }

            ViewBag.Failure = "Đăng ký thất bại. Vui lòng kiểm tra thông tin bạn nhập.";
            return View(user);
        }
    }
}
