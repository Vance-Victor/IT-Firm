namespace IT_Firm.Models
{
    public class Staff
    {
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffAddress { get; set; }
        public Department? Department { get; set; }
    }
}
