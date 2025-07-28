using Domain.Entities.Showtimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    internal class ShowtimeConfiguration : IEntityTypeConfiguration<Showtime>
    {
        public void Configure(EntityTypeBuilder<Showtime> builder)
        {
            builder.ToTable("Showtimes");


            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.IsFilled)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(x => x.ResearvedSeats)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasOne(x => x.Movie)
                .WithMany()
                .HasForeignKey(x => x.MovieId);

            builder.HasOne(x => x.Auditorium)
                .WithMany()
                .HasForeignKey(x => x.AuditoriumId);

            builder.HasMany(x => x.Tickets)
                .WithOne(x => x.Showtime);

        }
    }
}
