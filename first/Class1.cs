
/* Create a class Employee having member variable Firstname, Lastname, Middlename.
let your application create object even if user does not enter Middlename. 
Create two constructor one take parameter for Firstname, Lastname and second constructor
which will take all the parameter. Write display method which will display detail of the object */

using System;


namespace Classl
{
    public class Employee
    {
        string Fname;
        string Lname;
        string Mname;
        static Employee()
        {
            Console.WriteLine("Dtech");
        }
        public Employee(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Mname = null;
        }
        public Employee(string fname, string lname, string mname)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Mname = mname;
        }
        public void dips()
        {
            Console.WriteLine("{0}{1}{2}", Fname, Lname, Mname);
        }

    }
}
