﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrManagementLibrary;

namespace TestCase
{
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.05m);}
    }
}
