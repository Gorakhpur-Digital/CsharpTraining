using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main() {

        Console.WriteLine("Please enter number");
        object target = Console.ReadLine();

        //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Program.PrintNumber);
        //Thread thread = new Thread(parameterizedThreadStart);

        Thread thread = new Thread(Program.PrintNumber);
        
        Console.WriteLine("Print Number");
        thread.Start(target);
        
    }

    public static void PrintNumber(object target)
    {
        int number = 0;
        bool isParse = int.TryParse(target.ToString(), out number);
        if (isParse)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
