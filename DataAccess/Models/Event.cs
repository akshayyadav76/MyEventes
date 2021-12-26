using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePlanned { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        public int? MaxParticipants { get; set; }
        public int? MinAge { get; set; }
        public int LocationId { get; set; }
        public int OrganizerId { get; set; }

 /*       [ForeignKey(nameof(Location))]
        public virtual Location Location { get; set; }

        [ForeignKey(nameof(Organizer))]
        public virtual Organizer Organizer { get; set; }*/
    }
}
