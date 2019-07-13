using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        // properties 
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        // Constructor
        public Company()
        {
            CreatedOn = DateTime.Now;
        }
        public void AddEmployee(Employee name)
        {
            Employees.Add(name);
        }
        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employees In the Company: {employee.FirstName} - {employee.LastName} - {employee.Title} - {employee.StartDate}");
            }
        }

    }
}