using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IT_Firm.Models;

namespace IT_Firm.Controllers
{
    public class StaffSkillsController : Controller
    {
        private readonly OrganizationContext _context;

        public StaffSkillsController(OrganizationContext context)
        {
            _context = context;
        }

        // GET: StaffSkills
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffSkill.ToListAsync());
        }

        // GET: StaffSkills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffSkill = await _context.StaffSkill
                .FirstOrDefaultAsync(m => m.StaffSkillID == id);
            if (staffSkill == null)
            {
                return NotFound();
            }

            return View(staffSkill);
        }

        // GET: StaffSkills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StaffSkills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffSkillID,StaffSkillName")] StaffSkill staffSkill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffSkill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffSkill);
        }

        // GET: StaffSkills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffSkill = await _context.StaffSkill.FindAsync(id);
            if (staffSkill == null)
            {
                return NotFound();
            }
            return View(staffSkill);
        }

        // POST: StaffSkills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("StaffSkillID,StaffSkillName")] StaffSkill staffSkill)
        {
            if (id != staffSkill.StaffSkillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffSkill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffSkillExists(staffSkill.StaffSkillID))
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
            return View(staffSkill);
        }

        // GET: StaffSkills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffSkill = await _context.StaffSkill
                .FirstOrDefaultAsync(m => m.StaffSkillID == id);
            if (staffSkill == null)
            {
                return NotFound();
            }

            return View(staffSkill);
        }

        // POST: StaffSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var staffSkill = await _context.StaffSkill.FindAsync(id);
            if (staffSkill != null)
            {
                _context.StaffSkill.Remove(staffSkill);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffSkillExists(int? id)
        {
            return _context.StaffSkill.Any(e => e.StaffSkillID == id);
        }
    }
}
