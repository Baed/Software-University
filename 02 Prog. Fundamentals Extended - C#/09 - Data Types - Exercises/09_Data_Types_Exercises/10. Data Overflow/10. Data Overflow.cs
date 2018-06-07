using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            ulong minNum = Math.Min(num1, num2);
            ulong maxNum = Math.Max(num1, num2);

            decimal overflowValue = 0;
            string smallerType = "";

            if (minNum <= byte.MaxValue)
            {
                overflowValue = byte.MaxValue;
                smallerType = "byte";
            }
            else if (minNum <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue;
                smallerType = "ushort";
            }
            else if (minNum <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue;
                smallerType = "uint";
            }
            else if (minNum <= ulong.MaxValue)
            {
                overflowValue = ulong.MaxValue;
                smallerType = "ulong";
            }
            //
            string biggerType = "";
            if (maxNum <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (maxNum <= ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (maxNum <= uint.MaxValue)
            {
                biggerType = "uint";
            }
            else if (maxNum <= ulong.MaxValue)
            {
                biggerType = "ulong";
            }
            decimal overflowCounter = (maxNum / overflowValue);
            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{maxNum} can overflow {smallerType} {Math.Round(overflowCounter)} times");
        }
    }
}
