using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] matrix = GetMatrix();
            ReadCommands(matrix);
        }

        private static void ReadCommands(bool[][] matrix)
        {
            string command = Console.ReadLine().Trim();
            // https://pastebin.com/0SeEK9iZ 
            // https://github.com/Pilgrimage/SU_m31_CSharp-Advanced-2017.05/blob/master/Ch03_Matrices/p11_ParkingSystem/ParkingSystem.cs
            while (command != "stop")
            {
                int[] tokens = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var etryRow = tokens[0];
                var targetRow = tokens[1];
                var targetCol = tokens[2];

                command = Console.ReadLine().Trim();
            }
        }

        private static bool[][] GetMatrix()
        {
            int[] dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool[][] matrix = new bool[dimentions[0]][].Select(row => row = new bool[dimentions[1]]).ToArray();

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = true;
            }
            return matrix;
        }
    }
}
