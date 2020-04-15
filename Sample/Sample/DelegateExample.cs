using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class DelegateExample
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 101, Name = "sharmi", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 101, Name = "cj", Salary = 5000, Experience = 4 });
            emplist.Add(new Employee() { ID = 101, Name = "sneha", Salary = 5000, Experience = 6 });

            IsPromotable del = new IsPromotable(promoted);
            Employee.PromoteEmployee(emplist, del);
            // Instead of creating a delegate and point it to a fun we can directly use lambda exp
            // Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5) in the backend it will create a delagate and a func for the condition and makes delegate point to it.
        }
            public static bool promoted (Employee emplo)
            {
                if(emplo.Experience >= 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
 

    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist, IsPromotable Promote)
        {
            foreach (Employee employee in employeelist )
            {
                if(Promote(employee))
                {
                    Console.WriteLine(employee.Name + "Promoted");
                }
            }
        }
    }

}
