using System;
using Classl;
namespace cl2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ganesh", "Kulkarni");
            Employee e2 = new Employee("Captain", "Jack", "Sparrow");
            e1.dips();
            e2.dips();
            Console.ReadLine();
        }
    }
}
