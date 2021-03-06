﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class RequirementStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementStatusId { get; internal set; }

        [Required]
        [StringLength(15, ErrorMessage = "Status cannot be longer than 15 characters.")]
        public string Status { get; internal set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "RequirementStatusId = " + RequirementStatusId +
              ", Status = " + Status +
              "";
        }
    }
}
