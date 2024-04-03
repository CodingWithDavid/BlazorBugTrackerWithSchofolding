using System.ComponentModel.DataAnnotations;

namespace BlazorBugTrackerWithSchofolding.Models
{
    public class UserStory : BaseIssue
    {
        [Range(1,21)]
        public int Points { get; set; }

        [Required]
        [MaxLength(50)]
        public string AsA { get; set; } = "";

        [Required]
        [MaxLength(50)]
        public string IWant { get; set; }  = "";

        [Required]
        [MaxLength(250)]
        public string SoThat { get; set; } = "";

        public string AcceptanceCriteria { get; set; } = "";
    }
}
