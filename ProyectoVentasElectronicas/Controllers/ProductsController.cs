using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;

namespace ProyectoVentasElectronicas.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductsController( ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var productList = _applicationDbContext.Products
              .Include(p => p.Category)
              .Include(p => p.Suplier)
               .ToList();

            int id =Convert.ToInt32(HttpContext.Request.Cookies["userId"]);
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];


            Clients client = _applicationDbContext.Clients.FirstOrDefault(e => e.Client_id == id);

            if (client.admin == true)
            {
                ViewBag.Admin = true;
            }
            else
            {
                ViewBag.Admin = false;
            }


            return View(productList);
        }

        public IActionResult NewProduct()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];

            ViewBag.Supliers = _applicationDbContext.Supliers.ToList();
            ViewBag.Categories = _applicationDbContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult NewProduct(Products product)
        {
            ViewBag.Supliers = _applicationDbContext.Supliers.ToList();
            ViewBag.Categories = _applicationDbContext.Categories.ToList();
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];



            if (product != null)
            {
                _applicationDbContext.Add(product);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
