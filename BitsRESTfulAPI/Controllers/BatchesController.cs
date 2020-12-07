﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BitsBrewers.Models;

namespace BitsRESTfulAPI.Controllers
{
    //auto generated; I never successfully seached recipes by name I did nothing here//
    public class BatchesController : Controller
    {
        private readonly BitsContext _context;

        public BatchesController(BitsContext context)
        {
            _context = context;
        }

        // GET: Batches
        public async Task<IActionResult> Index()
        {
            var bitsContext = _context.Batch.Include(b => b.Equipment).Include(b => b.Recipe);
            return View(await bitsContext.ToListAsync());
        }

        // GET: Batches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batch = await _context.Batch
                .Include(b => b.Equipment)
                .Include(b => b.Recipe)
                .FirstOrDefaultAsync(m => m.BatchId == id);
            if (batch == null)
            {
                return NotFound();
            }

            return View(batch);
        }

        // GET: Batches/Create
        public IActionResult Create()
        {
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Name");
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "RecipeId", "Brewer");
            return View();
        }

        // POST: Batches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BatchId,RecipeId,EquipmentId,Volume,ScheduledStartDate,StartDate,EstimatedFinishDate,FinishDate,UnitCost,Notes,TasteNotes,TasteRating,Og,Fg,Carbonation,FermentationStages,PrimaryAge,PrimaryTemp,SecondaryAge,SecondaryTemp,TertiaryAge,Age,Temp,Ibu,IbuMethod,Abv,ActualEfficiency,Calories,CarbonationUsed,ForcedCarbonation,KegPrimingFactor,CarbonationTemp")] Batch batch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(batch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Name", batch.EquipmentId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "RecipeId", "Brewer", batch.RecipeId);
            return View(batch);
        }

        // GET: Batches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batch = await _context.Batch.FindAsync(id);
            if (batch == null)
            {
                return NotFound();
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Name", batch.EquipmentId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "RecipeId", "Brewer", batch.RecipeId);
            return View(batch);
        }

        // POST: Batches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BatchId,RecipeId,EquipmentId,Volume,ScheduledStartDate,StartDate,EstimatedFinishDate,FinishDate,UnitCost,Notes,TasteNotes,TasteRating,Og,Fg,Carbonation,FermentationStages,PrimaryAge,PrimaryTemp,SecondaryAge,SecondaryTemp,TertiaryAge,Age,Temp,Ibu,IbuMethod,Abv,ActualEfficiency,Calories,CarbonationUsed,ForcedCarbonation,KegPrimingFactor,CarbonationTemp")] Batch batch)
        {
            if (id != batch.BatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(batch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BatchExists(batch.BatchId))
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
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Name", batch.EquipmentId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "RecipeId", "Brewer", batch.RecipeId);
            return View(batch);
        }

        // GET: Batches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var batch = await _context.Batch
                .Include(b => b.Equipment)
                .Include(b => b.Recipe)
                .FirstOrDefaultAsync(m => m.BatchId == id);
            if (batch == null)
            {
                return NotFound();
            }

            return View(batch);
        }

        // POST: Batches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var batch = await _context.Batch.FindAsync(id);
            _context.Batch.Remove(batch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BatchExists(int id)
        {
            return _context.Batch.Any(e => e.BatchId == id);
        }
    }
}
