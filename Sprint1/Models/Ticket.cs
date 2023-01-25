using System.ComponentModel.DataAnnotations;

namespace Sprint1.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public ETicketStatus Status { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
        [Required]
        public DateTime DateModified { get; set; }
    }

    public enum ETicketStatus
    {
        New = 0,
        ClosedComplete = 1,
        ClosedIgnored = 2

    }
}
