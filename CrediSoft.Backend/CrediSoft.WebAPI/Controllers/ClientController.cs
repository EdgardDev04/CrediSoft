using Microsoft.AspNetCore.Mvc;

namespace CrediSoft.WebAPI.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
