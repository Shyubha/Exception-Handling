using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================Abstract Class Exapmles====================");
            Console.WriteLine("\n-----------------------------------------");
            Circle circle = new Circle(4);
            circle.CalculateArea();
            Console.WriteLine("Area of Circle is : " + circle);
            Console.WriteLine("Area of Circle is : " + circle.Print());

            Console.WriteLine("-----------------------------------------");
            Rectangle rectangle = new Rectangle(25, 12);
            rectangle.CalculateArea();
            Console.WriteLine("Area of Rectangle is " + rectangle);

            Console.WriteLine("\n\n============================Interface Class Exapmles====================");
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("-->Explicit Interface");
            ICustomer customer = new Transaction();
            Console.WriteLine(customer.DisplayDetails());

            IOrder oder = new Transaction();
            Console.WriteLine(customer.DisplayDetails());


            Console.WriteLine("\n\n============================Out Keyword Exapmles====================");
            Console.WriteLine("\n-----------------------------------------");


            int a = 10, b = 20;
            int add, sub, mul;
            Calulation(a, b, out add, out sub, out mul);
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

            Console.WriteLine("\n\n============================Exception Handling====================");
            Console.WriteLine("\n-----------------------------------------");
            int i = 4, j = 0, k;
            try
            {
                k = i / j;
                Console.WriteLine("Division is " + k);
            }
            // base class will handle all types of exception in the program
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("In the finally block");
            }

            Console.WriteLine("\n-----------------Name Exception------------------------");
            User user = new User();
            try
            {
                string name = user.AcceptName("");
                Console.WriteLine("The string name is  : " + name);
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n-------------------Age Exception----------------------");
            user user1 = new user();
            try
            {
                int age = user1.AcceptAge(12);
                Console.WriteLine("You age is valid for vote" + age);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void Calulation(int n1, int n2, out int add, out int sub, out int mul)
        {
            add = n1 + n2;
            sub = n1 - n2;
            mul = n1 * n2;
        }
    }
}

