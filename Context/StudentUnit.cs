using FIT5032_W04_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Context
{
    public class StudentUnit: DbContext
    {
        public DbSet<Student> Students { set; get; }
        public DbSet<Unit> Units { get; set; }
    }
}