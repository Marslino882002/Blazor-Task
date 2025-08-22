using Blazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Infrastructure.Persistence
{
    public class BlazorSolutionDbContext : DbContext    
    {

        public BlazorSolutionDbContext(DbContextOptions<BlazorSolutionDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlazorSolutionDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }






    }
}
