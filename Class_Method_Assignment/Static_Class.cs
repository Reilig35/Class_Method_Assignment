using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assignment
{
    public static class Static_Class
    {
        //Static Method Welcome Message Start
        public static void YourName(string x, string y)
        {
            Console.WriteLine($"Welcome {x} {y} to my programmes\n\n\n");
        }
        //Static Method Welcome Message End

        public static void ToKPH(double mph) 
        {
            double result = mph * 1.61;
            Console.WriteLine($"{mph} converted to km/h is {result}");

        }

    }
}
