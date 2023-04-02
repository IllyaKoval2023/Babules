using Microsoft.AspNetCore.Mvc;

namespace Babules.Controllers
{
    public class ReportGeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
