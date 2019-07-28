using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class UsersGroup
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User UGUser { get; set; }

        public int GroupId { get; set; }
        public Group UGGroup { get; set; }
    }
}
