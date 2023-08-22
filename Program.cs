using System;
using System.Linq;

namespace dropbox09
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[]
            {
             new{ Name = "Matthew Fowler", Hours = 80, Pay = 20, Department = "physics"},
             new{ Name = "Edward Rutledge", Hours = 50, Pay = 25, Department = "math"},
             new{ Name = "Nancy Foote", Hours = 100, Pay = 21, Department = "physics"},
             new{ Name = "Carolynn Evan", Hours = 20, Pay = 15, Department = "math"},
             new{ Name = "Laura Hollis", Hours = 60, Pay = 30, Department = "math"}
         };
            var DepartmentQuery = from employee in employees
                                  group employee by employee.Department;
            foreach(var eGroup in DepartmentQuery)
            {
                Console.WriteLine(eGroup.Key);
                foreach(var e in eGroup)
                {
                    Console.WriteLine($"Name: {e.Name} Hours worked: {e.Hours} Pay rate: {e.Pay}");
                }
            }
            Console.ReadKey();
        }
    }
}
