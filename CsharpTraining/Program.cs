using System;
class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.FirstName = "Vishal";
        emp.LastName = "Chaudhary";
        emp.GetSalary = 10000;


        string employeeName = emp.GetFullName();
        int salary = emp.GetSalary;

        Console.WriteLine(employeeName);
        Console.WriteLine(salary);
    }

}

// by default class access modifire "Internal"
class Employee
{
    // by default clsss member access modifire "Private"
    public string FirstName = "Arvind";
    public string LastName = "Shukla";
    private int Salary;

    public string Department { get; set; }

    // property
    public int GetSalary
    {
        get
        {
            return this.Salary;
        }
        set
        {
            if(value < 0)
            {
                throw new Exception("salary cant be less than 0");
            }
            this.Salary = value;
        }
    }
    public string GetFullName()
    {
        //string fullName = FirstName + " " + LastName;
        string fullName = string.Format("{0} {1}", this.FirstName, this.LastName);
        return fullName;
    }

  
}