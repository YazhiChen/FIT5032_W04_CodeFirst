using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public List<Unit> Units { get; set; }

    }
}