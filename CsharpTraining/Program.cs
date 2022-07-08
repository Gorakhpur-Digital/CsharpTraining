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
        Stack<Customer> stack = new Stack<Customer>();
        stack.Push(new Customer() { Id = 1, Name = "Arvind", Salary = 5000 });
        stack.Push(new Customer() { Id = 2, Name = "Abhay", Salary = 4000 });
        stack.Push(new Customer() { Id = 3, Name = "Vishal", Salary = 3000 });


        Customer c = stack.Pop();
        Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
        Console.WriteLine("Item count in stack {0}", stack.Count);

        Customer c1 = stack.Pop();
        Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c1.Id, c1.Name, c1.Salary);
        Console.WriteLine("Item count in stack {0}", stack.Count);

        Customer c2 = stack.Pop();
        Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c2.Id, c2.Name, c2.Salary);
        Console.WriteLine("Item count in stack {0}", stack.Count);


        //Customer c = stack.Peek();
        //Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);

        //Customer c1 = stack.Peek();
        //Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c1.Id, c1.Name, c1.Salary);





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