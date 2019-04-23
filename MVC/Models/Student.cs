using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "Given name cannot be longer than 50 characters.")]
        public string First { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Given name cannot be longer than 50 characters.")]
        public string Last { get; set; }

        [Required]
        [Display(Name = "SNumber")]
        [StringLength(50, ErrorMessage = "Given name cannot be longer than 50 characters.")]
        public string Snumber { get; set; }


        public int SId { get; set; }

        public bool Done { get; set; }

        public ICollection<DegreePlan> DegreePlans { get; set; }
        public ICollection<StudentTerm> StudentTerms { get; set; }
    }
}
