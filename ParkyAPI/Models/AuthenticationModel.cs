﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Models
{
    public class AuthenticationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
