using System;
class Program
{
    public static void Main()
    {

        Program p = new Program(); // instance/object  creation 
        p.PrintNumber(10);// not static member

        p.PrintNumber(10, 20);// not static member

        p.PrintNumber(10, 20, 30);// not static member


        //Program.DisplayName(); // static member

        //string name = 10;
    }

    public void PrintNumber(int num1 = 0, int num2 = 0, int num3 = 0)
    {
        Console.WriteLine("num1 {0} num2 {1} num3 {2}", num1, num2, num3);
    }


    public static void DisplayName()
    {
        Console.WriteLine("Display name");
    }


}
