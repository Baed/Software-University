using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickests = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            bool isMatched = false;

            foreach (string ticket in tickests)
            {
                if (ticket.Length == 20)
                {
                    char[] x = ticket.ToCharArray();

                    var list = new Dictionary<char, List<int>>();

                    int cnt = 0;

                    for (int i = 0; i < x.Length / 2; i++)
                    {

                        if (x[i] == x[i + 1])
                        {
                            cnt++;
                        }
                        else
                        {
                            break;
                        }

                    }

                    if (cnt == 0)
                    {
                        Console.WriteLine($"ticket {ticket} - no match");
                        break;
                    }

                    Console.WriteLine($"ticket {ticket} - {cnt}$");

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
