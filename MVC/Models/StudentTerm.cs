﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; set; }
        public string StudentID { get; set; }
        public int Term { get; set; }
        public string TermLabel { get; set; }
        
    }
}
