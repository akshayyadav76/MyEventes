using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class City
    {
        [Key]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
