using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaralCashFlowAPI.Models;

namespace SaralCashFlowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCashDetailsController : ControllerBase
    {
        private readonly SaralCashFlowDBContext _context;

        public SubCashDetailsController(SaralCashFlowDBContext context)
        {
            _context = context;
        }

        // GET: api/SubCashDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCashDetails>>> GetSubCashDetails()
        {
            return await _context.SubCashDetails.ToListAsync();
        }

        // GET: api/SubCashDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCashDetails>> GetSubCashDetails(int id)
        {
            var subCashDetails = await _context.SubCashDetails.FindAsync(id);

            if (subCashDetails == null)
            {
                return NotFound();
            }

            return subCashDetails;
        }

        // PUT: api/SubCashDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCashDetails(int id, SubCashDetails subCashDetails)
        {
            if (id != subCashDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(subCashDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCashDetailsExists(id))
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

        // POST: api/SubCashDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubCashDetails>> PostSubCashDetails(SubCashDetails subCashDetails)
        {
            _context.SubCashDetails.Add(subCashDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubCashDetails", new { id = subCashDetails.Id }, subCashDetails);
        }

        // DELETE: api/SubCashDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubCashDetails(int id)
        {
            var subCashDetails = await _context.SubCashDetails.FindAsync(id);
            if (subCashDetails == null)
            {
                return NotFound();
            }

            _context.SubCashDetails.Remove(subCashDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubCashDetailsExists(int id)
        {
            return _context.SubCashDetails.Any(e => e.Id == id);
        }
    }
}
