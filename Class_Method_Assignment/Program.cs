using System;
using System.Collections.Generic;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 start
            Console.WriteLine("Please enter a number to half it:\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            myMethod halfMyInput = new myMethod();
            halfMyInput.halfUserInput(num1);

            //Part 1 End

            //Part 2 start
            Console.WriteLine("Please type a number:\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            myMethod times56 = new myMethod();
            int a = times56.mutli56(num2);

            int aF = a;

            Console.WriteLine($"{num2} times 56 = {a}");
            //Part 2 end

            //Part 3 Overload a method start
            Console.WriteLine("Please type a number with a decimal point:\n");
            string num3s = Console.ReadLine();
            float num3 = float.Parse(num3s);

            myMethod times56Dec = new myMethod();
            float b  = times56.mutli56(num3);

            Console.WriteLine($"{num3} times 56 = {b}");
            //Part 3 Overload a method start


            //Adding in list to prove functions returns a parameter end




            // Declare two without assigning a value.
            int num5;
            int num6;

            myMethod Add = new myMethod();
            // Call the Add method and pass it as an out parameter.

            Add.Add(out num5, out num6);
            Console.WriteLine($"\n\n\nThe first out is {num5}");
            Console.WriteLine($"\n\n\nThe second out is {num6}");

            List<float> myList = new List<float>();
            myList.Add(num5);
            myList.Add(num6);

            Console.WriteLine($"\n\n\n{myList[0]} and {myList[1]} have been added to mylist");
    
        }
    
    }
}

          









    
