using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [Display(Name = "Term label")]
        [StringLength(10, ErrorMessage = "term label cannot be longer than 10 characters.")]
        public string TermLabel { get; set; }

        public bool Done { get; set; }

        public DegreePlan DegreePlan { get; set; } 

        
    }
}
