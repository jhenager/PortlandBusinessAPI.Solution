using Microsoft.EntityFrameworkCore;

namespace PortlandBusiness.Models
{
  public class PortlandBusinessContext : DbContext
  {
    public PortlandBusinessContext(DbContextOptions<PortlandBusinessContext> options)
        : base(options)
      {
      }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Powells Books", Type = "Retail", Description = "Large Bookstore"},
          new Business { BusinessId = 2, Name = "Ground Kontrol", Type = "Bar", Description = "Downtown Arcade Bar"},
          new Business { BusinessId = 3, Name = "Laurelhurst Market", Type = "Restaurant", Description = "Restaurant and Deli providing fine meats"},
          new Business { BusinessId = 4, Name = "Soro Soro", Type = "Cafe", Description = "Korean desserts and coffee drinks"},
          new Business { BusinessId = 5, Name = "Mississippi Studios", Type = "Venue", Description = "Small live music venue"},
          new Business { BusinessId = 6, Name = "Breakside Brewery", Type = "Brewery", Description = "Delicious local Portland brewery"},
          new Business { BusinessId = 7, Name = "Miyamoto Sushi", Type = "Restaurant", Description = "Best Sushi in town"}
        );
    }
  }
}