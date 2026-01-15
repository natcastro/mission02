// See https://aka.ms/new-console-template for more information

namespace Mission2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How Many dice rolls would you like to simulate?");
            int rolls = int.Parse(Console.ReadLine());
            
            //calling the second class
            DiceRoller diceRoller = new DiceRoller();
            int[] results = diceRoller.RollDice(rolls);
            
            Console.WriteLine("DICE ROLLING SIMULATOR RESULTS:");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls. ");
            Console.WriteLine($"Total number of rolls = {rolls}.");
            
            // here the math for loop to show the 1% * 
            for (int sum = 2; sum <= 12; sum++)
            {
                double percentage = (double)results[sum] / rolls * 100.0;
                int stars = (int)Math.Round(percentage); // if the answer is 4.3 we wil get 4 
                
                Console.Write($"{sum}: ");
                for (int i = 0; i < stars; i++)// so if we have 4 it would show as ****
                {
                    Console.Write("*");
                } 
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye! ");
        }
    }
}

