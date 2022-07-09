using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using CsharpTraining.Bl;
using CsharpTraining.Model;

public delegate void SumOfCallBackDelegate(int sum);
class Program
{
    public static void PrintSumOfNumber(int sum)
    {
        Console.WriteLine("Total of sum {0}", sum);
    }
    public static void Main()
    {

        Console.WriteLine("Please enter number");
        int target = int.Parse(Console.ReadLine());

        SumOfCallBackDelegate sumOfCallBack = new SumOfCallBackDelegate(PrintSumOfNumber);

        Numbre number = new Numbre(target, sumOfCallBack) ;
        Thread thread = new Thread(number.PrintNumber);

        Console.WriteLine("Print Number");
        thread.Start();

    }
}

class Numbre
{
    int _target;
    SumOfCallBackDelegate _sumOfCallBackDelegate;
    public Numbre(int target, SumOfCallBackDelegate sumOfCallBackDelegate)
    {
        _target = target;
        _sumOfCallBackDelegate = sumOfCallBackDelegate;
    }

    public void PrintNumber()
    {
        int sum = 0;
        for (int i = 0; i <= _target; i++)
        {
            sum  = sum + i;
        }

        _sumOfCallBackDelegate(sum);

    }
}
