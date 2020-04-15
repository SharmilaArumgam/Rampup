using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Anonymous
    {
        public static void Main(string[] args)
        {
            List<Employees> emplist = new List<Employees>();

            emplist.Add(new Employees() { ID = 101, Name = "sharmi" });
            emplist.Add(new Employees() { ID = 102, Name = "cj" });

            Employees employee = emplist.Find(delegate (Employees emp)
            {
                return emp.ID == 102;
            });

            Console.WriteLine("ID = {0} , Name = {1}", employee.ID, employee.Name);
            //Anonymous method gives us a way to create delagate instance without having to create a method ;
        }
    }

    class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
