using System;

public class DiceSimulator
{
    private Random random = new Random();

    public int[] SimulateRolls(int numRolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < numRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
