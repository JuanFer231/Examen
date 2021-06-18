using Agenda_Pacientes.Data;
using Agenda_Pacientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pacientes.Controllers
{
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext db;

        public PacienteController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.Pacientes.ToListAsync());
            }

            return View(await db.Pacientes
                .Where(d => d.PacienteNombre.Contains(search))
                .ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacientes = await db.Pacientes.FirstOrDefaultAsync(d => d.PacienteId == id);

            if (pacientes == null)
            {
                return NotFound();
            }

            return View(pacientes);
        }


        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Add(paciente);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(paciente);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var paciente = await db.Pacientes.FindAsync(id);

            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Paciente paciente)
        {
            if (id != paciente.PacienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(paciente);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();

                }

                return RedirectToAction(nameof(Index));
            }

            return View(paciente);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await db.Pacientes.FirstOrDefaultAsync(d => d.PacienteId == id);

            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var pact = await db.Pacientes.FindAsync(id);
            db.Pacientes.Remove(pact);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
