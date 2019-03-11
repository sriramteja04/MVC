using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeID { get; set; }
        public string DegreeAbrrev { get; set; }
        public string DegreeName { get; set; }


        public ICollection<DegreeRequirement> DegreeRequirements { get; set; }
    }
}
