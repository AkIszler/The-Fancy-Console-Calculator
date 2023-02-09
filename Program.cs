using System.Security.Cryptography.X509Certificates;

namespace FancyConsoleCalculatorApp
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|                                        |");
            Console.WriteLine("{ Welcome To the Facny Calcululator App! }");
            Console.WriteLine("|                                        |");
            Console.WriteLine("------------------------------------------");
            // break up the top part
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Do you wanna do some math Mr Fancy? Y/N");
            string yesOrNo = Console.ReadLine();
            string uppercheck = yesOrNo.ToUpper();

            // Setting up the calc system
                if (uppercheck == "Y")
                {
                CalculatorFunctions(args);
                }

                else if (uppercheck == "N")
                {
                    Console.WriteLine("Oh I'm sorry to hear that, press any key to close this program");
                    Console.Read();
                }

                else
                {
                    Console.WriteLine("thats not a valid answer");
                    Console.Clear();
                    Main(args);
                }
                                  
        }

        public static void CalculatorFunctions(string[] args)
        {
            // settting the variables 
            double firstNumber = 0;
            double secondNumber = 0;
            double answerOfMaths = 0;
            string theMaths;
            
            // ask for the numbers and get the answers my dude
            Console.WriteLine("Awesome, lets go!");
            Console.WriteLine("Pick your first nubmber!");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("and whats your second number?");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Awesome Choices Fancy Pants, Now what are we doing with them?");
            //figure out what they wanna do
            Console.WriteLine("\t If your adding use +");
            Console.WriteLine("\t If you wanna subtract use -");
            Console.WriteLine("\t If you wanna Multiply use *");
            Console.WriteLine("\t OR if you wanna divide use /");

            // switch statement to do the maths 
            switch (Console.ReadLine())
            {
                case "+":
                    answerOfMaths = firstNumber + secondNumber;
                   Console.WriteLine($"Your Fancy answer is.... " + answerOfMaths);
                    break;
                        
                case "-":
                    answerOfMaths = firstNumber - secondNumber;
                    Console.WriteLine($"Your Fancy answer is.... " + answerOfMaths);
                    break;

                case "*":
                    answerOfMaths = firstNumber * secondNumber;
                    Console.WriteLine($"Your Fancy answer is.... " + answerOfMaths);
                    break;

                case "/":
                    answerOfMaths = firstNumber / secondNumber;
                    Console.WriteLine($"Your Fancy answer is.... " + answerOfMaths);
                    break;

                default : Console.WriteLine("that wasnt a valid entry");
                    break;
            }
            Console.WriteLine("Do you wanna do some more maths?!?!");
            string wannaGoAgain = Console.ReadLine();
            string checkforLower = wannaGoAgain.ToLower();

            if (checkforLower == "y")
            {
                Console.Clear();
                CalculatorFunctions(args);
            }
            
            else if (checkforLower == "n") 
            {
                Console.WriteLine("Okay than, I hope you had fun!!!! Press any key to end the program");
                Console.ReadKey();
            }
            
            else 
            { 
                Console.WriteLine("that was not a valid answer, this program will now close....");
                Console.WriteLine("Closing program");
               
            }
            
        }
    }
}