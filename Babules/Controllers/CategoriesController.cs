using Microsoft.AspNetCore.Mvc;

namespace Babules.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult ListOfCategories()
        {
            return View();
        }
        public IActionResult CreateAndUpdate()
        {
            return View();
        }
    }
}
