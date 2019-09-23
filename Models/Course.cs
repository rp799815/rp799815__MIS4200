using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rp799815_MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime classDate { get; set; }
        public ICollection<Course> CourseDetails { get; set; }
        public int studentId { get; set; }
        public virtual Student Student { get; set; }
    }
}