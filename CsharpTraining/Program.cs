using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        //indexers examples
        EmployeeBl employeeBl = new EmployeeBl();
        string name = employeeBl[1];
        Console.WriteLine(name);        
    }
}