﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class EventUser
    {
        
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }

/*        [ForeignKey(nameof(Event))]
        public virtual Event Event { get; set; }

        [ForeignKey(nameof(User))]
        public virtual User User { get; set; }*/
    }
}
