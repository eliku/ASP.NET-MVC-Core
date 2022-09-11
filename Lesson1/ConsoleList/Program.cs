using System;
using System.Threading;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            clList<int> listOne = new clList<int>();
            clList<int> listTwo = new clList<int>();

            Thread thread1 = new(() => listOne.Add(1));
            Thread thread2 = new(() => listOne.Add(5));
            Thread thread3 = new(() => listTwo.Add(32));
            Thread thread4 = new(() => listTwo.Add(34));
            Thread thread5 = new(() => listOne.Remove(1));
            Thread thread6 = new(() => listTwo.Remove(1));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();

            for (int i = 0; i < listOne._list.Count; i++)
            {
                Console.WriteLine($"listOne[{i}] = {listOne._list[i]}");
            }
            for (int i = 0; i < listTwo._list.Count; i++)
            {
                Console.WriteLine($"listTwo[{i}] = {listTwo._list[i]}");
            }
            Console.ReadKey();
        }
    }
}
