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
  }
}