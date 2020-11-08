using System;
using ClassEmp;
namespace EmpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Akash", 40000);
            e1.CalcNetSal();
            e1.disp();
            Employee e2 = new Employee("Vaibhav", 40000);
            e2.CalcNetSal();
            e2.disp();
            Employee e3 = new Employee("Ganesh", 35000);
            e3.CalcNetSal();
            e3.disp();
            Employee e4 = new Employee("Anand", 30000);
            e4.CalcNetSal();
            e4.disp();

            Console.ReadLine();

        }
    }
}
