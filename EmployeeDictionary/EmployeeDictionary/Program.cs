using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> EmployeeDictionary = new Dictionary<int, Employee>();

            EmployeeDictionary.Add(101, new Employee { ID = 101, FirstName = "Jill", LastName = "Ruby" });
            EmployeeDictionary.Add(102, new Employee { ID = 102, FirstName = "Greg", LastName = "Davi" });
            EmployeeDictionary.Add(103, new Employee { ID = 103, FirstName = "Clay", LastName = "Cran" });

            Console.WriteLine(EmployeeDictionary[101].Print());
            Console.WriteLine(EmployeeDictionary[102].Print());
            Console.WriteLine(EmployeeDictionary[103].Print());

            Console.ReadLine();
        }
    }
}
