using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TeaPhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPic = int.Parse(Console.ReadLine());
            int amountOfFilterTime = int.Parse(Console.ReadLine());
            int filFactorInPercent = int.Parse(Console.ReadLine());
            int amountOfTimeToUpload = int.Parse(Console.ReadLine());

            double usefulPic = Math.Ceiling(numOfPic * (filFactorInPercent / 100.0));
            double totalPic = (double)numOfPic * amountOfFilterTime;
            double filtredPic = (double)usefulPic * amountOfTimeToUpload;

            double result = (double)(totalPic + filtredPic);

            TimeSpan time = TimeSpan.FromSeconds(result);
            string str = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(str);
        }
    }
}
