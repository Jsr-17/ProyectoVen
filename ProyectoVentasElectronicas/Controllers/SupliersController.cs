using Microsoft.AspNetCore.Mvc;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;

namespace ProyectoVentasElectronicas.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    public class SupliersController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SupliersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            List<Supliers> list = new List<Supliers>();
            list = _applicationDbContext.Supliers.ToList();

            int id=Convert.ToInt16(HttpContext.Request.Cookies["userId"]);
            
            Clients client = _applicationDbContext.Clients.FirstOrDefault(e=>e.Client_id == id);

            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];


            if (client.admin==true)
            {
                ViewBag.Admin = true;
            }
            else
            {
                ViewBag.Admin = false;
            }

            return View(list);
        }

        [HttpPost]
        public IActionResult NewSuplier(Supliers supliers)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Supliers.Add(supliers);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult NewSuplier()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];
            return View();

        }


    }
}
