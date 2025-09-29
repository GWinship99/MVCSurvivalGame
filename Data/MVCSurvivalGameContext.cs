using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCSurvivalGame.Models;

namespace MVCSurvivalGame.Data
{
    public class MVCSurvivalGameContext : DbContext
    {
        public MVCSurvivalGameContext (DbContextOptions<MVCSurvivalGameContext> options)
            : base(options)
        {
        }

        public DbSet<MVCSurvivalGame.Models.Survivor> Survivor { get; set; } = default!;
    }
}
