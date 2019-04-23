﻿using System;
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
        public int DegreeId { get; set; }
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Degree Abbreviation")]
        [StringLength(10, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
        public string DegreePlanAbbrev { get; set; }

        [Required]
        [Display(Name = "Degree Plan Name")]
        [StringLength(10, ErrorMessage = "plan name cannot be longer than 10 characters.")]
        public string DegreePlanName { get; set; }
        public bool Done { get; set; }

        public Degree Degree { get; set; }
        public Student Student { get; set; }
    }
}
