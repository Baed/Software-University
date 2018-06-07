using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int jewelsPrice = arrNums[0];
            int goldPrice = arrNums[1];

            int scoreHeist = 0;
            int expenses = 0;

            string command;
            while ((command = Console.ReadLine()) != "Jail Time")
            {
                string[] tokens = command.Split(' ');

                string loot = tokens[0];
                int heistExpenses = int.Parse(tokens[1]);

                scoreHeist += loot.ToString().Count(a => a.Equals('%')) * jewelsPrice;
                scoreHeist += loot.ToString().Count(a => a.Equals('$'))  * goldPrice;

                expenses += heistExpenses;
            }

            Console.WriteLine(expenses <= scoreHeist ? $"Heists will continue. Total earnings: {scoreHeist - expenses}." : $"Have to find another job. Lost: {expenses - scoreHeist}.");
        }
    }
}
