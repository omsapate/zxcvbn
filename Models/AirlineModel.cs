using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Airline.Models
{
    public partial class AirlineModel : DbContext
    {
        public AirlineModel()
            : base("name=AirlineModel")
        {
        }

        public virtual DbSet<AirlineTable> AirlineTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.Flight_Company)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.Origin)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.DepartureTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.Destination)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.ArrivalTime)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineTable>()
                .Property(e => e.FlightNo)
                .IsUnicode(false);
        }
    }
}
