using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TomoyoseStore.Models;

namespace TomoyoseStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SendController(ApplicationContext context)
        {
            _context = context;
        }

        // POST api/Send
        [HttpPost]
        public async Task<ActionResult<Card>> Postcard(Card card)
        {

            if(card.Date==null)
            {
                return BadRequest();
            }

            if(card.Text==null || card.Text.Length>100)
            {
                return BadRequest();
            }

            if (card.To == null)
            {
                return BadRequest();
            }

            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}