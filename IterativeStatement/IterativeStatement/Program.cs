/* Author: Demetre Riles
 * Date: 1/24/2019
 * Comments: C# Console Application that ask for user input to start a while loop
 * */
using System;


namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask for User input to start loop
            Console.WriteLine("Hello! Please enter an integer between 1 and 100...");

           //Try and catch Block to validate users input and to handle any other exeptions
           try 
           {
                // Set boolean varible for loop
                bool cont = true;

                // Keeps Count of the loop number
                int loopNumber = 1;

                // Loop that keeps repeating for 5 cycles
                while(cont) 
                {
                    // Creates a varible to keep users input
                    string input = Console.ReadLine();

                    // Changes users input into an integer
                    int inputValue = int.Parse(input);

                    // Displays message to console with what number was entered and what iteration its on
                    Console.WriteLine("You have entered " + inputValue.ToString() + "." +
                    "This is the current integer value in the loop: " +loopNumber.ToString()  );

                    // incremates by one to represent iteration
                    loopNumber++;
                    
                    // Conditional statement that stops the loop after it reaches five iterations 
                    if (loopNumber  > 5) 
                    {    
                        // stops the loop from iterating 
                        cont = false;
                    }    
                 
                }
                // closes out the program.
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);

            }
            // catch block that catches exepeptions if string was entered
           catch 
           {
                // notifies user when they have entered a value that is not an integer.
                Console.WriteLine("Please enter an integer value next time.");

                // closes out program
                Console.WriteLine("Press any key to exit the program..."); 
                Console.ReadKey(true); 
           }

            
        }
    }
}
