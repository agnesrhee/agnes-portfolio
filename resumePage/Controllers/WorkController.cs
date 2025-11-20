using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using resumePage.Models;

namespace resumePage.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
