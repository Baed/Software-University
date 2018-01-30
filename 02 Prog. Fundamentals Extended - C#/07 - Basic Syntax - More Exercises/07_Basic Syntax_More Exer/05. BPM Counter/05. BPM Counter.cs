using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BMP = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            // logika za prevrushtane na edinici v minuti i secundi
            var seconds = beats * 60.0 / BMP;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.WriteLine($"{Math.Round(beats / 4.0, 1)} bars - {minutes:d1}m {Math.Floor(seconds)}s");
        }
    }
}
