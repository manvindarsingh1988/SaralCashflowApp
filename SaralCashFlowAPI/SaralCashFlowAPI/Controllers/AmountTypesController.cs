using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaralCashFlowAPI.Models;

namespace SaralCashFlowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmountTypesController : ControllerBase
    {
        private readonly SaralCashFlowDBContext _context;

        public AmountTypesController(SaralCashFlowDBContext context)
        {
            _context = context;
        }

        // GET: api/AmountTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmountType>>> GetAmountTypes()
        {
            return await _context.AmountTypes.ToListAsync();
        }

        // GET: api/AmountTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmountType>> GetAmountType(int id)
        {
            var amountType = await _context.AmountTypes.FindAsync(id);

            if (amountType == null)
            {
                return NotFound();
            }

            return amountType;
        }

        // PUT: api/AmountTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmountType(int id, AmountType amountType)
        {
            if (id != amountType.Id)
            {
                return BadRequest();
            }

            _context.Entry(amountType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmountTypeExists(id))
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

        // POST: api/AmountTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AmountType>> PostAmountType(AmountType amountType)
        {
            _context.AmountTypes.Add(amountType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmountType", new { id = amountType.Id }, amountType);
        }

        // DELETE: api/AmountTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmountType(int id)
        {
            var amountType = await _context.AmountTypes.FindAsync(id);
            if (amountType == null)
            {
                return NotFound();
            }

            _context.AmountTypes.Remove(amountType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmountTypeExists(int id)
        {
            return _context.AmountTypes.Any(e => e.Id == id);
        }
    }
}
