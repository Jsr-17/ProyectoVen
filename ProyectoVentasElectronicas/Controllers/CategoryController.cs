using Microsoft.AspNetCore.Mvc;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;

namespace ProyectoVentasElectronicas.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
            public CategoryController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var categories = _applicationDbContext.Categories.ToList();

            int client_id = Convert.ToInt32( HttpContext.Request.Cookies["userId"]);
            
            Clients client = _applicationDbContext.Clients.FirstOrDefault(e=> e.Client_id == client_id);
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];


            if (client.admin==true)
            {
                ViewBag.Admin = true;
            }
            else
            {
                ViewBag.Admin = false;
            }

            return View(categories);
        }

        [HttpPost]
        public IActionResult NewCategory(Categories category)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Add(category);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult NewCategory()
        {
            return View();
        }
    }
}
