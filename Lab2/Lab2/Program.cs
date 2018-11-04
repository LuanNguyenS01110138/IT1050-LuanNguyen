using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Start of #2
            int number1; //declare first number 
            int number2; //declare second number 
            int  multiply; //declare product of number1 and number2

            Console.Write("Please enter the first integer: "); //prompts user for input
            number1 = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Please enter the second integer: "); //prompts user for second input
            number2 = Convert.ToInt32( Console.ReadLine() );
            multiply = number1 * number2; //multiplies the numbers
            Console.WriteLine("Product is {0}" , multiply); //displays the product
            Console.WriteLine();

            Console.WriteLine("Press enter to continue . . ."); // prompts user for input
            Console.ReadLine();

            // Start of #3
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Luan Nguyen");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue . . ."); //prompts user for input
            Console.ReadLine();
            
            // Start of #4
            Console.WriteLine("{0}\t{1}","Hello World!","From Luan Nguyen");
            Console.ReadLine();

            // Start of #5
            /* a. Our console C# console application invokes at the Main method pending there are no compilation errors.
               b. Float and double variables store only approximations of real numbers across a greater range value while integer variables store whole numbers.
               c. An example of a method would be 'public void DisplayMessage ( string courseName)'.
               d. get accessor and set accessor
               e. Class is the definition of an object and an object is an instance of a class. Class can be seen as a recipe while object is the cake.
                  You can create one or more instances of class.
               */
           }
    }
}
