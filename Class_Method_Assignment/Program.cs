using System;
using System.Collections.Generic;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Class Method Start
            Console.WriteLine("Please type your first name:");
            string fNname = Console.ReadLine();

            Console.WriteLine("Please type your last name:");
            string lNname = Console.ReadLine();

            Static_Class.YourName(fNname, lNname);
            //Static Class Method End
            
            
            //Divided by two method Start
            Console.WriteLine("Please enter a number to half it:\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            myMethod halfMyInput = new myMethod();
            halfMyInput.halfUserInput(num1);

            //Divided by two method End

            
            //Overload Challenge Start
            //The Original Method Start
            Console.WriteLine("Please type a whole number to multiply by 56:\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            myMethod times56 = new myMethod();
            int a = times56.mutli56(num2);

            int aF = a;

            Console.WriteLine($"{num2} times 56 = {a}\n\n\n");
            //The Original Method End


            //The Overloaded Method Start
            Console.WriteLine("Please type a number with a decimal point to multiply by 56:\n");
            string num3s = Console.ReadLine();
            float num3 = float.Parse(num3s);

            myMethod times56Dec = new myMethod();
            float b  = times56.mutli56(num3);

            Console.WriteLine($"{num3} times 56 = {b}\n\n\n");
            //The Overloaded Method End
            //Overload Challenge End



            // Call the Add method and pass it as an out parameter Start
            int num5;
            int num6;

            myMethod Add = new myMethod();
            
            Add.Add(out num5, out num6);
            Console.WriteLine($"\n\n\nThe first out is {num5}\n");
            Console.WriteLine($"\n\n\nThe second out is {num6}\n");

            List<float> myList = new List<float>();
            myList.Add(num5);
            myList.Add(num6);

            Console.WriteLine($"\n\n\n{myList[0]} and {myList[1]} have been added to mylist\n\n");

            // Call the Add method and pass it as an out parameter End

            //Another Static function for practise
            Console.WriteLine("\n\n\nEnter a speed in MPH to convert to km/h:\n");
            double mph = Double.Parse(Console.ReadLine());
            
            Static_Class.ToKPH(mph);
        }

    }
}




     

          









    
