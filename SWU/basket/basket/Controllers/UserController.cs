using basket.Models;
using Microsoft.AspNetCore.Mvc;

namespace basket.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new List<User>
            {
                new User {Id=1,Name="Tosho",Email="Tosho@abv.bg"} ,
                new User {Id=2,Name="Ivan",Email="Ivan@abv.bg"} ,
                new User {Id=3,Name="Miro",Email="Miro@abv.bg"}

            };
            return View(user);
        }
    }
}
