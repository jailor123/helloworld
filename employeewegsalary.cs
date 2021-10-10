using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int present = 1;
            Random a = new Random();
            int Imploy = a.Next(0, 2);
            int EmployHourper = 200;
            int EmployHour = 0;
            int EmployeWeg = 0;


            if (present==Imploy)
            {
                Console.WriteLine("Employee is  present");
                EmployHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                EmployHour = 0;
            }

             EmployeWeg = EmployHourper * EmployHour ;
            Console.WriteLine("Employee EmployeWeg : {0}", EmployeWeg);

            Console.ReadLine();


        }
    }
}
