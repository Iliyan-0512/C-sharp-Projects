using Microsoft.AspNetCore.Mvc;
using Task2.Models;
using Task2.Helpers;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new NormalizeViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(NormalizeViewModel model, string action)
        {
            if (action == "Format")
            {
                model.OutputText = CodeFormatter.Format(model.InputText ?? "");
            }
            else if (action == "Normalize")
            {
                string errorMessage;
                string normalized = TextNormalizer.Normalize(model.InputText ?? "", out errorMessage);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    ModelState.AddModelError(string.Empty, errorMessage);
                    model.OutputText = "";
                }
                else
                {
                    model.OutputText = normalized;
                }
            }

            return View(model);
        }

    }
}
