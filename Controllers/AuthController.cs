using Microsoft.AspNetCore.Mvc;
using Furniture_WMS.Data;
using Furniture_WMS.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;

namespace Furniture_WMS.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            var user = _context.NguoiDungs.FirstOrDefault(u => u.Email == username && u.MatKhau.SequenceEqual(hashedPassword));


            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Email);
                HttpContext.Session.SetString("Role", user.MaVaiTro == 1 ? "Admin" : "User"); // Admin = 1, User = 2
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
            return View();
        }

        // Hàm mã hóa mật khẩu SHA-256
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower(); // Chuyển thành chuỗi Hex
            }
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        
    }
}
