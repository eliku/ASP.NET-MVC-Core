using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class clOperations
    {
        public int _ch1 { get; set; }
        public int _ch2 { get; set; }

        public int Sum()
        {
            if (_ch1 == null || _ch2 == null) return 0;
            return _ch1 + _ch2;
        }

        public int subtraction()
        {
            if (_ch1 == null || _ch2 == null) return 0;
            return _ch1 - _ch2;
        }

        public int multiplication()
        {
            if (_ch1 == null || _ch2 == null) return 0;
            return _ch1 * _ch2;
        }
        public double division()
        {
            if (_ch1 == null || _ch2 == null) return 0;
            return _ch1 / _ch2;
        }
    }
}
