namespace BlazorBugTrackerWithSchofolding.Models
{
    public class UserStory : BaseIssue
    {
        public int Points { get; set; }
        public string AsA { get; set; } = "";
        public string IWant { get; set; }  = "";
        public string SoThat { get; set; } = "";
        public string AcceptanceCriteria { get; set; } = "";
    }
}
