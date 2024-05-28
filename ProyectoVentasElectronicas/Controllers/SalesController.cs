using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;

namespace ProyectoVentasElectronicas.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    public class SalesController : Controller

        
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SalesController(ApplicationDbContext applicationDbContext) { 
        _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            int Id = Convert.ToInt16(HttpContext.Request.Cookies["UserId"]);
            var data = _applicationDbContext.Clients.FirstOrDefault(u => u.Client_id == Id);
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];


            if (data.admin==true)
            {
               ViewBag.Admin = true;
                
            }
            else
            {
                ViewBag.Admin = false;
            }

            return View(data);
        }
    }
}
