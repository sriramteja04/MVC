using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Snumber { get; set; }
        public int SID { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
