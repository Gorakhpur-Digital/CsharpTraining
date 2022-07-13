using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Starting");

        Worker worker = new Worker();
        worker.DoWork();
        //while (!worker.IsComplete)
        //{
        //    Console.Write("....");
        //    Thread.Sleep(100);
        //}
        Console.WriteLine("Done");
        Console.ReadKey();
    }

}

class Worker
{

    public bool IsComplete { get; set; }
    public async void DoWork()
    {
        this.IsComplete = false;
        Console.WriteLine("Doing work");
        await LongOpration();
        Console.WriteLine("Work Completed");
        IsComplete = true;
    }
    private Task LongOpration()
    {
        return Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Working");
            Thread.Sleep(2000);
        });

    }

}