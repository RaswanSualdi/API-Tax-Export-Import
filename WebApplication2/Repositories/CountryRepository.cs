using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Database;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly WebApplication2Context _context;

        public CountryRepository(WebApplication2Context context)
        {
            _context = context;
        }

        public Country GetCountryById(int countryId)
        {
            return _context.Countries.Find(countryId);
        }

        public List<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }

        public async Task CreateCountryAsync(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
        }

        public Country GetCountryByCode(string countryCode)
        {
            return _context.Countries   
                .FirstOrDefault(c => c.code.ToUpper() == countryCode.ToUpper());
        }


        public Country GetCountryByPrefix(string countryPrefix)
        {
            return _context.Countries
                .FirstOrDefault(c => c.name.ToUpper().StartsWith(countryPrefix.ToUpper()));
        }
    }
}