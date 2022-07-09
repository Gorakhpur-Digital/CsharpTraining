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

        //Thread thread = new Thread(Program.PrintNUmber);
        //Thread thread = new Thread(new ThreadStart(Program.PrintNUmber));
        //Thread thread = new Thread(delegate () { Program.PrintNUmber(); });
        Thread thread = new Thread(x => Program.PrintNUmber());
        Console.WriteLine("Print Number");
        thread.Start();
        
    }

    public static void PrintNUmber()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
