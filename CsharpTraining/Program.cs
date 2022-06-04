using System;
using System.Collections.Generic;
using CsharpTraining.Bl;
using CsharpTraining.Model;

class Program
{
    public static void Main()
    {
        EmployeeBl bl = new EmployeeBl();
        List<EmployeeModel> empList =  bl.EmployeeAdd(3, "Abhay");


        foreach (EmployeeModel employeeInfo in empList)
        {
            string name = employeeInfo.FirstName;
            int employeeId = employeeInfo.EmployeeID;

            Console.WriteLine("Employee Id:{0} Employee Name:{1}",employeeId,name);
        }

        /*
            Student id, 
            Student Name, 
            Father Name, 
            Mobile No, 
            Fees, 
            Admission Status
         */
        


    }

}