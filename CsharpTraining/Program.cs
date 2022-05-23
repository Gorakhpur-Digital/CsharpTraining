using System;
class Program
{
    static void Main()
    {
        /* 
        for (int start = 1; start <= 5; start++)
        {
            if (start == 3 || start == 4)
            {
                break;
            }
            Console.WriteLine(start);
        }

        Console.WriteLine("Loop End");
        */

        int[] i = new int[5];

        i[0] = 10;
        i[1] = 20;
        i[2] = 30;
        i[3] = 40;
        i[4] = 50;

        foreach (int a in i)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("Loop End");

    }
}
