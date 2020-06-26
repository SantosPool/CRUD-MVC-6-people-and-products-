using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaCorpSafe.Data;
using PruebaCorpSafe.Models;

namespace PruebaCorpSafe.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public JsonResult PopularSelect()
        {
            var lstMeses=Enum.GetValues(typeof(Meses))
                        .Cast<Meses>()
                        .Select(v => new { Id=v,Mes=v.ToString() })
                        .ToList();
            return Json(lstMeses);
        }
        public JsonResult SaveAndUpdatePersonabtn1(int Id, string Nombre, int Edad, bool Casado, int Mes, int Sexo)
        {
            var result = new jsonMessage();
            //define the model
            Persona per = new Persona();
            try
            {                
                per.Id = Id;
                per.Nombre = Nombre;
                per.Edad = Edad;
                per.Casado = Casado;
                per.Mes = Mes;
                per.Sexo = Sexo;
                //for insert recored..
                if (per.Id == 0)
                {
                     _context.Persona.Add(per);
                    result.Message = "your product has been saved success..";
                    result.Status = true;
                }
                else  //for update recored..
                {
                    _context.Entry(per).State = EntityState.Modified;
                    result.Message = "your product has been updated successfully..";
                    result.Status = true;
                }
                _context.SaveChanges();                
            }
            catch (Exception ex)
            {
                result.Message = "We are unable to process your request at this time. Please try again later.";
                result.Status = false;
            }
            return Json(per);
        }
        public async Task<JsonResult> SaveAndUpdatePersonabtn2(int Id, string Nombre, int Edad, bool Casado, int Mes, int Sexo)
        {
            var result = new jsonMessage();
            //define the model
            Persona per = new Persona();
            try
            {                
                per.Id = Id;
                per.Nombre = Nombre;
                per.Edad = Edad;
                per.Casado = Casado;
                per.Mes = Mes;
                per.Sexo = Sexo;
                //for insert recored..
                if (per.Id == 0)
                {
                    _context.Persona.Add(per);
                    result.Message = "your product has been saved success..";
                    result.Status = true;
                }
                else  //for update recored..
                {
                    _context.Entry(per).State = EntityState.Modified;
                    result.Message = "your product has been updated successfully..";
                    result.Status = true;
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Message = "We are unable to process your request at this time. Please try again later.";
                result.Status = false;
            }
            return Json(per);
        }
        public async Task<JsonResult> SaveAndUpdatePersonabtn3(Persona per)
        {
            var result = new jsonMessage();
            try
            {
                if (per.Id == 0)
                {
                    _context.Persona.Add(per);
                    result.Message = "your product has been saved success..";
                    result.Status = true;
                }
                else  //for update recored..
                {
                    _context.Entry(per).State = EntityState.Modified;
                    result.Message = "your product has been updated successfully..";
                    result.Status = true;
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Message = "We are unable to process your request at this time. Please try again later.";
                result.Status = false;
            }
            return Json(per);
        }
        // GET: Personas
        public async Task<IActionResult> PersonaForm()
        {
            return View(await _context.Persona.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .SingleOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Edad,Casado,Mes,Sexo")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PersonaForm));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona.SingleOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Edad,Casado,Mes,Sexo")] Persona persona)
        {
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PersonaForm));
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .SingleOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Persona.SingleOrDefaultAsync(m => m.Id == id);
            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PersonaForm));
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.Id == id);
        }
    }
}
