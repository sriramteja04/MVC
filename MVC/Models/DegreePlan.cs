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
        public int StudentID { get; set; }
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName { get; set; }

        public Degree Degree { get; set; }
        public Student Student { get; set; }
        public ICollection<DegreePlan> DegreePlans { get; set; }
    }
}
