using Microsoft.EntityFrameworkCore;
using Ticket_Management_System.Models;

namespace Ticket_Management_System.Data
{
    public class TicketManagementSystemContext : DbContext
    {
        public TicketManagementSystemContext(DbContextOptions<TicketManagementSystemContext> options): base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

    }

}