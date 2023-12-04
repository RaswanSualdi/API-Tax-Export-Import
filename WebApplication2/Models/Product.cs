namespace WebApplication2.Models;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; }
}