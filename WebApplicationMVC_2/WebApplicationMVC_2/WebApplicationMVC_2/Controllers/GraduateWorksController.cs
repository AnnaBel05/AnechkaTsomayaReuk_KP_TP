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
    public class GraduateWorksController : Controller
    {
        private readonly UniversityContext _context;

        public GraduateWorksController(UniversityContext context)
        {
            _context = context;
        }

        // GET: GraduateWorks
        public async Task<IActionResult> Index()
        {
            var universityContext = _context.GraduateWorks.Include(g => g.Employee).Include(g => g.Student).Include(g => g.Value).Include(g => g.WorkStatus);
            return View(await universityContext.ToListAsync());
        }

        // GET: GraduateWorks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduateWork = await _context.GraduateWorks
                .Include(g => g.Employee)
                .Include(g => g.Student)
                .Include(g => g.Value)
                .Include(g => g.WorkStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graduateWork == null)
            {
                return NotFound();
            }

            return View(graduateWork);
        }

        // GET: GraduateWorks/Create
        [Authorize(Roles = "employee")]
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName");
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Name");
            ViewData["WorkStatusId"] = new SelectList(_context.WorkStatuses, "Id", "Name");
            return View();
        }

        // POST: GraduateWorks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Topic,StudentId,EmployeeId,ValueId,WorkStatusId")] GraduateWork graduateWork)
        {
            if (ModelState.IsValid)
            {
                graduateWork.Id = Guid.NewGuid();
                _context.Add(graduateWork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", graduateWork.EmployeeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", graduateWork.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Id", graduateWork.ValueId);
            ViewData["WorkStatusId"] = new SelectList(_context.WorkStatuses, "Id", "Id", graduateWork.WorkStatusId);
            return View(graduateWork);
        }

        // GET: GraduateWorks/Edit/5
        [Authorize(Roles = "employee")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduateWork = await _context.GraduateWorks.FindAsync(id);
            if (graduateWork == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName", graduateWork.EmployeeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FullName", graduateWork.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Name", graduateWork.ValueId);
            ViewData["WorkStatusId"] = new SelectList(_context.WorkStatuses, "Id", "Name", graduateWork.WorkStatusId);
            return View(graduateWork);
        }

        // POST: GraduateWorks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Topic,StudentId,EmployeeId,ValueId,WorkStatusId")] GraduateWork graduateWork)
        {
            if (id != graduateWork.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graduateWork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraduateWorkExists(graduateWork.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", graduateWork.EmployeeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", graduateWork.StudentId);
            ViewData["ValueId"] = new SelectList(_context.Set<Value>(), "Id", "Id", graduateWork.ValueId);
            ViewData["WorkStatusId"] = new SelectList(_context.WorkStatuses, "Id", "Id", graduateWork.WorkStatusId);
            return View(graduateWork);
        }

        // GET: GraduateWorks/Delete/5
        [Authorize(Roles = "employee")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduateWork = await _context.GraduateWorks
                .Include(g => g.Employee)
                .Include(g => g.Student)
                .Include(g => g.Value)
                .Include(g => g.WorkStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graduateWork == null)
            {
                return NotFound();
            }

            return View(graduateWork);
        }

        // POST: GraduateWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var graduateWork = await _context.GraduateWorks.FindAsync(id);
            _context.GraduateWorks.Remove(graduateWork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraduateWorkExists(Guid id)
        {
            return _context.GraduateWorks.Any(e => e.Id == id);
        }
    }
}
