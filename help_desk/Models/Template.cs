using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class Template
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public int GroupId { get; set; }
        public Group TGroup { get; set; }

        public int CategoryId { get; set; }
        public TemplatesCategory TTemplatesCategory { get; set; }

         public Ticket TTicket { get; set; }
    }
}
