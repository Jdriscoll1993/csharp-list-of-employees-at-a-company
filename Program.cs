

using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company apple = new Company();
            // Create three employees
            Employee ricky = new Employee()
            {
                FirstName = "Randy",
                LastName = "Lahey",
                Title = "Mall Cop"
            };
            Employee julian = new Employee()
            {
                FirstName = "Corey",
                LastName = "Trevor",
                Title = "Security Officer"

            };
            Employee lahey = new Employee()
            {
                FirstName = "Trevor",
                LastName = "Lahey",
                Title = "Corperate Hobo"
            };
            // Assign the employees to the company
            apple.AddEmployee(ricky);
            apple.AddEmployee(julian);
            apple.AddEmployee(lahey);


            apple.ListEmployees();
        }
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}
