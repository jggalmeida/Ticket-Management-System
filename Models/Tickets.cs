using System;
using System.ComponentModel.DataAnnotations;

namespace Ticket_Management_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EnteredOn { get; set; }
        public string Email { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }

}
