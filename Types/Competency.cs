﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class Competency
    {
        public Competency()
        {
            EmployeeCompetencies = new List<EmployeeCompetencies>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<EmployeeCompetencies> EmployeeCompetencies { get; set; }
    }
}
