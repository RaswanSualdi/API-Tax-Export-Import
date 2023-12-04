using Microsoft.EntityFrameworkCore;
using WebApplication2.Database;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class HarborRepository
    {
        private readonly WebApplication2Context _context;

        public HarborRepository(WebApplication2Context context)
        {
            _context = context;
        }

        // public async Task<Harbor> GetHarborByIdAsync(int harborId)
        // {
        //     return await _context.Harbors.FindAsync(harborId);
        // }
        //
        // public async Task<List<Harbor>> GetAllHarborsAsync()
        // {
        //     return await _context.Harbors.ToListAsync();
        // }
        //
        // public async Task CreateHarborAsync(Harbor harbor)
        // {
        //     _context.Harbors.Add(harbor);
        //     await _context.SaveChangesAsync();
        // }
        
        public Harbor GetHarborByCountryAndName(string countryCode, string harborName)
        {
            return _context.Harbors
                .FirstOrDefault(h => h.country.code == countryCode && h.code.ToUpper().Equals(harborName.ToUpper()));
        }
        
    }
}