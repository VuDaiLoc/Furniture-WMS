using Microsoft.AspNetCore.Mvc;

namespace QL_KhoNotThat.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
