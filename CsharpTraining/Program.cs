using System;
class Program
{
    static void Main()
    {

        #region built in type

        /*
         
        Built -in type in c#
        1: Boolean Type - only true or false
        2: Integral Type - sbyte, byte, short, ushort, int, uint, long, ulong, char
        3: Floating Type - float, double
        4: Decimal Type - 
        5: String - Type

        */

        // get min and max
        ////Console.WriteLine(int.MinValue);
        ////Console.WriteLine(int.MaxValue);

        // Implicit Conversion
        byte num = 100;
        int num1 = num;

        // Explicit Conversion
        string num2 = "100";
        int num3 = Convert.ToInt32(num2);

        int num4 = 0;
        bool result = int.TryParse(num2, out num4);

        ////Console.WriteLine(num1);
        ////Console.WriteLine(num3);
        ////Console.WriteLine(num4);

        #endregion

        #region Operator
        //Assignment Operators - =
        //Arthmetic Operators - +, -, *, /, %
        //Comparison Operators - ==, !=, >, >=, <, <=
        //Conditional Operators - &&, ||
        //Ternary Operators - ?:
        //Null Coalescing Operators - ??

        //string studentName = "Arvind Shukla";

        int num5 = 6; int num6 = 7;

        //bool result1 = num5 < 6 && num5 == 7;

        if (num5 < 7)
        {
            ////Console.WriteLine("if block");
        }
        else
        {
            ////Console.WriteLine("else block");
        }

        int r = num5 > 7 ? 100 : 200;
        //Console.WriteLine(r);

        #endregion

        #region if else block

        int age = 20;

        if (age == 9)
        {
            //Console.WriteLine("your age is 9");
        }
        else if (age == 10)
        {
            //Console.WriteLine("your age is 10");
        }
        else if (age == 15)
        {
            //Console.WriteLine("your age is 15");
        }
        else if (age == 20)
        {
            //Console.WriteLine("your age is 20");
        }



        #endregion

        #region switch case

        /* 
        int salary = 110;

        if(300 == salary || 200 == salary)
        {
            Console.WriteLine("you dont have bonus becouse your salary is " + salary);
        }
        else if(100 == salary)
        {
            Console.WriteLine("congratulation : you have bonus becouse your salary is 100");
        }
        else {
            Console.WriteLine("your salary is not found");
        }
        */

        /* */
       
        Console.WriteLine("Please enter your status");
        string accountStatus = Console.ReadLine().ToLower();
        switch (accountStatus)
        {
            case "active":
                Console.WriteLine("Login Successfully");
                break;
            case "pending":
            case "cancel":
            case "reject":
                Console.WriteLine("your dont login because your account status is " + accountStatus);
                break;
            default:
                Console.WriteLine("your account status not found, please contact admin");
                break;
        }

        #endregion

    }
}
