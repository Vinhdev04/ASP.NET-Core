using Microsoft.AspNetCore.Mvc;
using VPetShop.Models;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        var products = _productRepository.GetAll();
        return View(products);
    }

    public IActionResult Add()
    {
        ViewBag.Categories = _categoryRepository.GetAll();
        return View();
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.Add(product);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = _categoryRepository.GetAll();
        return View(product);
    }

    public IActionResult Display(int id)
    {
        var product = _productRepository.GetById(id);
        if (product == null) return NotFound();
        return View(product);
    }

    public IActionResult Update(int id)
    {
        var product = _productRepository.GetById(id);
        if (product == null) return NotFound();
        ViewBag.Categories = _categoryRepository.GetAll();
        return View(product);
    }

    [HttpPost]
    public IActionResult Update(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.Update(product);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = _categoryRepository.GetAll();
        return View(product);
    }

    public IActionResult Delete(int id)
    {
        var product = _productRepository.GetById(id);
        if (product == null) return NotFound();
        return View(product);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _productRepository.Delete(id);
        return RedirectToAction("Index");
    }
}