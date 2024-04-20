using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaralCashFlowAPI.Models;

namespace SaralCashFlowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashDetailsController : ControllerBase
    {
        private readonly SaralCashFlowDBContext _context;

        public CashDetailsController(SaralCashFlowDBContext context)
        {
            _context = context;
        }

        // GET: api/CashDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CashDetail>>> GetCashDetails()
        {
            return await _context.CashDetails.ToListAsync();
        }

        // GET: api/CashDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CashDetail>> GetCashDetail(int id)
        {
            var cashDetail = await _context.CashDetails.FindAsync(id);

            if (cashDetail == null)
            {
                return NotFound();
            }

            return cashDetail;
        }

        // PUT: api/CashDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCashDetail(int id, CashDetail cashDetail)
        {
            if (id != cashDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(cashDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CashDetailExists(id))
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

        // POST: api/CashDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CashDetail>> PostCashDetail(CashDetail cashDetail)
        {
            _context.CashDetails.Add(cashDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashDetail", new { id = cashDetail.Id }, cashDetail);
        }

        // DELETE: api/CashDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCashDetail(int id)
        {
            var cashDetail = await _context.CashDetails.FindAsync(id);
            if (cashDetail == null)
            {
                return NotFound();
            }

            _context.CashDetails.Remove(cashDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CashDetailExists(int id)
        {
            return _context.CashDetails.Any(e => e.Id == id);
        }
    }
}
