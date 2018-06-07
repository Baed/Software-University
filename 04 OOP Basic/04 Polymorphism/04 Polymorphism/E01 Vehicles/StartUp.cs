namespace E01_Vehicles // include E02 Vehicles Extended
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(' ');
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split(' ');
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split(' ');
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            
            int cmdNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < cmdNum; i++)
            {
                try
                {
                    var tokens = Console.ReadLine().Split(' ');

                    var vehicleType = tokens[1];

                    if (vehicleType == "Car")
                    {
                        ExecuteAction(car, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecuteAction(truck, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (vehicleType == "Bus")
                    {
                        ExecuteAction(bus, tokens[0], double.Parse(tokens[2]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    var driveResult = vehicle.TryTravelDistance(parameter); // with pasenger
                    Console.WriteLine(driveResult);
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);                
                    break;
                case "DriveEmpty": // without pasenger
                    var emptyResult = vehicle.TryTravelDistance(parameter, false);
                    Console.WriteLine(emptyResult);
                    break;
            }
        }
    }
}
