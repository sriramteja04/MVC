using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public int DegreeID { get; set; }
        public int StudentId { get; set; }
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName { get; set; }
    }
}
