using CsharpTraining.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining.Bl
{
    public partial class Employee
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        partial void GetEmployeeDetails(string value);
    }
}
