using System;
using name1;
using name2;


namespace name1
{
    class test1
    {
        public void sayHi()
        {
            Console.WriteLine("Hello from namespace1");
        }
    }
}

namespace name2
{
    class test2
    {
        public void sayBye()
        {
            Console.WriteLine("Bye from namespace2");
        }
    }

}

namespace ConsoleApplication
{
    public class student
    {
        public student()
        {

        }
        public int Rollno;
        public string Name;
    }

    public class Factorial
    {
        public int factorial(int n)
        {
            int result;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(n - 1) * n;
                return result;
            }
        }
    }
    class FunctionOverloading
    {
        public int area(int x, int y)
        {
            Console.WriteLine("Area of Rectangle:" + (x * y));
            return x * y;
        }
        public int area(int x)
        {
            Console.WriteLine("Area of Square:" + (x * x));
            return x * x;
        }
        public int area(int x,int y, int z)
        {
            Console.WriteLine("Area of Triangel:" + (x * y * z));
            return x * y * z;
        }
    }

    class Employee
    {
        int Salary = 180;

        public void getSalary()
        {
            Console.WriteLine("Salary" + Salary);
        }
    }

    class Programmer : Employee
    {
        int Bonus = 20;
        public void getBonus()
        {
            Console.WriteLine("Bonus" + Bonus);
        }
    }
    class Program
    {
        static void Main(string[] args)


        {
            // Practical 1

            // Q1 Variables and Data types
            int num1, num2, num3, num4, product;
            Console.WriteLine("Enter four numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            product = num1 * num2 * num3 * num4;
            Console.WriteLine("Prouduct = "+ product);

            // Q2 Object Based Manipulation 
            student s1 = new student();
            s1.Rollno = 42;
            s1.Name = "Salman";
            Console.WriteLine("Student Name: " + s1.Name);
            Console.WriteLine("Student Rollno: " + s1.Rollno);
            Console.WriteLine();

            // Q3 Conditional Logic 

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num%2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            // Q4 Loops 
             
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i <= 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + "\t");
            }

            // Prime Number

            int p = 0;
            Console.WriteLine("Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    p++;
                }
                
            }
            if (p == 2)
            {
                Console.WriteLine("Entered Number is prime");
            }
            else
            {
                Console.WriteLine("Entered Number is not prime");
            }

            // Program to demonstrate User defined functions
            Factorial f = new Factorial();
            int x = f.factorial(3);
            Console.WriteLine(x);

            // Function Overloading 
            FunctionOverloading fn = new FunctionOverloading();
            fn.area(2);
            fn.area(2, 3);
            fn.area(2, 3, 4);

            // Testing namespaces
            test1 t1 = new test1();
            test2 t2 = new test2();
            t1.sayHi();
            t2.sayBye();


        }
    }
}
