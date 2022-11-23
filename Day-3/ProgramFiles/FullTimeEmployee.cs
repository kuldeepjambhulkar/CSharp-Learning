using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class FullTimeEmployee : Employee
    {
        private float BonusAmt;

        public FullTimeEmployee(int id, string employeeName, float bonusAmt) : base(id, employeeName) {
            this.BonusAmt = bonusAmt;
        }

        public float getBonusAmt() { 
            return this.BonusAmt;
        }

        public void setBonusAmt(float bonusAmt) {
            this.BonusAmt = bonusAmt;
        }

        public float getTotalAmt() { 
            return (float)(this.BonusAmt * (23));
        }
    }
}
