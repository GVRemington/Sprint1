using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace Sprint1.Models
{
    public class Project
    {
        
        public int ID { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public string CurrentVersion { get; set; }
        [Required]
        public string GitHubUrl { get; set; }

        //navigation property (used by Entity Framework to Connect Relationships)

        public ICollection<Ticket> Ticket { get; set; }

    }
}
