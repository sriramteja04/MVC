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
        public int StudentTermId { get; set; }
        public string StudentId { get; set; }
        public int TermId { get; set; }
        public string TermLabel { get; set; }
        public bool Done { get; set; }

        public Student Student { get; set; }
        
    }
}
