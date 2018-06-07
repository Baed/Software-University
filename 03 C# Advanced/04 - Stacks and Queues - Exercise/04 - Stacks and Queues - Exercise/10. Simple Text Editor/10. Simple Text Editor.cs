using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            string text = string.Empty;
            var stack = new Stack<string>();

            for (int i = 0; i < cnt; i++)
            {
                var tokens = Console.ReadLine()
                        .Trim()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int operation = int.Parse(tokens[0]);

                switch (operation)
                {
                    case 1:
                        stack.Push(text);
                        text += tokens[1];
                        break;
                    case 2:
                        stack.Push(text);
                        int symbolsToRemove = int.Parse(tokens[1]);
                        text = text.Substring(0, text.Length - symbolsToRemove);
                        break;
                    case 3:
                        int index = int.Parse(tokens[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
