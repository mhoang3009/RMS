using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RMS.Data;
using RMS.Models;

namespace RMS.Controllers
{
    public class MonAnController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MonAnController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MonAn
        public async Task<IActionResult> Index()
        {
            return View(await _context.MonAn.ToListAsync());
        }

        // GET: MonAn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monAn = await _context.MonAn
                .FirstOrDefaultAsync(m => m.MonAnId == id);
            if (monAn == null)
            {
                return NotFound();
            }

            return View(monAn);
        }

        // GET: MonAn/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MonAn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MonAnId,TenMonAn,MoTa,Gia,HinhAnh,DanhMuc")] MonAn monAn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monAn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monAn);
        }

        // GET: MonAn/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monAn = await _context.MonAn.FindAsync(id);
            if (monAn == null)
            {
                return NotFound();
            }
            return View(monAn);
        }

        // POST: MonAn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MonAnId,TenMonAn,MoTa,Gia,HinhAnh,DanhMuc")] MonAn monAn)
        {
            if (id != monAn.MonAnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monAn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonAnExists(monAn.MonAnId))
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
            return View(monAn);
        }

        // GET: MonAn/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monAn = await _context.MonAn
                .FirstOrDefaultAsync(m => m.MonAnId == id);
            if (monAn == null)
            {
                return NotFound();
            }

            return View(monAn);
        }

        // POST: MonAn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monAn = await _context.MonAn.FindAsync(id);
            if (monAn != null)
            {
                _context.MonAn.Remove(monAn);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonAnExists(int id)
        {
            return _context.MonAn.Any(e => e.MonAnId == id);
        }
    }
}
