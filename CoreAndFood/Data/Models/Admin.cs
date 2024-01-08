﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CoreAndFood.Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(20)]
        public string AdminUserName { get; set; }
        [StringLength(20)]
        public string AdminPassword { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }

    }
}
