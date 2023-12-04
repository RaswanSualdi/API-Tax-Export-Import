namespace WebApplication2.Models;

public class Transaction
{
    public int id { get; set; }
    public string code { get; set; }
    public decimal? tariff { get; set; }
    public decimal? price { get; set; }
    public decimal? tariffPrice { get; set; }
    public ICollection<Product> Products { get; set; }
}