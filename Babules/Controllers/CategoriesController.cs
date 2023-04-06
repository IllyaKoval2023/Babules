using Babules.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Babules.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoriesContext _context;

        public CategoriesController(CategoriesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ListOfCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateAndUpdate(int? id)
        {
            if (id == null)
            {
                // Create new category
                return View(new Category());
            }
            else
            {
                // Update existing category
                var category = _context.Categories.Find(id);
                if (category == null)
                {
                    return NotFound();
                }
                return View(category);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAndUpdate(int? id, Category category)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    // Create new category
                    _context.Categories.Add(category);
                }
                else
                {
                    // Update existing category
                    _context.Categories.Update(category);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListOfCategories));
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListOfCategories));
        }
    }
}