using Microsoft.EntityFrameworkCore;

namespace PortlandBusiness.Models
{
  public class PortlandBusinessContext : DbContext
  {
    public PortlandBusinessContext(DbContextOptions<PortlandBusinessContext> options)
        : base(options)
      {
      }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
        .HasData(
          new Shop { ShopId = 1, Name = "Powells Books", Description = "Large Bookstore"},
          new Shop { ShopId = 2, Name = "Tender Loving Empire", Description = "Crafts and Records"},
          new Shop { ShopId = 3, Name = "Music Millenium", Description = "Portland's best record store"},
          new Shop { ShopId = 4, Name = "Floating World", Description = "Artsy Comic book shop"}
        );

        builder.Entity<Restaurant>()
        .HasData(
          new Restaurant { RestaurantId = 1, Name = "Ground Kontrol", Type = "Bar", Description = "Downtown Arcade Bar"},
          new Restaurant { RestaurantId = 2, Name = "Laurelhurst Market", Type = "Steakhouse", Description = "Restaurant and Deli providing fine meats"},
          new Restaurant { RestaurantId = 3, Name = "Soro Soro", Type = "Dessert", Description = "Korean desserts and coffee drinks"},
          new Restaurant { RestaurantId = 4, Name = "Breakside Brewery", Type = "Brewery", Description = "Delicious local Portland brewery"},
          new Restaurant { RestaurantId = 5, Name = "Miyamoto Sushi", Type = "Restaurant", Description = "Best Sushi in town"}
        );
    }
  }
}