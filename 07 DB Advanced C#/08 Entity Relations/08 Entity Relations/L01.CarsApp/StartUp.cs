using System;
using System.Collections.Generic;
using System.Linq;
using L01.Cars.Data;
using L01.Cars.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace L01.CarsApp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new CarsDbContext())
            {
                // CreateDatabase(context);

                var carsList = context.Cars
                    .Include(c => c.Engine)
                    .Include(c => c.Make)
                    .Include(c => c.LicensePlate)
                    .Include(c => c.CarsDealerships)
                    .ThenInclude(cd => cd.Dealership)
                    .OrderBy(c => c.ProductionYear)
                    .ToArray();

                foreach (var car in carsList)
                {
                    foreach (var carCarsDealership in car.CarsDealerships)
                    {
                        Console.WriteLine($"-:-:- {carCarsDealership.Dealership.Name} -:-:-");
                    }

                    Console.WriteLine($"{car.Make.Name.ToUpper()} {car.Model}");
                    Console.WriteLine($"--Fuel: {car.Engine.FuelType}");
                    Console.WriteLine($"--Transmission: {car.Transmission}");
                    var licensePlateNum = car.LicensePlate != null ? car.LicensePlate.Number : $"No Number";
                    Console.WriteLine($"--PlateNumber: {licensePlateNum}");
                    Console.WriteLine();
                }
            }
        }

        private static void CreateDatabase(CarsDbContext context)
        {
            context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(CarsDbContext context)
        {
            var makesList = new List<Make>()
            {
                new Make("Ford"),
                new Make("Mercedes"),
                new Make("Audi"),
                new Make("Lada"),
                new Make("BMW"),
                new Make("Toyota"),
            };

            context.Makes.AddRange(makesList);

            var engineList = new List<Engine>()
            {
                new Engine(1.6, FuelType.Petrol, 6, 97),
                new Engine(3.5, FuelType.Diesel, 12, 105),
                new Engine(2.2, FuelType.Gas, 6, 200),
                new Engine(1.8, FuelType.Petrol, 6, 55),
                new Engine(1.1, FuelType.Electric, 6, 400),
                new Engine(4.5, FuelType.Diesel, 6, 75),
            };

            context.Engines.AddRange(engineList);

            var carsList = new List<Car>()
            {
                new Car(makesList[0], "Escort", engineList[0], 4, Transmission.Manual, new DateTime(1992/12/12)),
                new Car(makesList[1], "GLK230", engineList[1], 3, Transmission.Automatic, new DateTime(2016/7/12)),
                new Car(makesList[2], "R8", engineList[2], 6, Transmission.Automatic, new DateTime(2008/4/25)),
                new Car(makesList[3], "Samara", engineList[3], 8, Transmission.Manual, new DateTime(1986/6/13)),
                new Car(makesList[4], "X5-M50", engineList[4], 6, Transmission.Automatic, new DateTime(1999/9/9)),
                new Car(makesList[5], "Corola", engineList[5], 4, Transmission.Manual, new DateTime(2004/10/10)),
            };

            context.Cars.AddRange(carsList);

            var dealershipsList = new List<Dealership>()
            {
                new Dealership("Niko-Auto"),
                new Dealership("SesiCars-Auto"),
            };

            context.Dealerships.AddRange(dealershipsList);

            var carDealershipsList = new List<CarDealership>()
            {
                new CarDealership(carsList[0], dealershipsList[0]),
                new CarDealership(carsList[1], dealershipsList[1]),
                new CarDealership(carsList[2], dealershipsList[0]),
                new CarDealership(carsList[3], dealershipsList[1]),
                new CarDealership(carsList[4], dealershipsList[1]),
                new CarDealership(carsList[5], dealershipsList[0]),
            };

            context.CarDealerships.AddRange(carDealershipsList);

            var licensePlateList = new List<LicensePlate>()
            {
                new LicensePlate("CA1234KB"),
                new LicensePlate("PB1122AK"),
                new LicensePlate("CB1331AT"),
                new LicensePlate("PK5671CB"),
                new LicensePlate("CT1121BB"),
                new LicensePlate("PK3881AA"),
            };

            context.LicensePlates.AddRange(licensePlateList);

            context.SaveChanges();
        }
    }
}
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Drop-Database
// Update-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"
