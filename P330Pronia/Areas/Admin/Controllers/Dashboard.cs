using Microsoft.AspNetCore.Mvc;

namespace P330Pronia.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
