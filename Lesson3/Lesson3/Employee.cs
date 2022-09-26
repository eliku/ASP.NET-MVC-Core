using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public abstract class Employee
    {
        public string _fullName {get; set;}
        public double _salary { get; set; }

        protected internal abstract double Calculation(double Sum);
    }
}
