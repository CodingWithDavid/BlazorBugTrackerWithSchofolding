namespace BlazorBugTrackerWithSchofolding.Models
{
    public class Defect : Bug
    {
        public string Company { get; set; } = "";
        public string Environment { get; set; } = "";
        public string FoundInVersion { get; set; } = "";
    }
}
