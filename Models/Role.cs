namespace IT_Firm.Models
{
    public class Role
    {
        public int? RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public string? RoleResponsibility { get; set; }
        public Project? Project { get; set; }
        public Staff? Staff { get; set; }
    }
}
