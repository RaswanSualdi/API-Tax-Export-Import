using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dto;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/pelabuhan")]
    public class HarborController : ControllerBase
    {
        private readonly HarborRepository _harborRepository;
        private readonly IMapper _mapper;

        public HarborController(HarborRepository harborRepository, IMapper mapper)
        {
            _harborRepository = harborRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetHarborByCountryAndName([FromQuery(Name = "kd_negara")] string countrycode,
            [FromQuery(Name = "ur_pelabuhan")] string harborName)
        {
            HarborDto response;
            if (string.IsNullOrWhiteSpace(countrycode) || string.IsNullOrWhiteSpace(harborName))
                return BadRequest("Kode negara dan nama pelabuhan harus diisi");
            
            var harbor = _harborRepository.GetHarborByCountryAndName(countrycode, harborName);
            response = _mapper.Map<HarborDto>(harbor);
            if (harbor == null)
                return NotFound($"Pelabuhan dengan nama '{harborName}' di negara dengan kode '{countrycode}' tidak ditemukan");
            return Ok(response);
        }
        
    }
}