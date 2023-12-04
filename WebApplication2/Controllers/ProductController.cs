using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication2.Dto;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/n/barang")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(ProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetProductsByTransactionCode([FromQuery(Name = "hs_code")] string transactionCode="")
        {
            List<ProductDto> productsByTransactionCodes;
            if (string.IsNullOrWhiteSpace(transactionCode))
            {
                // return BadRequest("Parameter hs_code harus diisi.");
                var country = _productRepository.GetAllProducts();
                productsByTransactionCodes = _mapper.Map<List<ProductDto>>(country);
                return Ok(productsByTransactionCodes);
            }

            var productsByTransactionCode = _productRepository.GetProductsByTransactionCode(transactionCode);
            productsByTransactionCodes = _mapper.Map<List<ProductDto>>(productsByTransactionCode);

            if (productsByTransactionCode.Count == 0)
            {
                return NotFound($"Tidak ada produk yang terkait dengan transaksi code {transactionCode}.");
            }

            return Ok(productsByTransactionCodes);
        }

    

    }
}