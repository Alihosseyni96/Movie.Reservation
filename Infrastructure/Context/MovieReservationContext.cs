using Domain.Entities.Auditoriums;
using Domain.Entities.Movies;
using Domain.Entities.Showtimes;
using Domain.Entities.Tickets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class MovieReservationContext : DbContext
    {

        public MovieReservationContext(DbContextOptions<MovieReservationContext> options) : base(options) 
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Auditorium> Auditoria { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieReservationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
