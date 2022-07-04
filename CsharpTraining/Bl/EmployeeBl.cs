using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpTraining.Bl
{
    class EmployeeBl
    {
        List<Model.EmployeeModel> employees = new List<Model.EmployeeModel>() {
                new Model.EmployeeModel {EmployeeID = 1, FirstName = "Arvind" },
                new Model.EmployeeModel {EmployeeID = 2, FirstName = "Vishal" },
                new Model.EmployeeModel {EmployeeID = 3, FirstName = "Abhay" },
                new Model.EmployeeModel {EmployeeID = 4, FirstName = "Ankit" },
                new Model.EmployeeModel {EmployeeID = 5, FirstName = "Mohit" },
                new Model.EmployeeModel {EmployeeID = 6, FirstName = "Aman" },
            };

        public string this[int employeeId]
        {
            get
            {
                return employees.FirstOrDefault(x => x.EmployeeID.Equals(employeeId)).FirstName;
            }
            set
            {
                employees.FirstOrDefault(x => x.EmployeeID.Equals(employeeId)).FirstName = value;
            }
        }
        public string this[string employeeName]
        {
            get
            {
                return employees.FirstOrDefault(x => x.FirstName.Equals(employeeName)).FirstName;
            }
            set
            {
                employees.FirstOrDefault(x => x.FirstName.Equals(employeeName)).FirstName = value;
            }
        }

    }
}
