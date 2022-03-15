namespace Airline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AirlineTable")]
    public partial class AirlineTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Flight_Company { get; set; }

        [Required]
        [StringLength(50)]
        public string Origin { get; set; }

        [Column(TypeName = "date")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [StringLength(10)]
        public string DepartureTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Destination { get; set; }

        [Column(TypeName = "date")]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [StringLength(10)]
        public string ArrivalTime { get; set; }

        [Required]
        [StringLength(20)]
        public string FlightNo { get; set; }

        public long Price { get; set; }
    }
}
