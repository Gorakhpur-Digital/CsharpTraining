using System;
class Program
{
    public static void Main()
    {
        MyNameSpace.Employee emp = new MyNameSpace.Employee("Arvind",100);
        string name = emp.GetEmployeeName();
        int salary = emp.GetEmployeeSalary();

        Console.WriteLine("Employee Name {0} and Salary {1}",name,salary);
    }

}

namespace MyNameSpace
{
    public class Employee
    {
        string EmployeeName;
        int EmployeeSalary;
        public Employee(string name, int salary)
        {
            this.EmployeeName = name;
            this.EmployeeSalary = salary;
        }

        public string GetEmployeeName()
        {
            return EmployeeName;
        }

        public int GetEmployeeSalary()
        {
            return EmployeeSalary;
        }


    }

}



