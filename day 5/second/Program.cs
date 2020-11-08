using System;
using ClassLAmt;
namespace AmountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Vaibhav", 50000);
            a1.deposite(10000);
            a1.disp();
            a1.withdraw(10000);
            a1.disp();

            Account a2 = new Account("Ganesh", 50000);
            a2.deposite(10000);
            a2.disp();
            a2.withdraw(10000);
            a2.disp();

            Account a3 = new Account("Akash", 50000);
            a3.deposite(10000);
            a3.disp();
            a3.withdraw(10000);
            a3.disp();

            Account a4 = new Account("Anand", 50000);
            a4.deposite(10000);
            a4.disp();
            a4.withdraw(10000);
            a4.disp();
            a4.checkID();
           

        }
    }
}