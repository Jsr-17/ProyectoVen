using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasElectronicas.Data;
using ProyectoVentasElectronicas.Models;


namespace ProyectoVentasElectronicas.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    [ServiceFilter(typeof(AdminAttribute))]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AdminController(ApplicationDbContext applicationDbContext) 
        { 
        _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];

            var DetailsList =_applicationDbContext.DetailsOrder
                .Include(u=>u.Order).ThenInclude(o=>o.Client)
                .Include(u=>u.Product).ThenInclude(o=>o.Category)
                .Distinct()
                .ToList();

            return View(DetailsList);
        }
        public IActionResult NewOrderDetail()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];

            ViewBag.Products=_applicationDbContext.Products.ToList();
            ViewBag.Clients=_applicationDbContext.Clients.ToList();
            ViewBag.Orders=_applicationDbContext.Orders.ToList().Distinct();
            return View();
        }
        [HttpPost]
        public IActionResult NewOrderDetail(DetailsOrders details)
        {
            ViewBag.Products = _applicationDbContext.Products.ToList();
            ViewBag.Clients = _applicationDbContext.Clients.ToList();


            Orders orders = new Orders
            { Order_date = DateTime.Now,
                State = Request.Form["State"],
                Client_id = Convert.ToInt16(Request.Form["Client_id"])};
            details.Order = orders;

            if (details!= null)
            {

                _applicationDbContext.DetailsOrder.Add(details);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
                
            }

            return View();
        }
        public IActionResult AccessDenied()
        {
            ViewBag.Sesion = HttpContext.Request.Cookies["UserId"];

            int id = Convert.ToInt16(HttpContext.Request.Cookies["userId"]);

            Clients client=_applicationDbContext.Clients.FirstOrDefault(e=>e.Client_id==id);

            ViewBag.Name = client.Name;

            return View();
        }

    }
}
