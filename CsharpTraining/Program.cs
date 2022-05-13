using System;
class Program
{
    static void Main()
    {
        /*
         
        Built -in type in c#
        1: Boolean Type - only true or false
        2: Integral Type - sbyte, byte, short, ushort, int, uint, long, ulong, char
        3: Floating Type - float, double
        4: Decimal Type - 
        5: String - Type

        */

        // get min and max
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        // Implicit Conversion
        byte num = 100;
        int num1 = num;

        // Explicit Conversion
        string num2 = "100";
        int num3 = Convert.ToInt32(num2);

        int num4 = 0;
        bool result = int.TryParse(num2, out num4);

        Console.WriteLine(num1);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
    }
}
