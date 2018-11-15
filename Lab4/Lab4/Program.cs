using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        static void Main(string[] args)
        {
            /* #2. The four components of the counter-controlled repetition are the: control variable, the initial value,
            the increment or decrement and the loop-continuation condition.  The control variable is known as the loop counter. 
            The initial value is the control variable. The increment or decrement is known as the iteration of the loop
            which modifies the variable each time through the loop. The loop-continuation condition determines
            whether to continue the loop */

            /* #3. A for loop is a condensed version of the while loop statement. They differ in the aspect
             that they offer some flexability on how they are executed. */

            /* #4. It would be more appropriate to do a do-while when you want to test the condition after the
             code has executed. If you want to test the condition before the code is executed you would use
             a while loop. */


            // #5
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {

                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                }
            }
            // #6
            Console.Write("Please enter a temperature:");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 90) { Console.WriteLine("fish"); }
            else if (temp >= 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp >= 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp >= 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp >= 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp >= 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temp >= 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else
            {
                Console.WriteLine("Bug");
            }


            // #7. The problem is the loop just outputs the number 10 over and over because there is no increment.
            int i = 10;
            while (i < 21) {
                Console.WriteLine(i);
                i++;
            }
            // #8. The problem is the 'Console.WriteLine("********");' it is outside of the for loop so is executed at the end.
            for (int i = 0; i < 101; i++)
                Console.WriteLine(i + "\n********");

        }
    }
    }

     

            


    

             
        
        


        
    

