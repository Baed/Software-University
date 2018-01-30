using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakePieces = width * lenght;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int takenPieces = int.Parse(command);
                cakePieces -= takenPieces;

                if (cakePieces < 0)
                {
                    break;
                }

                command = Console.ReadLine();

            }
            Console.WriteLine(cakePieces >= 0 ? $"{cakePieces} pieces are left." : $"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            // тернарен оператор if-else (съкратен вариант)
            // izpit 3 sept
        }
    }
}
