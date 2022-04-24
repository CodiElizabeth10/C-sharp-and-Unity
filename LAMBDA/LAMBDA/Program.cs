using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        { 
                 List<Employee> employees = new List<Employee>();

        employees.Add(new Employee { FirstName = "Joe", LastName = "Exoctic", ID = 01 });
    employees.Add(new Employee { FirstName = "Octavia", LastName = "Blake", ID = 02 });
    employees.Add(new Employee { FirstName = "Tanjiro", LastName = "Kamado", ID = 13 });
    employees.Add(new Employee { FirstName = "Calrke", LastName = "Griffin", ID = 04 });
    employees.Add(new Employee { FirstName = "Bulma", LastName = "Briefs", ID = 05 });
    employees.Add(new Employee { FirstName = "Trunks", LastName = "Briefs", ID = 26 });
    employees.Add(new Employee { FirstName = "Piccolo", LastName = "Namek", ID = 17 });
    employees.Add(new Employee { FirstName = "Joe", LastName = "Dirt", ID = 08 });
    employees.Add(new Employee { FirstName = "Giyu", LastName = "Tamioka", ID = 09 });
    employees.Add(new Employee { FirstName = "Nezuko", LastName = "Kamado", ID = 10 });
    employees.Add(new Employee { FirstName = "Jamie", LastName = "Fraser", ID = 11 });


List<Employee> employees1 = new List<Employee>();
foreach (Employee employee in employees)
{
    if (employee.FirstName == "Joe")
    {
        employees1.Add(employee);
    }

}
foreach (Employee employee1 in employees1)
{
    Console.WriteLine(employee1.LastName);
}
Console.WriteLine();

List<Employee> employees2 = employees.Where(x => x.FirstName == "Joe").ToList();
foreach (Employee employee2 in employees2)
{
    Console.WriteLine(employee2.LastName);
}
Console.WriteLine();

List<Employee> employees3 = employees.Where(x => x.ID > 5).ToList();

foreach (Employee employee3 in employees3)
{
    Console.WriteLine(employee3.LastName);
}

Console.ReadLine();
        }

    }
}