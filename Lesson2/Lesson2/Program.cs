using System;
using System.Threading;

namespace Lesson2
{
    public class ThreadControl
    {
        public clOperations _operation { get; set; }
        public AutoResetEvent _autoResetEvent { get; set; }

        public ThreadControl(clOperations operation, AutoResetEvent autoResetEvent)
        {
            _operation = operation;
            _autoResetEvent = autoResetEvent;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent[] autoResetEvents = new AutoResetEvent[5];
            clOperations clOp = new clOperations();
            clOp._ch1 = 0;
            clOp._ch2 = 3;
            ThreadPool.SetMaxThreads(1, 0);

            for (int i = 0; i < autoResetEvents.Length; i++)
            {
                autoResetEvents[i] = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(OperatNumbers), new ThreadControl(clOp, autoResetEvents[i]));
            }
            WaitHandle.WaitAll(autoResetEvents);

        }

        static void OperatNumbers(object o)
        {
            if (o != null && o is ThreadControl)
            {
                var threadControl = (ThreadControl)o;
                lock (threadControl._operation)
                {
                    Console.WriteLine($"Первое значение = {threadControl._operation._ch1}; Второе значение = {threadControl._operation._ch2};  {Thread.CurrentThread.ManagedThreadId}");
                    Console.WriteLine($"Сумма = {threadControl._operation.Sum()}; Разность = {threadControl._operation.subtraction()}");
                    threadControl._operation._ch1++;
                    threadControl._operation._ch2 = threadControl._operation._ch1 * 2;
                }
            }
        
        }
    }
}
