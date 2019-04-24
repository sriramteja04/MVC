using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Requirement
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Requirement Id")]
        public int RequirementId { get; set; }

        [Required]
        [Display(Name = "Requirement Abbreviation")]
        [StringLength(10, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
        public String RequirementAbbrev { get; set; }

        [Required]
        [Display(Name = "Requirement name")]
        [StringLength(50, ErrorMessage = "name cannot be longer than 10 characters.")]
        public String RequirementName { get; set; }

        public bool Done { get; set; }

    }
}
