using Microsoft.EntityFrameworkCore;
using standBY_prototype.Models;

namespace standBY_prototype.DataAccess
{
  public class DataContext : DbContext
  {
    public DbSet<Cliente> Clientes { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  }
}