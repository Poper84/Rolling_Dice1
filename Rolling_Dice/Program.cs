using System;

Console.WriteLine("Welcome to the dice throwing simulator!");

Console.Write("How many dice rolls would you like to do? ");
int numRolls = int.Parse(Console.ReadLine());

DiceSimulator simulator = new DiceSimulator();
int[] results = simulator.SimulateRolls(numRolls);

Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine($"Total number of rolls = {numRolls}.");

for (int i = 2; i <= 12; i++)
{
    int percentage = (results[i] * 100) / numRolls;
    Console.WriteLine($"{i}: {new string('*', percentage)}");
}

Console.WriteLine("Thank you for using the dice throwing simulator. See ya!");

class DiceSimulator
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
