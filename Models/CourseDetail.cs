using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rp799815_MIS4200.Models
{
    public class CourseDetail
    {
            public int courseDetailID { get; set; }
            public int qtyInstructor { get; set; }

            // the next properties link the courseDetail to the Order
            public int courseID { get; set; }
            public virtual Course CourseDetails { get; set; }

            // the next two properties link the courseDetail to the Instructor
            public int instructorID { get; set; }
            public virtual Instructor Instructor { get; set; }
        }
}