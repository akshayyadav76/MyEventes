using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class EventTag
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Event))]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [ForeignKey(nameof(Tag))]
        [MaxLength(100)]
        public string TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
