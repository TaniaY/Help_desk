﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Slug { get; set; }

        public int CompanyId { get; set; }
        public Company DCompany { get; set; }

        public List<Invite> DInvite { get; set; }

        public User DUser { get; set; }
    }
}
