

using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Database;

public class WebApplication2Context : DbContext
{
    private readonly IConfiguration configuration;
    public DbSet<Country> Countries { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Harbor> Harbors { get; set; }
    public DbSet<Product> Products { get; set; }


    public WebApplication2Context(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("WebApplication2"));
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Country>().HasData(
            new Country { id = 1, name = "Indonesia", code = "ID" },
            new Country { id = 2, name = "Singapore", code = "SG" },
            new Country { id = 3, name = "Malaysia", code = "MY" },
            new Country { id = 4, name = "Thailand", code = "TH" },
            new Country { id = 5, name = "Vietnam", code = "VN" }
        );
        
        modelBuilder.Entity<Harbor>().HasData(
            new Harbor { id = 1, name = "Makassar", code = "MAK", countryId = 1 },
            new Harbor { id = 2, name = "Bitung", code = "BIT", countryId = 1 }, 
            new Harbor { id = 3, name = "Jurong", code = "JUR", countryId = 2 }, 
            new Harbor { id = 4, name = "Klang", code = "KLA", countryId = 3 }, 
            new Harbor { id = 5, name = "Bangkok", code = "BAN", countryId = 4 },
            new Harbor { id = 6, name = "Hai Phong", code = "HAI", countryId = 5 }
    
            
        );
        
        Product product1 = new Product { id = 1, name = "Product1",TransactionId = 1};
        Product product2 = new Product { id = 2, name = "Product2", TransactionId = 1};
        Product product3 = new Product { id = 3, name = "Product3", TransactionId = 2};
        Product product4 = new Product { id = 4, name = "Product4", TransactionId = 2};
        Product product5 = new Product { id = 5, name = "Product5", TransactionId = 3};
    
    
        modelBuilder.Entity<Product>().HasData(
            product1,
            product2,
            product3,
            product4,
            product5
        );
        
        modelBuilder.Entity<Transaction>().HasData(
            new Transaction { id = 1, code = "10079000", tariff = 10.0m, price = null, tariffPrice = null },
            new Transaction { id = 2, code = "10079001", tariff = 20.2m, price = null, tariffPrice = null},
            new Transaction { id = 3, code = "10079002", tariff = 30.0m, price = null, tariffPrice = null}
        );
    }

}

