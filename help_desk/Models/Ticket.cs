using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int StatusId { get; set; }
       public Statuse Tstatuse { get; set; }

        public int AssigneeId { get; set; }
        public User Assignee { get; set; }

        public int PriorityId { get; set; }
        public Priority Tpriority { get; set; }

        public int TemplateId { get; set; }
        public Template Ttemplate { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
