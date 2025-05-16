using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace YourApp.Controllers
{
    public class Student
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string ChuyenNganh { get; set; }
    }

    public static class StudentData
    {
        public static List<Student> Students = new List<Student>();
    }

    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowKQ(Student sv)
        {
            // Lưu vào danh sách
            StudentData.Students.Add(sv);

            // Đếm số lượng sinh viên cùng chuyên ngành
            int count = StudentData.Students.Count(s => s.ChuyenNganh == sv.ChuyenNganh);

            ViewBag.MSSV = sv.MSSV;
            ViewBag.HoTen = sv.HoTen;
            ViewBag.ChuyenNganh = sv.ChuyenNganh;
            ViewBag.CountSameMajor = count;

            return View();
        }
    }
}
