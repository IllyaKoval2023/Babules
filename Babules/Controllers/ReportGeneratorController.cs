using Microsoft.AspNetCore.Mvc;

namespace Babules.Controllers
{
    public class ReportGeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult ReportByDates()
        {
            return View();
        }
    }
}
