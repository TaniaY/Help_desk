using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public int DepartmentId { get; set; }
        

        public List<UsersGroup> UsersGroups { get; set; }
        public User()
        {
            UsersGroups = new List<UsersGroup>();
        }

        [InverseProperty("Author")]
        public List<Ticket> Tickets { get; set; }
        [InverseProperty("Assignee")]
        public Ticket AssigneeTicket { get; set; }
    }
}
