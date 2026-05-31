using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User("Иванов", "Иван", "ivanov@mail.ru", "/images/default-avatar.png");
            return View(user);
        }
    }
}
