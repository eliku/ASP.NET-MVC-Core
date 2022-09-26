using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            Employee[] arrEmploy = new Employee[6];
            arrEmploy[0] = new TimeWorker();
            arrEmploy[0]._fullName = "Иванов А.В.";
            arrEmploy[0]._salary = arrEmploy[0].Calculation(2000);

            arrEmploy[1] = new EmployeesFixedPay();
            arrEmploy[1]._fullName = "Иванова А.А.";
            arrEmploy[1]._salary = arrEmploy[1].Calculation(25000);

            arrEmploy[2] = new TimeWorker();
            arrEmploy[2]._fullName = "Сидоров А.В.";
            arrEmploy[2]._salary = arrEmploy[2].Calculation(1500);

            arrEmploy[3] = new EmployeesFixedPay();
            arrEmploy[3]._fullName = "Сидорова А.А.";
            arrEmploy[3]._salary = arrEmploy[3].Calculation(70000);

            arrEmploy[4] = new EmployeesFixedPay();
            arrEmploy[4]._fullName = "Петров А.А.";
            arrEmploy[4]._salary = arrEmploy[4].Calculation(50000);

            for (int i = 0; i < arrEmploy.Length; i++)
                Console.WriteLine($"{arrEmploy[i]._fullName} с зарплатой  {arrEmploy[i]._salary}");
        }
    }
}
