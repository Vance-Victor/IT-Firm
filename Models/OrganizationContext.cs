using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IT_Firm.Models
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffSkill> StaffSkill{ get; set; }
        public DbSet<Role> Role{ get; set; }
    }
}
