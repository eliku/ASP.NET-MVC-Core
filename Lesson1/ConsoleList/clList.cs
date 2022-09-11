using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleList
{
    public class clList<T>
    {
        public List<T> _list = new List<T>();
        public object _lock = new();

        public void Add(T item)
        {
            lock (_lock)
            {
                _list.Add(item);
            }
        }


        public void Remove(T item)
        {
            lock (_lock)
            {
                _list.Remove(item);
            }
        }
    }
}
