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
        List<int> numbers = new List<int>() { 10, 40, 20, 50, 30 };
        numbers.Sort();

        List<Customer> list = new List<Customer>() {
            new Customer { Id = 1,Name = "Arvind", Salary = 5000 },
            new Customer { Id = 2,Name = "Abhay", Salary = 4000 },
            new Customer { Id = 3,Name = "Vishal", Salary = 3000 },
            new Customer { Id = 4,Name = "Aman", Salary = 2000 },
        };
        /*
        Comparison<Customer> comparison = new Comparison<Customer>(CompareCustomer);

        static int CompareCustomer(Customer x, Customer y)
        {
            return x.Id.CompareTo(y.Id);
        }
        list.Sort(comparison);
        */
        //list.Sort(delegate (Customer c1, Customer c2) { return c1.Id.CompareTo(c2.Id); });

        list.Sort((c1, c2) => c1.Id.CompareTo(c2.Id));

        list.Reverse();

        foreach (Customer customer in list)
        {
            Console.WriteLine("id = {0} name = {1} salary = {2}", customer.Id, customer.Name, customer.Salary);
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