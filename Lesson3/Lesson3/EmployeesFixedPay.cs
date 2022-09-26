using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class EmployeesFixedPay : Employee
    {
        protected internal override double Calculation(double Sum)
        {
            return Sum;
        }
    }
}
