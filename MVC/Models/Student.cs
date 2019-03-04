using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Snumber { get; set; }
        public int SID { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
