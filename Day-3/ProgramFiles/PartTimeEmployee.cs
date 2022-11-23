using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PartTimeEmployee : Employee
    {
        int HourlyRate;

        public PartTimeEmployee(int id, string employeeName, int hourlyRate) : base(id, employeeName) {
            this.HourlyRate = hourlyRate;
        }

        public int getHourlyRate() { 
            return this.HourlyRate;
        }
        public void setHourlyRate(int hourlyRate) {
            this.HourlyRate = hourlyRate;
        }

        public int getPayAmt() {
            return (int)this.HourlyRate * 5;
        }
    }
}
