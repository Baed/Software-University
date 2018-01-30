using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctr = 0;
            while (true)
            {
                try
                {
                    string ingredients = Console.ReadLine();
                    if (ingredients == "Bake!")
                    {
                        Console.WriteLine($"Preparing cake with {ctr} ingredients.");
                        break;
                    }
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                    ctr++;
                }
                catch (Exception)
                {
                    
                }
            }
            
        }
    }
}
