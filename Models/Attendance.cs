using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceAPI.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Column(TypeName = "bit")]
        public bool IsPresent { get; set; }

        [Column(TypeName = "bit")]
        public bool IsTardy { get; set; }

        [Column(TypeName = "varchar(100")]
        public string Reason { get; set; }
    }
}
