using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierres.Models
{
  public class PierresContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<ClassName> ClassName { get; set; }

    public PierresContext(DbContextOptions options) : base(options) { }
  }
}