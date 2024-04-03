using System.ComponentModel.DataAnnotations;

namespace BlazorBugTrackerWithSchofolding.Models
{
    public class Defect : BaseIssue
    {
        [Required]
        [MaxLength(50)]
        public string Company { get; set; } = "";

        [Required]
        [MaxLength(50)]
        public string Environment { get; set; } = "";

        [Required]
        [AllowedValues("1.0", "1.1", "2.0")]
        public string FoundInVersion { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        public string StepsToReproduce { get; set; } = "";
    }
}
