using Microsoft.AspNetCore.Mvc;

namespace CrediSoft.WebAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
