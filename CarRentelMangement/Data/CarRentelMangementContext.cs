using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentelMangement.Domain;
using CarRentelMangement.Configuration.Entities;

namespace CarRentelMangement.Data
{
    public class CarRentelMangementContext : DbContext
    {
        public CarRentelMangementContext (DbContextOptions<CarRentelMangementContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentelMangement.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentelMangement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentelMangement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentelMangement.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentelMangement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentelMangement.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());

            builder.ApplyConfiguration(new MakeSeed());

            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
