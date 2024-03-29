﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class Invite
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Token { get; set; }

        public int DepartmentId { get; set; }
        public Department IDepartment { get; set; }

        public List<InvitesGroup> InvitesGroups { get; set; }
        public Invite()
        {
            InvitesGroups = new List<InvitesGroup>();
        }
    }
}
