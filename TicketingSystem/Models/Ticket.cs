using System.ComponentModel.DataAnnotations;
namespace TicketingSystem.Models
{
    public class Ticket
    {
        [Key] 
        public int ID { get; set; }
        public string Issue { get; set; }
        public string Description { get; set; }
    }
}