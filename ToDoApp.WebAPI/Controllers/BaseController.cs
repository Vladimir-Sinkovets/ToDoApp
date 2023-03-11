using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.WebAPI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IActionResult Json(object o, int statusCode)
        {
            HttpContext.Response.StatusCode = statusCode;

            return Json(o);
        }
    }
}
