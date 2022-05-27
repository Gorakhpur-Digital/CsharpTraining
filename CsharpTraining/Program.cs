using System;
class Program
{
    static void Main()
    {
        int[] age = new int[3];

        age[0] = 10;
        age[1] = 20;
        age[2] = 30;
        //age[3] = 30;
        //age[4] = 40;

        foreach (int a in age)
        {
            Console.WriteLine(a);
        }

        for(int i = 0; i < age.Length; i++) 
        {
            int value = age[i]; 
            Console.WriteLine(value);
        }

        Console.WriteLine("loop end");

         

    }
}
