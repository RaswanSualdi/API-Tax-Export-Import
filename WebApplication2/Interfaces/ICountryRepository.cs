using WebApplication2.Models;

namespace WebApplication2.Interfaces;

public interface ICountryRepository
{
    Country GetCountryById(int countryId);
    List<Country> GetAllCountries();
    Task CreateCountryAsync(Country country);
    Country GetCountryByCode(string countryCode);
    Country GetCountryByPrefix(string countryPrefix);
}