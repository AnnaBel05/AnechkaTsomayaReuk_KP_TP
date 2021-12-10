using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2.Controllers
{
    public class MarksController : Controller
    {
        private readonly UniversityContext _context;

        public MarksController(UniversityContext context)
        {
            _context = context;
        }

        // GET: Marks
        public async Task<IActionResult> Index()
        {
            var universityContext = _context.Marks.Include(m => m.Course).Include(m => m.MarkType).Include(m => m.Student).Include(m => m.Value);
            return View(await universityContext.ToListAsync());
        }

        // GET: Marks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .Include(m => m.Course)
                .Include(m => m.MarkType)
                .Include(m => m.Student)
                .Include(m => m.Value)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // GET: Marks/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");
            ViewData["MarkTypeId"] = new SelectList(_context.MarkTypes, "Id", "Name");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName");
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Name");
            return View();
        }

        // POST: Marks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,MarkTypeId,CourseId,Date,ValueId")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                mark.Id = Guid.NewGuid();
                _context.Add(mark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Id", mark.CourseId);
            ViewData["MarkTypeId"] = new SelectList(_context.MarkTypes, "Id", "Id", mark.MarkTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", mark.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Id", mark.ValueId);
            return View(mark);
        }

        // GET: Marks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks.FindAsync(id);
            if (mark == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name", mark.CourseId);
            ViewData["MarkTypeId"] = new SelectList(_context.MarkTypes, "Id", "Name", mark.MarkTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName", mark.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Name", mark.ValueId);
            return View(mark);
        }

        // POST: Marks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StudentId,MarkTypeId,CourseId,Date,ValueId")] Mark mark)
        {
            if (id != mark.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkExists(mark.Id))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Id", mark.CourseId);
            ViewData["MarkTypeId"] = new SelectList(_context.MarkTypes, "Id", "Id", mark.MarkTypeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", mark.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Id", mark.ValueId);
            return View(mark);
        }

        // GET: Marks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .Include(m => m.Course)
                .Include(m => m.MarkType)
                .Include(m => m.Student)
                .Include(m => m.Value)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var mark = await _context.Marks.FindAsync(id);
            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkExists(Guid id)
        {
            return _context.Marks.Any(e => e.Id == id);
        }
    }
}
