using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Instructor
    {
        [Key]
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ICollection<Course> CourseDetails { get; set; }
    }
}