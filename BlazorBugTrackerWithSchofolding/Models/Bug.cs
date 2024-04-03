using System.ComponentModel.DataAnnotations;

namespace BlazorBugTrackerWithSchofolding.Models
{
    public class Bug : BaseIssue
    {
        [Required]
        public string Description { get; set; } = "";

        public string StepsToReproduce { get; set; } = "";
    }
}
