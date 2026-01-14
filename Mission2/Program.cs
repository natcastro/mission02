// See https://aka.ms/new-console-template for more information
namespace Mission2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");
            int rolls = int.Parse(Console.ReadLine());

            // Llamar a la segunda clase
            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(rolls); // results[2]..results[12] usados

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}.\n");

            // Imprimir histograma 2..12
            for (int sum = 2; sum <= 12; sum++)
            {
                double percent = (double)results[sum] / rolls * 100.0;
                int stars = (int)Math.Round(percent); // redondea a entero

                Console.Write($"{sum}: ");
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator.  Goodbye!");
        }
    }
}
//hey new comment