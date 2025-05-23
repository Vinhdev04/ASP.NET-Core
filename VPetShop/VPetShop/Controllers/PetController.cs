using Microsoft.AspNetCore.Mvc;
using VPetShop.Data;
using VPetShop.Models;

namespace VPetShop.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            var pets = MockPetData.GetPets();
            foreach (var pet in pets)
            {
                pet.Category = MockPetData.GetCategories().FirstOrDefault(c => c.Id == pet.CategoryId);
            }
            return View(pets);
        }
    }
}