using Microsoft.AspNetCore.Mvc;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;
using System.Diagnostics;

namespace ProyectoVentasElectronicas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];

            return View();
        }

        [HttpPost]
        public IActionResult Login(int? data)
        {
            String Username = Request.Form["Username"];
            String Password = Request.Form["Password"];

            bool isAuthenticated = _dbContext.LoginInicio(Username, Password);

            if (isAuthenticated)
            {
                Clients User = _dbContext.Clients.FirstOrDefault(e => e.Username == Username);

                HttpContext.Response.Cookies.Append("UserId", Convert.ToString(User.Client_id));
                HttpContext.Response.Cookies.Append("SessionId", "Value");



                return RedirectToAction("Index", "Sales");
            }

            ViewBag.ErrorLogin = "Error in login";              
            

            return View("Login");
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(Clients clients)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(clients);
                _dbContext.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("UserId");
            HttpContext.Response.Cookies.Delete("SessionId");

            return RedirectToAction("Login");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
