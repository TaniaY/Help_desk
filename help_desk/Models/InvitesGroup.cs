using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class InvitesGroup
    {
        [Key]
        public int Id { get; set; }

        public int InviteId { get; set; }
        public Invite IInvite { get; set; }

        public int GroupId { get; set; }
        public Group IGroup { get; set; }
    }
}
