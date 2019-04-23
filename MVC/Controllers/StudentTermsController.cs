using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class StudentTermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentTermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentTerms
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["StudentIDSortParm"] = String.IsNullOrEmpty(sortOrder) ? "studentID_desc" : "";
            ViewData["TermLabelSortParm"] = String.IsNullOrEmpty(sortOrder) ? "termLabel_desc" : "TermLabel";
            ViewData["TermIDSortParm"] = sortOrder == "TermId" ? "termID_desc" : "TermID";
            ViewData["currentFilter"] = searchString;

            var studentTerm = from s in _context.StudentTerms
                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentTerm = studentTerm.Where(s => s.StudentId.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "studentID_desc":
                    studentTerm = studentTerm.OrderByDescending(s => s.StudentId);
                    break;
                case "TermLabel":
                    studentTerm = studentTerm.OrderBy(s => s.TermLabel);
                    break;
                case "termLabel_desc":
                    studentTerm = studentTerm.OrderByDescending(s => s.TermLabel);
                    break;
                case "TermID":
                    studentTerm = studentTerm.OrderBy(s => s.TermId);
                    break;
                case "termID_desc":
                    studentTerm = studentTerm.OrderByDescending(s => s.TermId);
                    break;
                default:
                    studentTerm = studentTerm.OrderBy(s => s.StudentId);
                    break;
            }

            return View(await studentTerm.AsNoTracking().ToListAsync());
        }

        // GET: StudentTerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // GET: StudentTerms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentTermId,StudentId,TermId,TermLabel")] StudentTerm studentTerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentTerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentTerm);
        }

        // GET: StudentTerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms.FindAsync(id);
            if (studentTerm == null)
            {
                return NotFound();
            }
            return View(studentTerm);
        }

        // POST: StudentTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentTermId,StudentId,TermId,TermLabel")] StudentTerm studentTerm)
        {
            if (id != studentTerm.StudentTermId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentTerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentTermExists(studentTerm.StudentTermId))
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
            return View(studentTerm);
        }

        // GET: StudentTerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // POST: StudentTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentTerm = await _context.StudentTerms.FindAsync(id);
            _context.StudentTerms.Remove(studentTerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentTermExists(int id)
        {
            return _context.StudentTerms.Any(e => e.StudentTermId == id);
        }
    }
}
