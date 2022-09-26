using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class TimeWorker : Employee
    {
        protected internal override double Calculation(double Sum)
        {
            return 20.8 * 8 * Sum;
        }
    }
}
