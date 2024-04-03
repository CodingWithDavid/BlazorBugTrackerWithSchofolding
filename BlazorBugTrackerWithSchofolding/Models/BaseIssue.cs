using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlazorBugTrackerWithSchofolding.Models
{
    public class BaseIssue
    {
        [Editable(false)]
        [ReadOnly(true)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Reporter { get; set; } = "";

        [Required]
        [MaxLength(50)]
        public string AssignedTo { get; set; } = "";

        [AllowedValues("High", "Medium", "Low")]
        [Required]
        public string Priority { get; set; } = "";

        [AllowedValues("New", "Open", "Blocked", "Testing", "Closed")]
        [Required]
        public string Status { get; set; } = "";
    }
}
