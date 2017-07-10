using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        //In the Main method, create a company, and three employees, and then assign the employees to the company.
        static void Main(string[] args)
        {
            Company company = new Company("apple", DateTime.Now);
            Employee employee1 = new Employee("Adam", "Developer", "July 2");
            Employee employee2 = new Employee("Jordan", "Developer", "July 2");
            Employee employee3 = new Employee("Bryan", "Developer", "July 2");
            company.addEmployee(employee1);
            company.addEmployee(employee2);
            company.addEmployee(employee3);
            company.ListEmployees();
        }
    }
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> listOfEmployees = new List<Employee>();


        // Create a method that allows external code to add an employee
        public void addEmployee (Employee employee)
        {
            listOfEmployees.Add(employee);
        }
        // Create a method that allows external code to remove an employee
        public void removeEmployee (Employee employee)
        {
            listOfEmployees.Remove(employee);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;

        }
        // ListEmployees() method will loop through list of employees and print out to console each employees
        public void ListEmployees()
        {
            foreach (Employee empl in listOfEmployees)
            {
                Console.WriteLine($"{empl.Name}, {empl.JobTitle}, {empl.StartDate}");
            }
        }

    }
    public class Employee
    {
        public string Name;
        public string JobTitle;
        public string StartDate;
        // Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
        public Employee (string name, string jobTitle, string startDate)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
