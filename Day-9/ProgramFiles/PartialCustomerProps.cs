using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Customer
    {
        private string _fName;
        private string _lName;   

        public string FName { get { return _fName; } set { _fName = value; } }
        public string LName { get { return _lName; } set { _lName = value; } }



    }
}
