using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining.Bl
{
    public partial class Employee
    {
        public string GetFullEmployeeName()
        {
            return _firstName + " " + _lastName;
        }

        /*
         partial method has only private access modifire
         partial method has only void return type
         */
        partial void GetEmployeeDetails(string value)
        {
            Console.WriteLine("Get employee method invoke");
        }
    }
}
