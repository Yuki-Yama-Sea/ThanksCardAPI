using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomoyoseStore.Models;

namespace TomoyoseStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ReplyController(ApplicationContext context)
        {
            _context = context;
        }

        //PUT api/どういたしまして判定
        [HttpPut("{id}")]
        public async Task<IActionResult> Reply(int id, Card card)
        {
            if (id != card.Id)
            {
                return BadRequest();
            }

            _context.Entry(card).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(id))
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

        private bool CardExists(long id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}