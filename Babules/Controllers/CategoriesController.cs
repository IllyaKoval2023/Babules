using Azure.Core;
using Babules.Models;
using Microsoft.AspNetCore.Mvc;

namespace Babules.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoriesContext _db;

        public CategoriesController(CategoriesContext db)
        {
            _db = db;
        }

        public IActionResult ListOfCategories()
        {
            return View();
        }

        public IActionResult CreateOrUpdate()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAndUpdate()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult CreateOrUpdate(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _db.Categories.Add(category);
                }
                else
                {
                    _db.Categories.Update(category);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }*/
        [HttpPost]
        public IActionResult CreateAndUpdate(AddOrUpdateCategoryViewModel request)
        {
            var category = new Category()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description
            };
            return View(category);
        }
    }
}
