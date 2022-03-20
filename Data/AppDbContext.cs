using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext, IPlatform
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Platform> Platforms => Set<Platform>();

    }
    public interface IPlatform
    {
        DbSet<Platform> Platforms { get; }
    }
}