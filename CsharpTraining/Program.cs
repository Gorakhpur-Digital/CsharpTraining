using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        // late binding example
        Assembly excutingAssemply = Assembly.GetExecutingAssembly();
        Type customerType = excutingAssemply.GetType("Customer");
        object customerInstance = Activator.CreateInstance(customerType);
        MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");
        string[] parameter = { "Gorakhpur", "Digital" };
        string fullName = (string)getFullNameMethod.Invoke(customerInstance,parameter);
        Console.WriteLine(fullName);
    }
}

public class Customer
{
    public string GetFullName(string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }

}