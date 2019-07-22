using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BCLab3
{
    class Program
    {
        static char IsValidLoopBreaker (string testChar)
        {
            bool isInValidChar = true;
            Regex pattern = new Regex(@"^[y|n]$");
            char validChar = ' ';

            while (isInValidChar)
            {
                if (pattern.IsMatch(testChar))
                {
                    isInValidChar = false;
                    validChar = char.Parse(testChar);
                }
                else
                {
                    Console.WriteLine($"ERROR: Invalid input of {testChar}  entered please try again.");
                    Console.WriteLine("Do you wish to continue (y/n): ");
                    testChar = Console.ReadLine();
                }


            }
            return validChar;
        }
        
        static int ConfirmInt (string testInt)
        {
            bool isInvalidInput = true;
            int validInt = 0;

            while (isInvalidInput)
            {
                if (int.TryParse(testInt, out validInt))
                {
                    isInvalidInput = false;
                }
                else
                {
                    Console.WriteLine($"ERROR: Invalid Input: {testInt}  entered please try again: ");
                    Console.WriteLine("Please enter an integer in: (1-100)(no decimals)");
                    testInt = Console.ReadLine();
                }
            }
            return validInt;

        }

        static void RunApp()
        {
            //variable declaration
            int userNumber;
            char loopBreaker;
            string userName;
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();

            do
            {
                //Prompt user for number entry
                Console.WriteLine("Please enter an integer in: (1-00)(no decimals)");
                userNumber = ConfirmInt(Console.ReadLine());
                


                if (userNumber < 0 || userNumber > 100)
                {
                    Console.WriteLine($"ERROR: {userName} you have entered an invalid number");
                    Console.WriteLine("Please enter an integer in: (1-00)");
                    userNumber = int.Parse(Console.ReadLine());

                }

                if (userNumber % 2 == 1)
                {
                    Console.WriteLine($" {userName} The integer you entered: {userNumber} is odd");
                    Console.ReadLine();
                    if (userNumber > 60)
                    {
                        Console.WriteLine($"{userName} The number entered: {userNumber} is odd and greater than 60");
                        Console.ReadLine();
                    }
                }

                else if (userNumber % 2 == 0)
                {
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine($"{userName} The number entered is even and in the range of 2-25");
                        Console.ReadLine();
                    }
                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine($"{userName} The number you have entered is even and in the range of 26-60");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{userName} The number entered is: {userNumber} and it is even and greater than 60");
                        Console.ReadLine();
                    }
                }

                Console.WriteLine("Continue? (y/n): ");
                loopBreaker = IsValidLoopBreaker(Console.ReadLine());
            } while (loopBreaker == 'y');
        }
        static void Main(string[] args)
        {
            try
            {
                RunApp();
                Console.WriteLine("End of the Application");
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw (e);
            }

            finally
            {
                Console.WriteLine("The application has failed and is shutting down");
            }

           

        }
    }
}
