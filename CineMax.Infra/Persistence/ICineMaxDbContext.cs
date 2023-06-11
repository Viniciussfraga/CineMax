﻿using CineMax.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CineMax.Infra.Persistence
{
    public class ICineMaxDbContext : DbContext
    {
        public ICineMaxDbContext(DbContextOptions<ICineMaxDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
