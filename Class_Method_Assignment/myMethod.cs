using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assignment
{
    public class myMethod
    {
        //Half user input method start
        public void halfUserInput(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine($"Half of {num1} is {result}\n\n");

        }
        //Half user input method END

        //Method to overlaod start
        public int mutli56(int x)
        {
            int result = x * 56;

            return result;
        }
        //Method that returns an out put parameter End

        //Part 2 The overlaod method
        //Overloading the previous funcion by changing from int to float start
        public float mutli56(float x)
        {
            float result = x * 56;

            return result;
        }
        //Overloading the previous funcion by changing from int to float end
        //Method to overlaod start

        //Using an out to set the value of 2 var Start
        public void Add(out int num1, out int num2)
        {
            num1 = 300;
            num1 += 1;

            num2 = 40025;
            num2 += 1;
        }
        //Using an out to set the value of 2 var End
    }
}
            
