using Microsoft.AspNetCore.Mvc;

namespace CrediSoft.WebAPI.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
