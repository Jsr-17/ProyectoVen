using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ProyectoVentasElectronicas.Data;

namespace ProyectoVentasElectronicas.Models
{
    public class AdminAttribute:ActionFilterAttribute
    {
        private readonly ApplicationDbContext _applicationDb;
        public AdminAttribute(ApplicationDbContext applicationDbContext) {
            _applicationDb = applicationDbContext;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = context.HttpContext.Request.Cookies["userId"];
            if (!string.IsNullOrEmpty(userId))
            {
                var client = _applicationDb.Clients.FirstOrDefault(e => e.Client_id == Convert.ToInt16(userId));

                if (client?.admin != true)
                {
                    context.Result = new RedirectToActionResult("AccessDenied", "Admin", null);
                }
            }
            else
            {
                context.Result = new RedirectToActionResult("AccessDenied", "Admin", null);
            }
        }
    }
}
