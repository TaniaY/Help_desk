using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TicketId { get; set; }

        public Ticket Cticket { get; set; }

        public Attachment Cattachment { get; set; }
    }
}
