﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Customer
    {
        public string getFullName()
        {
            return _fName +" "+ _lName;
        }
    }
}
