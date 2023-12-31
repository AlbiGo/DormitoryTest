﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Dormitory
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
    }
}
