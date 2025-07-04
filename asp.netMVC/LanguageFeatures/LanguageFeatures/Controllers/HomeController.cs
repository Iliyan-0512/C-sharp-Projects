﻿using System.Net.NetworkInformation;
using LanguageFeatures.Model;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            var products = new[] {
 new { Name = "Kayak", Price = 275M },
 new { Name = "Lifejacket", Price = 48.95M },
 new { Name = "Soccer ball", Price = 19.50M },
 new { Name = "Corner flag", Price = 34.95M }
 };
            return View(products.Select(p =>$"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"
));


        }


    }
}
