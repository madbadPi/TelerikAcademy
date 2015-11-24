using System;

class EmployeeRecord
{
    static void Main()
    {
        string employeeFirstName = "Jim";
        string employeeSurname = "Carrey";
        int employeeAge = 51;
        char employeeGender = 'M';
        int employeeNum = 27560001;
        Console.WriteLine("The record for employee {0} is :", employeeNum);
        Console.WriteLine("full name : " + employeeFirstName + " " + employeeSurname + "\n" + "age : " + employeeAge + "\n" + "gender : " + employeeGender);    
    }
}
