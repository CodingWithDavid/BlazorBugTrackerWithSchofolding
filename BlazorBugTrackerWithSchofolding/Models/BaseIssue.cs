namespace BlazorBugTrackerWithSchofolding.Models
{
    public class BaseIssue
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Reporter { get; set; } = "";
        public string AssignedTo { get; set; } = "";
        public string Priority { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
