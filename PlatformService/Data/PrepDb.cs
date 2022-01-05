using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var servicesScope = app.ApplicationServices.CreateScope())
            {
                SeedData(servicesScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                 Console.WriteLine("--> Seeding data... ");

                 context.Platforms.AddRange(
                    new Platform(){ Name="Dot Net", Publisher = "Microsoft", Cost ="Free" },
                    new Platform(){ Name="SQL Server Express", Publisher = "Microsoft", Cost ="Free" },
                    new Platform(){ Name="Kubernetes", Publisher = "Cloud Native Computing fundations", Cost ="Free" }
                 );

                 context.SaveChanges();

            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}