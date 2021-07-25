using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceAPI.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CourseName { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan TimeStart { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan TimeEnd { get; set; }
    }
}
