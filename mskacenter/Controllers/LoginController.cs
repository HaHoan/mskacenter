using Microsoft.AspNetCore.Mvc;
using mskacenter.Models;
using mskacenter.ViewModels;

namespace mskacenter.Controllers
{
    public class LoginController : Controller
    {
        private readonly MskaManagementContext _context;

        public LoginController(MskaManagementContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Username == model.Username
                                  && x.Password == model.Password);

            if (user == null)
            {
                ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
                return View(model);
            }

            // TODO: lưu session / cookie

            return RedirectToAction("Index", "Home");
        }
    }
}
