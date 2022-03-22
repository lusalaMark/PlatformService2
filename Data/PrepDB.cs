using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                //var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }

        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.Write("--> seeding data");

                context.Platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publisher = "", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publisher = "", Cost = "Free" }
                );
                context.SaveChanges();
            }

            else
            {
                Console.Write("--> We already have data");
            }

        }
    }


}