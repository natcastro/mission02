namespace Mission2
{
    internal class DiceRoller
    {
        public int[] RollDice(int rolls)
        {
            int[] counts = new int[13]; // índices 0..12, we will be using 2..12
            Random random = new Random();

            for (int i = 0; i < rolls; i++)
            {
                int die1 = random.Next(1, 7); // 1..6
                int die2 = random.Next(1, 7); // 1..6
                int sum = die1 + die2;

                counts[sum]++; // this counts how many time the sum appeared
            }

            return counts;
        }
    }
}