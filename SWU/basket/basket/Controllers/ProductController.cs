using basket.Models;
using Microsoft.AspNetCore.Mvc;

namespace basket.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Product>
                  {
                      new Product { Id = 1, Name="Apple",Price=5 },
                      new Product { Id = 2, Name="Bananas",Price=5 },
                      new Product { Id = 3, Name="Strawbary",Price=5 }

                  };
            return View(product);
        }
    }
}
