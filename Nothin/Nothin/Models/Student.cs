using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nothin.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int Age { get; set; }
        public String Name { get; set; }
        public int Hours { get; set; }
        public List<string> Classes { get; set; }


    }
}