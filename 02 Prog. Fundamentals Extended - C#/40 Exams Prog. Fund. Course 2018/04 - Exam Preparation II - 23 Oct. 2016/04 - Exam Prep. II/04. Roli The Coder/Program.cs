using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Event> eventsData = new Dictionary<int, Event>();

            string command;
            while ((command = Console.ReadLine()) != "Time for Code")
            {
                var cmdArgs = command.Split(new[] { " ", "\t", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (!cmdArgs[1].Contains("#")) continue;

                int id = int.Parse(cmdArgs[0]);
                string eventName = string.Join("", cmdArgs[1].Skip(1).ToArray());

                if (eventsData.ContainsKey(id) && !eventsData[id].Name.Equals(eventName))
                {
                    continue;
                }

                if (eventsData.ContainsKey(id) && eventsData[id].Name.Equals(eventName))
                {
                    for (int i = 2; i < cmdArgs.Length; i++)
                    {
                        if (!eventsData[id].Participants.Contains(cmdArgs[i]))
                        {
                            eventsData[id].Participants.Add(cmdArgs[i]);
                        }
                    }
                }

                else // (!eventsData.ContainsKey(id) && !eventsData[id].Name.Equals(eventName)) 
                {
                    Event events = new Event(eventName);

                    for (int i = 2; i < cmdArgs.Length; i++)
                    {
                        if (cmdArgs[i].Contains("@"))
                        {
                            if (!events.Participants.Contains(cmdArgs[i]))
                            {
                                events.Participants.Add(cmdArgs[i]);
                            }
                        }
                    }

                    eventsData[id] = events;
                }
            }

            foreach (var @event in eventsData.OrderByDescending(v => v.Value.Participants.Count).ThenBy(v => v.Value.Name))
            {
                Console.WriteLine($"{@event.Value.Name} - {@event.Value.Participants.Count}");

                foreach (var item in @event.Value.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    class Event
    {
        public Event(string name)
        {
            Name = name;
            Participants = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }
}
