using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        bool equal = Calculator.AreEqual(10, 20);
        if (equal)
        {
            Console.WriteLine("value are equal");
        }
        else
        {
            Console.WriteLine("value are not equal");
        }
        
    }
}

public class Calculator
{
    public static bool AreEqual<T>(T value1, T value2)
    {
        return value1.Equals(value2);
    }

}