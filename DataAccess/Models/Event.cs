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
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        public DateTime DatePlanned { get; set; }
        public string? Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="Enter value grater than 0")]
        public int? MaxParticipants { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Enter value grater than 0")]
        public int? MinAge { get; set; }

        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}
