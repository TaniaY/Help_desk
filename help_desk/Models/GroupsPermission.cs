using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class GroupsPermission
    {
        [Key]
        public int Id { get; set; }

        public int PermissionId { get; set; }
        public Permission GPPermission { get; set; }

        public int GroupId { get; set; }
        public Group GPGroup { get; set; }
    }
}
