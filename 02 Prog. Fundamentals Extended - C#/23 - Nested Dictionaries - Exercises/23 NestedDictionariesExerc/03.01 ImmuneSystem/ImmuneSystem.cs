using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {

            var imuneSystemLog = new List<string>();

            var knownViruses = new List<string>();

            int maxHealth = int.Parse(Console.ReadLine());
            int currentHealth = maxHealth;

            string command;
            while ((command = Console.ReadLine()) != "end" && currentHealth > 0)
            {
                string virusName = command;
                int virusStrenght = command.Sum(x => x);
                virusStrenght /= 3;

                int defeatTimeSeconds = virusStrenght * virusName.Length;

                defeatTimeSeconds =
                    knownViruses.Contains(virusName) ?
                    defeatTimeSeconds / 3 :
                    defeatTimeSeconds;

                currentHealth -= defeatTimeSeconds;

                if (currentHealth <= 0)
                {
                    imuneSystemLog.Add($"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds");
                    continue;
                }

                var defeatTime = CalcDefeatTime(defeatTimeSeconds);

                knownViruses.Add(virusName);

                var result = $"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds\n";
                result += $"{virusName} defeated in {defeatTime}.\n";
                result += $"Remaining health: {currentHealth}";

                imuneSystemLog.Add(result);
                currentHealth =
                    (int)(currentHealth * 1.2) > maxHealth ?
                    maxHealth :
                    (int)(currentHealth * 1.2);
            }

            foreach (var entry in imuneSystemLog)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(
                currentHealth < 0 ?
                "Immune System Defeated." :
                $"Final Health: {currentHealth}");
        }

        static string CalcDefeatTime(int defeatTimeSeconds)
        {
            var result = (defeatTimeSeconds / 60) + "m ";
            result += (defeatTimeSeconds % 60) + "s";
            return result;
        }
    }
}
