using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dissauer_MIS4800.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description  { get; set; }
        public int creditHours { get; set; }
        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}