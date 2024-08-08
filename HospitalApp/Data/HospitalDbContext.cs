using HospitalApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Data
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public HospitalDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
