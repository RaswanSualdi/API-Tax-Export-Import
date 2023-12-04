using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dto;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers;

[ApiController]
[Route("api/n/tarif")]
public class TransactionController : ControllerBase
{
    private readonly TransactionRepository _transactionRepository;
    private readonly IMapper _mapper;

    public TransactionController(TransactionRepository transactionRepository, IMapper mapper)
    {
        _transactionRepository = transactionRepository;
        _mapper = mapper;
    }   

    [HttpPost]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdatePriceAndFinalPrice([FromQuery(Name = "hs_code")] string hsCode, [FromBody] int price)
    {
        
        try
        {
            var transaction = await _transactionRepository.GetTransactionByHsCodeAsync(hsCode);
            if (transaction == null)
                return NotFound("Transaction not found");

            if (transaction.tariff.HasValue)
            {
                transaction.price = price;
                transaction.tariffPrice = CalculateFinalPrice(transaction.tariff.Value, price);
                await _transactionRepository.SaveChangesAsync();

                return Ok(transaction);
            }
            else
            {
                return BadRequest("Tariff is null. Cannot calculate final price.");
            }
        }
        catch (Exception ex)
        {
            return BadRequest($"Error: {ex.Message}");
        }
    }

    private long CalculateFinalPrice(decimal tariff, decimal price)
    {
        return (long)Math.Ceiling((tariff)/100 * price);
    }
}

