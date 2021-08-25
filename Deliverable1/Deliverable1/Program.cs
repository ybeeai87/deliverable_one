using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {   //values


            bool tryAgain = true;



            //output & processes 
            while (tryAgain)
            {
                Console.WriteLine("Welcome to the conversion calculator!");
            Console.WriteLine("Please enter in a measurement type from the following: inch, foot, fidget, meme ");
            string measureType = Console.ReadLine();
            Console.WriteLine("Please enter an amount: ");
            double amount = double.Parse(Console.ReadLine());





                if (measureType == "inch")
                {
                    Console.WriteLine("If you had " + amount + " inches, you would also have " + 3.5 * amount + " fidget spinners");
                }
                else if (measureType == "foot")
                {
                    Console.WriteLine("If you had " + amount + " feet, you would also have " + 5 * amount + " memes");
                }
                else if (measureType =="fidget")
                {
                    Console.WriteLine("If you had " + amount + " fidgets, you would also have " + amount / 3.5 + " inches");
                }
                else
                {
                    Console.WriteLine("If you had " + amount + " memes, you would also have " + amount / 5 + " feet");
                }
                //Ask to try again
                Console.WriteLine("Woud you like to try another calculation? y/n");
                string keepGoing = Console.ReadLine();
                if (keepGoing == "y")
                {
                    tryAgain = true;
                }
                else tryAgain = false;
            }







        }
    }}
