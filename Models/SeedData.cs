using Microsoft.EntityFrameworkCore;
using MVCSurvivalGame.Data;

namespace MVCSurvivalGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCSurvivalGameContext(serviceProvider.GetRequiredService<DbContextOptions<MVCSurvivalGameContext>>()))
            {
                if (context.Survivor.Any()) {
                    return;
                }
                context.Survivor.AddRange(
                    new Survivor
                    {
                        Forename = "Indiana",
                        Surname = "Jones",
                        Gender = "Male",
                        Age = 45,
                        isAlive = true
                    },
                    new Survivor
                    {
                        Forename = "Han",
                        Surname = "Solo",
                        Gender = "Male",
                        Age = 38,
                        isAlive = true
                    },
                    new Survivor
                    {
                        Forename = "Lara",
                        Surname = "Croft",
                        Gender = "Female",
                        Age = 32,
                        isAlive = true
                    },
                    new Survivor
                    {
                        Forename = "Michonne",
                        Surname = "Hawthorne",
                        Gender = "Female",
                        Age = 42,
                        isAlive = true
                    },
                    new Survivor
                    {
                        Forename = "Jon",
                        Surname = "Snow",
                        Gender = "Male",
                        Age = 35,
                        isAlive = true
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
