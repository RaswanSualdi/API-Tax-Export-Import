using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dto;
using WebApplication2.Interfaces;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/n/negara")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryController(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetCountries([FromQuery(Name = "ur_negara")] string countryPrefix = "")
        {
            List<CountryDto> countries;

            if (string.IsNullOrWhiteSpace(countryPrefix))
            {
                var country = _countryRepository.GetAllCountries();
                countries = _mapper.Map<List<CountryDto>>(country);
            }
            else
            {
                var country = _countryRepository.GetCountryByPrefix(countryPrefix);
                if (country == null)
                    return NotFound();

                countries = new List<CountryDto> { _mapper.Map<CountryDto>(country) };
            }

            return Ok(countries);
        }
        
        
    }
}