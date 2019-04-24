using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Degree ID")]
        public int DegreeId { get; set; }

        [Required]
        [Display(Name = "Degree Abbreviation")]
        [StringLength(10, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
        public string DegreeAbrrev { get; set; }

        [Required]
        [Display(Name = "Degree Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string DegreeName { get; set; }


        public bool Done { get; set; }

        public ICollection<DegreeRequirement> DegreeRequirements { get; set; }

    }
}
