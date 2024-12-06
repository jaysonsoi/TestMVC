using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View(TestDatabasee.ProductList);
        }

        public IActionResult Create()
        {
            return View();
        }

        // Handle create form submission
        [HttpPost]
        public IActionResult Create(Product product)
        {
            Guid id = Guid.NewGuid();
            product.Id = id;
            TestDatabasee.ProductList.Add(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
