namespace IT_Firm.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string? ProjectDeadline { get; set; }
        public string? ProjectDescription { get; set; }
        public int? ProjectDuration { get; set; }
        public Department? Department { get; set; }
    }
}
