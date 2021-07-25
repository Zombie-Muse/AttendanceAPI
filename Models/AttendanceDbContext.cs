using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceAPI.Models
{
    public class AttendanceDbContext:DbContext
    {
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
