using Microsoft.AspNetCore.Mvc;

namespace resumePage.Controllers
{
    public class SaladController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
