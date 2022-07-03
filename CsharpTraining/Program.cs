using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {

        Employee employee = new Employee();
        employee.FirstName = "Gorakhpur";
        employee.LastName = "Digital";

        string fullName = employee.GetFullEmployeeName();
        Console.WriteLine(fullName);
    }
}