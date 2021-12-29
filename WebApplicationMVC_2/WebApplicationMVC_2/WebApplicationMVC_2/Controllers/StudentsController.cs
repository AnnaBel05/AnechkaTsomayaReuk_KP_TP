﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly UniversityContext _context;

        public StudentsController(UniversityContext context)
        {
            _context = context;
        }

        // GET: Students        
        public async Task<IActionResult> Index()
        {
            var universityContext = _context.Students.Include(s => s.Group).
                                                      Include(s => s.ScholarshipType).
                                                      Include(s => s.EducationalForm).
                                                      Include(s => s.TrainingType);
            return View(await universityContext.ToListAsync());
        }
        
        // GET: Students/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.Include(s => s.Group).
                                                  Include(s => s.ScholarshipType).
                                                  Include(s => s.EducationalForm).
                                                  Include(s => s.TrainingType).
                                                  FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name");
            ViewData["ScholarshipTypeId"] = new SelectList(_context.ScholarshipTypes, "Id", "Name");
            ViewData["TrainingTypeId"] = new SelectList(_context.TrainingTypes, "Id", "Name");
            ViewData["EducationalFormId"] = new SelectList(_context.EducationalForms, "Id", "Name");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastName,FirstName,MiddleName,BirthDate,PhoneNumber,CreditCardNumber,ScholarshipAmount,EducationalFormId,GroupId,TrainingTypeId,ScholarshipTypeId")] Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = Guid.NewGuid();
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", student.GroupId);
            ViewData["ScholarshipTypeId"] = new SelectList(_context.ScholarshipTypes, "Id", "Name", student.ScholarshipTypeId);
            return View(student);
        }

        // GET: Students/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            //string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            //return Content($"ваша роль: {role}");
            
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", student.GroupId);
            ViewData["ScholarshipTypeId"] = new SelectList(_context.ScholarshipTypes, "Id", "Name", student.ScholarshipTypeId);
            ViewData["TrainingTypeId"] = new SelectList(_context.TrainingTypes, "Id", "Name", student.TrainingTypeId);
            ViewData["EducationalFormId"] = new SelectList(_context.EducationalForms, "Id", "Name", student.EducationalFormId);

            return View(student);
            
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,LastName,FirstName,MiddleName,BirthDate,PhoneNumber,CreditCardNumber,ScholarshipAmount,EducationalFormId,GroupId,TrainingTypeId,ScholarshipTypeId")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", student.GroupId);
            ViewData["ScholarshipTypeId"] = new SelectList(_context.ScholarshipTypes, "Id", "Id", student.ScholarshipTypeId);
            return View(student);
        }

        // GET: Students/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Group)
                .Include(s => s.ScholarshipType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(Guid id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}