namespace E01_Generic_Box_of_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp  // + E02
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var box = new Box<int>(int.Parse(input));

                Console.WriteLine(box.ToString());
            }
        }
    }
}

