using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VPetShop.Models;

namespace VPetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                // Xử lý form liên hệ (có thể gửi email hoặc lưu vào DB)
                // Hiện tại chỉ redirect về trang chính với thông báo thành công
                TempData["Message"] = "Tin nhắn của bạn đã được gửi thành công!";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
