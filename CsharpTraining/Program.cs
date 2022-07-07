using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 10,40,20,50,30};
        numbers.Sort();


        List<Customer> list = new List<Customer>() {
            new Customer { Id = 1,Name = "Arvind", Salary = 5000 },
            new Customer { Id = 2,Name = "Abhay", Salary = 4000 },
            new Customer { Id = 3,Name = "Vishal", Salary = 3000 },
            new Customer { Id = 4,Name = "Aman", Salary = 2000 },
        };

        Console.WriteLine("sort by salary");
        list.Sort();
        
        foreach (Customer cust in list)
        {
            Console.WriteLine("Name = {0} Salary = {1}", cust.Name, cust.Salary);
        }

        Console.WriteLine("sort by name");
        SortByName sortByName = new SortByName();
        list.Sort(sortByName);
        
        foreach (Customer cust in list)
        {
            Console.WriteLine("Name = {0} Salary = {1}", cust.Name, cust.Salary);
        }
    }
}

public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo([AllowNull] Customer other)
    {
        /*
        if (this.Salary > other.Salary)
            return 1;
        else if (this.Salary < other.Salary)
            return -1;
        else
            return 0;
        */

        return this.Salary.CompareTo(other.Salary);

    }
}

public class SortByName : IComparer<Customer>
{
    public int Compare([AllowNull] Customer x, [AllowNull] Customer y)
    {
        return x.Name.CompareTo(y.Name);
    }
}