namespace WebApplication2.Models;

public class Harbor
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public int countryId { get; set; }
    public Country country { get; set; }
    
}