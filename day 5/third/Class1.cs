﻿/*Q3. Create a class Employee having private instance member Id, Name Salary, netsalary. 
 * Id should be generated by application Create method calculate_netsalary who’s job is to deduct 10% of TDS.
 * Declare TDS as static variable. Write method display which will display name and netsalary. 
 * This application will be classlibrary. Declare const int maxemp=3 ie. You can have only 3 employee.
    Also declare const int maxsal=50000. 
 * Use this for validation in constructor if you try to create object with salary 80000 it should display error
Create console application and use this class library. Create at least two object of Employee class 
*/

using System;

namespace ClassEmp
{
    public class Employee
    {
        static int getid;
        int id;
        string name;
        double Sal;
        double NetSal;
       // static double TDS=0.1;
        static readonly double TDS = 0.1;

        const int maxemp = 3;
        const int maxsal = 50000;
 
        public Employee(string name, double Sal)
        {
            if (maxemp > getid)
            {
                if (maxsal > Sal)
                {
                    this.name = name;
                    this.Sal = Sal;
                    id = ++getid;
                }
                else
                {
                    Console.WriteLine("Slary must below 50000");
                }

            }
            else
            {
                Console.WriteLine("Exceed capacity");
            }
         
        }

        public double CalcNetSal()
        {
            NetSal=Sal-Sal*TDS;
            return  NetSal;
        }

       
        public void disp()
        {

            Console.WriteLine("Name:{0}  NetSalary:{1}" ,name, CalcNetSal());
        }
    }
}
