using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoVentasElectronicas.Models
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Cookies.ContainsKey("sessionId"))
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }

}
