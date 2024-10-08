using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Desafio3.Models;
using Desafio3_DM201736_DV201086_PC191777.Models;
using Microsoft.AspNetCore.Authorization;

namespace Desafio3_DM201736_DV201086_PC191777.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreparacionController : ControllerBase
    {
        private readonly RecetaDBContext _context;

        public PreparacionController(RecetaDBContext context)
        {
            _context = context;
        }

        // GET: api/Preparacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Preparacion>>> GetPreparaciones()
        {
            return await _context.Preparaciones.Include(x => x.Receta).ToListAsync();
           // return await _context.Preparaciones.ToListAsync();
        }

        // GET: api/Preparacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Preparacion>> GetPreparacion(int id)
        {
            var preparacion = await _context.Preparaciones.FindAsync(id);

            if (preparacion == null)
            {
                return NotFound();
            }

            return preparacion;
        }

        // PUT: api/Preparacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreparacion(int id, Preparacion preparacion)
        {
            if (id != preparacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(preparacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreparacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Preparacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Preparacion>> PostPreparacion(Preparacion preparacion)
        {
            _context.Preparaciones.Add(preparacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPreparacion", new { id = preparacion.Id }, preparacion);
        }

        // DELETE: api/Preparacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreparacion(int id)
        {
            var preparacion = await _context.Preparaciones.FindAsync(id);
            if (preparacion == null)
            {
                return NotFound();
            }

            _context.Preparaciones.Remove(preparacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PreparacionExists(int id)
        {
            return _context.Preparaciones.Any(e => e.Id == id);
        }
    }
}
