using Microsoft.AspNetCore.Mvc;

namespace Furniture_WMS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
