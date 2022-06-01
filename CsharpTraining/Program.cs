using System;
class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();

        emp.GetEmployeeName();
    }

}

public class Employee
{
    // static constructor
    static Employee()
    {
        Console.WriteLine("static constructor calling....");
    }

    // constroctor
    public Employee()
    {
        Console.WriteLine("Non static constructor calling....");
    }

    // create method
    public string GetEmployeeName()
    {
        string name = "Arvind Shukla";
        return name;
    }

    public string GetEmployeeSalary()
    {
        string name = "Arvind Shukla";
        return name;
    }
}


