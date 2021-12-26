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
    
        public int Id { get; set; }
        public int EventId { get; set; }
        public string TagId { get; set; }

    /*    [ForeignKey(nameof(Event))]
        public virtual Event Event { get; set; }

        [ForeignKey(nameof(Tag))]
        [MaxLength(100)]
        public virtual Tag Tag { get; set; }*/
    }
}
