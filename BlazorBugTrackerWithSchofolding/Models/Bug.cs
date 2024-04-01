namespace BlazorBugTrackerWithSchofolding.Models
{
    public class Bug : BaseIssue
    {
        public string Description { get; set; } = "";
        public string StepsToReproduce { get; set; } = "";
    }
}
