using System;
class Program
{
    static void Main()
    {
        #region Task 1
        // Task 1st user login validation

        /*
        start:
        Console.WriteLine("Please enter your login id");
        string loginId = Console.ReadLine();

        Console.WriteLine("Please enter your password");
        string password = Console.ReadLine();

        if(loginId == "admin" && password == "admin")
        {
            Console.WriteLine("Login successfully");
        }
        else
        {
            Console.WriteLine("Invalid login id or password");
            goto start;
        }
        */

        #endregion

        #region Loop

        int start = 0;
        while (start < 10)
        {
            Console.WriteLine(start);

            start++;
        }

        #endregion

    }
}
