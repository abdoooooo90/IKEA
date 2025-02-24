﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models.Department
{
    public class Department : ModelBase
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
