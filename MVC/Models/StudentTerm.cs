using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermID { get; set; }
        public string StudentID { get; set; }
        public int TermID { get; set; }
        public string TermLabel { get; set; }

        public Student Student { get; set; }
        
    }
}
