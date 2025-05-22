using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models; // Namespace đúng với Model bạn tạo
using System;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            var actors = new List<Actor>
            {
                new Actor { Id = 1, Name = "Robert Downey Jr.", Biography = "Famous for Iron Man", DateOfBirth = new DateTime(1965, 4, 4), PhotoUrl = "../.././images/01.png" },
                new Actor { Id = 2, Name = "Scarlett Johansson", Biography = "Known for Black Widow", DateOfBirth = new DateTime(1984, 11, 22), PhotoUrl = "../.././images/02.png" }
            };

            return View(actors);
        }

        public IActionResult Details(int id)
        {
            var actor = new Actor
            {
                Id = id,
                Name = "Robert Downey Jr.",
                Biography = "Famous for Iron Man",
                DateOfBirth = new DateTime(1965, 4, 4),
                PhotoUrl = "../.././images/01.png"
            };

            return View(actor);
        }
    }
}
