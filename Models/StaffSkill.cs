namespace IT_Firm.Models
{
    public class StaffSkill
    {
        public int? StaffSkillID { get; set; }
        public string? StaffSkillName { get; set; }
        public Staff? Staff { get; set; }
        public Skill? Skill { get; set; }
    }
}
