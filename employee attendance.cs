using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            int present =1;
            
            Random r = new Random();
            int empInput=r.Next (0,2);

            if (present==empInput)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            Console.ReadLine();
        }
    }
}
