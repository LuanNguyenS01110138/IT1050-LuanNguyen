using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // #3
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
                Console.WriteLine("SLOW NOW");
            Console.ReadLine();

            // #4
            int isTrue = 21;

            if (isTrue <= 45)
                Console.WriteLine("It is True!");
            else
                Console.WriteLine("It is False!");
            Console.ReadLine();


            // #4 Continued
            int isTrue = 21;

            if (isTrue >= 45)
                Console.WriteLine("It is True!");
            else
                Console.WriteLine("It is False!");
            Console.ReadLine();

            // #5
            Console.WriteLine("Please input a temperature in Fahrenheit");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double Celcius = (Fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("The temperature in Celcius is {0}", Celcius);
            Console.ReadLine();
            if (Fahrenheit >= 90)
                Console.WriteLine("It is hot");
            Console.ReadLine();
            if (Fahrenheit <= 40)
                Console.WriteLine("It is cold");
            Console.ReadLine();

            // #6
            int number = 1;
            while (number < 11)
            {
                Console.WriteLine("Number is {0}", number);
                number++;
            }

            // #7
            int number = 60;
            while (number >= 20)
            {
                Console.WriteLine("Number is {0}", number);
                number -= 5;
            }

            // #8
            int number = 10;
            while (number <=20)
            {
                Console.WriteLine("Number is {0}", number);
                number += 2;
            }
        }
    }
}

/* #2 A single-selection statement is an if statement that performs an action if a condition is true or performs a different action
 * if the condition is false. It selects and ignores a single action hence it being called the 'single-selection statement'. The repeition statement
 * enable apps to perform statements repeadtedly, depending on the value of loop-continue condition. Both statements are similar in the aspect that
 * they perform specific actions that they were instructed to do and both have to evaluate whether the statement remains true or becomes false. They differ in the aspect that 
 * the single-selection statement only performs a certain condition if it is true or false while the repetition statement executes until the desired loop count. */

 