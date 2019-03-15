using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Requirement
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequirementId { get; set; }
        public String RequirementAbbrev { get; set; }
        public String RequirementName { get; set; }
        
    }
}
