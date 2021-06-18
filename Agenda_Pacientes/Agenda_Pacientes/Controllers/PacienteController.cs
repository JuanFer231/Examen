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

        public async Task<IActionResult> Index()
        {
            return View(await db.Pacientes.ToListAsync());
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

    }
}
