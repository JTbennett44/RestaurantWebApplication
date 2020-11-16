using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantWebApplication.Models;

namespace RestaurantWebApplication.Controllers
{
    public class TablesController : Controller
    {
        private readonly RestaurantManagementDBContext _context;

        public TablesController(RestaurantManagementDBContext context)
        {
            _context = context;
        }

        // GET: Tables
        public async Task<IActionResult> Index()
        {
            var restaurantManagementDBContext = _context.Tables.Include(t => t.WaitStaffNavigation);
            return View(await restaurantManagementDBContext.ToListAsync());
        }

        // GET: Tables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tables = await _context.Tables
                .Include(t => t.WaitStaffNavigation)
                .FirstOrDefaultAsync(m => m.TablesID == id);
            if (tables == null)
            {
                return NotFound();
            }

            return View(tables);
        }

        // GET: Tables/Create
        public IActionResult Create()
        {
            ViewData["WaitStaff"] = new SelectList(_context.Staff, "StaffId", "FullName");
            return View();
        }

        // POST: Tables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TablesID,Number,Status,WaitStaff")] Tables tables)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tables);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WaitStaff"] = new SelectList(_context.Staff, "StaffId", "FullName", tables.WaitStaff);
            return View(tables);
        }

        // GET: Tables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tables = await _context.Tables.FindAsync(id);
            if (tables == null)
            {
                return NotFound();
            }
            ViewData["WaitStaff"] = new SelectList(_context.Staff, "StaffId", "FullName", tables.WaitStaff);
            return View(tables);
        }

        // POST: Tables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TablesID,Number,Status,WaitStaff")] Tables tables)
        {
            if (id != tables.TablesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tables);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TablesExists(tables.TablesID))
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
            ViewData["WaitStaff"] = new SelectList(_context.Staff, "StaffId", "FullName", tables.WaitStaff);
            return View(tables);
        }

        // GET: Tables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tables = await _context.Tables
                .Include(t => t.WaitStaffNavigation)
                .FirstOrDefaultAsync(m => m.TablesID == id);
            if (tables == null)
            {
                return NotFound();
            }

            return View(tables);
        }

        // POST: Tables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tables = await _context.Tables.FindAsync(id);
            _context.Tables.Remove(tables);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TablesExists(int id)
        {
            return _context.Tables.Any(e => e.TablesID == id);
        }
    }
}
