namespace WebApplication2.Models;

public class Country
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<Harbor> Harbors { get; set; }
}