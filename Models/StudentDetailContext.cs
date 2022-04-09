using Microsoft.EntityFrameworkCore;

namespace stuManagementApi.Models
{
    public class StudentDetailContext:DbContext
    {
        public StudentDetailContext(DbContextOptions<StudentDetailContext> options):base(options)
        {

        }

        public DbSet<StudentDetail> StudentDetails { get; set; }
    }
}
