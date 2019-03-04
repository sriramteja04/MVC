using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class DegreeRequirement
    {
        public int DegreeRequirementID { get; set; }
        public int DegreeID { get; set; }
        public int TermId { get; set; }
        public int RequirementID { get; set; }

        public Degree Degree { get; set; }
        public Requirement Requirement { get; set; }

    }
}
