using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceAPI.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TeacherName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
    }
}
