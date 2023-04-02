using Microsoft.AspNetCore.Mvc;

namespace Babules.Controllers
{
    public class ActivitiesController : Controller
    {
        public IActionResult ListOfOperations()
        {
            return View();
        }
        public IActionResult CreateAndUpdate()
        {
            return View();
        }
    }
}
