using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04_Snowwhite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Dwarf> dwarfsData = Reader();

            ExecuteProgram(dwarfsData);
        }

        private static void ExecuteProgram(List<Dwarf> dwarfsData)
        {
            foreach (var dwarf in dwarfsData.OrderByDescending(p => p.Physics).ThenByDescending(d => d.HatColor.GroupBy(n => n).Count()))
            {
                Console.WriteLine(dwarf);
            }
        }

        private static List<Dwarf> Reader()
        {
            List<Dwarf> dwarfsData = new List<Dwarf>();

            string command;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                var cmdArgs = command.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                string hatColor = cmdArgs[1];
                int physics = int.Parse(cmdArgs[2]);

                Dwarf dwarf = new Dwarf();

                if (dwarfsData.Any(d => d.Name == name 
                                        && d.HatColor == hatColor 
                                        && d.Physics < physics))
                {

                    dwarf = dwarfsData.Find(d => d.Name == name && d.HatColor == hatColor);

                    dwarf.Physics = physics;
                }
                else
                {
                    dwarf = new Dwarf(name, hatColor, physics);

                    dwarfsData.Add(dwarf);
                }
            }

            return dwarfsData;
        }

    }

    public class Dwarf
    {
        public Dwarf()
        {

        }

        public Dwarf(string name, string hatColor, int physics)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physics = physics;
        }

        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }

        public override string ToString()
        {
            return $"({HatColor}) {Name} <-> {Physics}";
        }
    }
}
