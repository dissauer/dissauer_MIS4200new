using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dissauer_MIS4800.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public string instructorName { get; set; }
        public int studentID { get; set; }
        public virtual Order Order { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
    }
}