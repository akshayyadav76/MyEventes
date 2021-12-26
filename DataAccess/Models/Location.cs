using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(300)]
        public string? Title { get; set; }
        [MaxLength(300)]
        public string? Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string HouseNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [ForeignKey(nameof(City))]
        [MaxLength(100)]
        public string CityName { get; set; }
        public virtual City City { get; set; }
    }
}
