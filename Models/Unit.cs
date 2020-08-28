using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public String UnitName { get; set; }
        public String UnitDescription { get; set; }
        public int TargetStudentId { get; set; }
        public virtual Student Target { get; set; }

    }
}