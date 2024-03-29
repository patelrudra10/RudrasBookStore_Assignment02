﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudrasBooks.Models
{
    public class CoverType
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Cover Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}