﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Organizer
    {
    /*    [Key]
        [ForeignKey(nameof(User))]
        public virtual User User { get; set; }*/
        public int UserId { get; set; }

        public string Passward { get; set; }
    }
}
