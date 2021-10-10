using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class EmployeeW
    {
        static void Main(string[] args)
        {
            int present = 1;
            Random a = new Random();
            int Imploy = a.Next(0, 3);
            int EmployHourper = 200;
            int EmployHour = 0;
            int EmployeWeg = 0;
            int PartTime = 2;
            Console.WriteLine("WELCOME");

            if (present == Imploy)
            {
                Console.WriteLine("Full time Employee is  present");
                EmployHour = 10;
            }
            else if (PartTime == Imploy)
            {
                Console.WriteLine("Part time Employee is present");
                EmployHour = 5;
            }
            
            else
            {
                Console.WriteLine("Employee is absent");
                EmployHour = 0;
            }

            EmployeWeg = EmployHourper * EmployHour;
            Console.WriteLine("Employee EmployeWeg : {0} $", EmployeWeg);

            Console.ReadLine();


        }
    }
}
