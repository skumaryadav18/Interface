using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
  public interface IEmployee
    {
        int empId { get; set; }
        string empName { set; get; }
        double empSalary { set; get; }

        void EmployeeExperience(int yearsOfExperience);
        void DisplayEmployeeInfo();
    }
    public class Developer : IEmployee
    {
        public int empId { get; set; }
        public string empName { set; get; }
        public double empSalary { set; get; }
        public void EmployeeExperience(int yearsOfExperience)
        {
            Console.WriteLine("Experience : " + yearsOfExperience);
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Developer Id : " + empId + " Name : " + empName + " Salary : " + empSalary);
        }
    }
    public class Tester : IEmployee
    {
        public int empId { get; set; }
        public string empName { set; get; }
        public double empSalary { set; get; }
        public void EmployeeExperience(int yearsOfExperience)
        {
            Console.WriteLine("Experience : " + yearsOfExperience);
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Tester Id : " + empId + " Name : " + empName + " Salary : " + empSalary);
        }
    }

    public class InterfaceMain
    {
        public static void Main(string[] args)
        {
            IEmployee employee = new Developer();
            employee.empId = 1;
            employee.empName = "Saurabh Kumar";
            employee.empSalary = 60000.0;
            employee.DisplayEmployeeInfo();
            employee.EmployeeExperience(2);
            employee = new Tester();
            employee.empId = 2;
            employee.empName = "Aman Gupta";
            employee.empSalary = 80000.0;
            employee.DisplayEmployeeInfo();
            employee.EmployeeExperience(4);
            Console.ReadLine();
        }
    }
}