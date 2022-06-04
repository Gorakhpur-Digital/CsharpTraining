using CsharpTraining.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining.Bl
{
    class EmployeeBl
    {
        List<EmployeeModel> EmpList = new List<EmployeeModel>();
        public List<EmployeeModel> EmployeeAdd(int EmployeeID, string FirstName)
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmployeeID = EmployeeID;
            emp.FirstName = FirstName; 

            EmpList.Add(emp);

            return EmpList;
        }

        public void EmployeeUpdate()
        {

        }

        public void GetEmployeeData()
        {

        }

        public void DeleteEmployee()
        {

        }
    }
}
