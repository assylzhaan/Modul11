//Arapova
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11PR
{
    using System;

    public struct Employee
    {
        public string Name;          
        public Vacancies Vacancy;    
        public int[] Date;       
        public int Salary;           
    }

    public struct Vacancies
    {
        public string Position;
        public string Departament;    
    }

    class Program
    {
        static void Main()
        {
            
            Vacancies vacancy = new Vacancies
            {
                Position = "HR manager",
                Departament = "IT Departament"
            };


            Employee employee = new Employee
            {
                Name = "Arapova Assylzhan",
                Vacancy = vacancy,
                Date = new int[] { 2023, 10, 16 },
                Salary = 500000
            };


            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Position: " + employee.Vacancy.Position);
            Console.WriteLine("Date: " + string.Join("/", employee.Date));
            Console.WriteLine("Salary: " + employee.Salary);
            Console.ReadKey();
        }
    }

}
