using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitasXWeb.Models;

namespace CitasXWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbUsuariosController : ControllerBase
    {
        private readonly CitasXContext _context;

        public TbUsuariosController(CitasXContext context)
        {
            _context = context;
        }

        // GET: api/TbUsuarios
        [HttpGet]
        public IEnumerable<TbUsuario> GetTbUsuario()
        {
            return _context.TbUsuario;
        }

        // GET: api/TbUsuarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTbUsuario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tbUsuario = await _context.TbUsuario.FindAsync(id);

            if (tbUsuario == null)
            {
                return NotFound();
            }

            return Ok(tbUsuario);
        }

        // PUT: api/TbUsuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbUsuario([FromRoute] int id, [FromBody] TbUsuario tbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbUsuario.UsuId)
            {
                return BadRequest();
            }

            _context.Entry(tbUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbUsuarioExists(id))
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

        // POST: api/TbUsuarios
        [HttpPost]
        public async Task<IActionResult> PostTbUsuario([FromBody] TbUsuario tbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TbUsuario.Add(tbUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbUsuario", new { id = tbUsuario.UsuId }, tbUsuario);
        }

        // DELETE: api/TbUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbUsuario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tbUsuario = await _context.TbUsuario.FindAsync(id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            _context.TbUsuario.Remove(tbUsuario);
            await _context.SaveChangesAsync();

            return Ok(tbUsuario);
        }

        private bool TbUsuarioExists(int id)
        {
            return _context.TbUsuario.Any(e => e.UsuId == id);
        }
    }
}