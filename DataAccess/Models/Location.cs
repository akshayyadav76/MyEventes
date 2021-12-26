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

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }

 /*       [ForeignKey(nameof(City))]
        [MaxLength(100)]
        public virtual City City { get; set; }*/
    }
}
