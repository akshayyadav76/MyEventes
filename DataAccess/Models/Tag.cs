using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Tag
    {
        [Key]
        [MaxLength(100)]
        public string TagName {get;set;}
    }
}
