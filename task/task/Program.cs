using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FullName = "Xeyyyam Eliyev";
            employee.Salary = 300;
            Console.WriteLine(employee.Salary );

            Console.WriteLine("FullName daxil edin.");
            Engineer employee1 = new Engineer();
            employee1.FullName = Console.ReadLine();
            Console.WriteLine("Salary daxil edin.");
            employee1.Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fullname daxil edin.");
            Engineer employee2 = new Engineer();
            employee2.FullName =Console.ReadLine();
            Console.WriteLine("Salary daxil edin.");
            employee2.Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("FullName daxil edin.");
            Engineer employee3 = new Engineer();
            employee3.FullName = Console.ReadLine();
            Console.WriteLine("Salary daxil edin.");
            employee3.Salary = Convert.ToInt32(Console.ReadLine());



            Engineer[] arr = new Engineer[] { employee1, employee2, employee3 };
            var count = 0;
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Salary;
                count++;

            }
            Console.WriteLine($"Ortalama Salary:{sum / count}");
        }
    }
}
