using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }
        [ForeignKey("DegreeId")]
        public int DegreeId { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Degree Abbreviation")]
        [StringLength(50, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
        public string DegreePlanAbbrev { get; set; }

        [Required]
        [Display(Name = "Degree Plan Name")]
        [StringLength(50, ErrorMessage = "plan name cannot be longer than 50 characters.")]
        public string DegreePlanName { get; set; }
        public bool Done { get; set; }

        public Degree Degree { get; set; }

        public Student Student { get; set; }

        public DegreeStatus DegreeStatus { get; set; }

        public ICollection<StudentTerm> studentTerms { get; set; }
    }
}
