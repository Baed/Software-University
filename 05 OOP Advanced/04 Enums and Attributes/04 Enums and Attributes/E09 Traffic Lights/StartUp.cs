namespace E09_Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<TrafficLight> allTrafficLights = new List<TrafficLight>();

            string[] inputSignal = Console.ReadLine().Split(' ');

            foreach (var signal in inputSignal)
            {
                Lights initialColorState = (Lights)Enum.Parse(typeof(Lights), signal);

                allTrafficLights.Add(new TrafficLight(initialColorState));
            }

            int changeCountOfState = int.Parse(Console.ReadLine());

            for (int i = 0; i < changeCountOfState; i++)
            {
                foreach (var trafficLight in allTrafficLights)
                {
                    trafficLight.ChangeState();
                }

                Console.WriteLine(string.Join(" ", allTrafficLights));
            }
        }
    }
}