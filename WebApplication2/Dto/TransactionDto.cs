using WebApplication2.Models;

namespace WebApplication2.Dto;

public class TransactionDto
{
    public int id { get; set; }
    public string code { get; set; }
    public decimal tariff { get; set; }
    public long price { get; set; }
    public long tariffPrice { get; set; }
    public ICollection<Product> Products { get; set; }
}