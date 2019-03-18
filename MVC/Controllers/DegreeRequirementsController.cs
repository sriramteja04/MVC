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
    public class DegreeRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreeRequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreeRequirements
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            ViewData["DegreeIDSortParm"] = sortOrder == "DegreeID" ? "degreeId_desc" : "";
            ViewData["RequirementIDSortParm"] = sortOrder == "Requirement" ? "requirement_desc" : "Requirement";
            ViewData["currentFilter"] = searchString;

            var degreeRequirement = from s in _context.DegreeRequirements.Include(d => d.Degree).Include(d => d.Requirement)
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreeRequirement = degreeRequirement.Where(s => s.DegreeId == Convert.ToInt32(searchString));
            }

            switch (sortOrder)
            {
                case "degreeId_desc":
                    degreeRequirement = degreeRequirement.OrderByDescending(s => s.DegreeId);
                    break;
                case "Requirement":
                    degreeRequirement = degreeRequirement.OrderBy(s => s.RequirementId);
                    break;
                case "requirement_desc":
                    degreeRequirement = degreeRequirement.OrderByDescending(s => s.RequirementId);
                    break;
                default:
                    degreeRequirement = degreeRequirement.OrderBy(s => s.DegreeId);
                    break;
            }

            return View(await degreeRequirement.AsNoTracking().ToListAsync());
        }

        // GET: DegreeRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements
                .Include(d => d.Degree)
                .Include(d => d.Requirement)
                .FirstOrDefaultAsync(m => m.DegreeRequirementId == id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }

            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Create
        public IActionResult Create()
        {
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId");
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId");
            return View();
        }

        // POST: DegreeRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreeRequirementId,DegreeId,RequirementId")] DegreeRequirement degreeRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreeRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeRequirement.DegreeId);
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreeRequirement.RequirementId);
            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements.FindAsync(id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeRequirement.DegreeId);
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreeRequirement.RequirementId);
            return View(degreeRequirement);
        }

        // POST: DegreeRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreeRequirementId,DegreeId,RequirementId")] DegreeRequirement degreeRequirement)
        {
            if (id != degreeRequirement.DegreeRequirementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreeRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeRequirementExists(degreeRequirement.DegreeRequirementId))
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
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeRequirement.DegreeId);
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreeRequirement.RequirementId);
            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements
                .Include(d => d.Degree)
                .Include(d => d.Requirement)
                .FirstOrDefaultAsync(m => m.DegreeRequirementId == id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }

            return View(degreeRequirement);
        }

        // POST: DegreeRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreeRequirement = await _context.DegreeRequirements.FindAsync(id);
            _context.DegreeRequirements.Remove(degreeRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreeRequirementExists(int id)
        {
            return _context.DegreeRequirements.Any(e => e.DegreeRequirementId == id);
        }
    }
}
