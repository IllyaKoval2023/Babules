using Babules.Data;
using Babules.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Babules.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly BabulesContext _context;

        public ActivitiesController(BabulesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListOfOperations()
        {
            List<Operations> operations = await _context.Operations.Include(o => o.Category).ToListAsync();
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View(operations);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAndUpdate(int? id)
        {
            if (id == null)
            {
                ViewBag.Categories = await _context.Categories.ToListAsync();
                return View(new Operations());
            }

            Operations operation = await _context.Operations.FirstOrDefaultAsync(o => o.Id == id);
            if (operation == null)
            {
                return NotFound();
            }

            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View(operation);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAndUpdate(int? id, Operations operation)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    _context.Operations.Add(operation);
                }
                else
                {
                    _context.Operations.Update(operation);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListOfOperations));
            }
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View(operation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var operation = await _context.Operations.FindAsync(id);
            if (operation == null)
            {
                return NotFound();
            }
            _context.Operations.Remove(operation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListOfOperations));
        }
    }
}