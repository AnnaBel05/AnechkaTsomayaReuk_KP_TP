using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly UniversityContext _context;

        public ActivitiesController(UniversityContext context)
        {
            _context = context;
        }

        // GET: Activities
        public async Task<IActionResult> Index()
        {
            var universityContext = _context.Activities.Include(a => a.ActivityType).Include(a => a.Student);
            return View(await universityContext.ToListAsync());
        }

        // GET: Activities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        // GET: Activities/Create
        [Authorize(Roles = "employee")]
        public IActionResult Create()
        {
            ViewData["ActivityTypeId"] = new SelectList(_context.ActivityTypes, "Id", "Name");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName");
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,ActivityTypeId,Date,Topic")] Activity activity)
        {
            if (ModelState.IsValid)
            {
                activity.Id = Guid.NewGuid();
                _context.Add(activity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActivityTypeId"] = new SelectList(_context.ActivityTypes, "Id", "Name", activity.ActivityTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName", activity.StudentId);
            return View(activity);
        }

        // GET: Activities/Edit/5
        [Authorize(Roles = "employee")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities.FindAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            ViewData["ActivityTypeId"] = new SelectList(_context.ActivityTypes, "Id", "Name", activity.ActivityTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName", activity.StudentId);
            return View(activity);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StudentId,ActivityTypeId,Date,Topic")] Activity activity)
        {
            if (id != activity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityExists(activity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActivityTypeId"] = new SelectList(_context.ActivityTypes, "Id", "Id", activity.ActivityTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", activity.StudentId);
            return View(activity);
        }

        // GET: Activities/Delete/5
        [Authorize(Roles = "employee")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var activity = await _context.Activities.FindAsync(id);
            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivityExists(Guid id)
        {
            return _context.Activities.Any(e => e.Id == id);
        }
    }
}
