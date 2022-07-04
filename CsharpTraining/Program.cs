using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {

        AddNumbers1(10, 10, 10, 10);
    }

    // example one for optional parameter
    public static void AddNumbers1(int num1, int num2, params int[] otherNumbers)
    {
        int result = num1 + num2;
        if(otherNumbers != null)
        {
            foreach(int num in otherNumbers)
            {
                result += num;
            }
        }

        Console.WriteLine(result);
    }

    // example two for optional parameter
    public static void AddNumbers2(int num1, int num2, int[] otherNumbers = null)
    {
        int result = num1 + num2;
        if (otherNumbers != null)
        {
            foreach (int num in otherNumbers)
            {
                result += num;
            }
        }

        Console.WriteLine(result);
    }

    // example three for optional parameter
    public static void AddNumbers3(int num1, int num2, [Optional] int [] otherNumbers)
    {
        int result = num1 + num2;
        if (otherNumbers != null)
        {
            foreach (int num in otherNumbers)
            {
                result += num;
            }
        }

        Console.WriteLine(result);
    }
}