using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ToDoApp.WebAPI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IActionResult Json(object o, int statusCode)
        {
            HttpContext.Response.StatusCode = statusCode;

            return Json(o);
        }

        protected string UserId => !User.Identity.IsAuthenticated
            ? string.Empty
            : User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
