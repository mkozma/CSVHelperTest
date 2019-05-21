﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelper
{
    public class Course: CSVHelper<Course>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Climb { get; set; }
    }
}
