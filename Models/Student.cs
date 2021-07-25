using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string StudentName { get; set; }

        public int StudentGradeLevel { get; set; }
    }
}
