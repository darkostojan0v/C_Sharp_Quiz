using HierarchicalStructure.Models;
using System;
using System.Collections.Generic;

namespace HierarchicalStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Year = 2008, Make = "Mazda", Model = "3", Color = "blue"},
                new Car(){Year = 2015, Make = "Ford", Model = "Focus", Color = "black"},
                new Car(){Year = 2011, Make = "Fiat", Model = "Punto Evo", Color = "white"},
                new Car(){Year = 2022, Make = "Porsche", Model = "Cayenne Turbo GT", Color = "grey"},
                new Car(){Year = 2000, Make = "BMW", Model = "530", Color = "red"}
            };

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Make} produced the {car.Model} in {car.Year} year. It was available in {car.Color} color.");
            }

            List<Motorcycle> motorcycles = new List<Motorcycle>()
            {
                new Motorcycle() {Year = 2012, Make = "Suzuki", Model = "GSX-R", Color = "white", Horsepower = 182},
                new Motorcycle() {Year = 2005, Make = "Yamaha", Model = "R6", Color = "red", Horsepower = 108},
                new Motorcycle() {Year = 2020, Make = "Kawasaki", Model = "z900", Color = "black", Horsepower = 124}
            };

            foreach(var motorcycle in motorcycles)
            {
                Console.WriteLine($"{motorcycle.Make} {motorcycle.Model} from {motorcycle.Year} year has {motorcycle.Horsepower} horsepower.");
            }

            List<Helicopter> helicopters = new List<Helicopter>()
            {
                new Helicopter() {Year = 1975, Name = "Boeing AH-64 Apache", Price = "$13 milion", NumberBuild = 2400},
                new Helicopter() {Year = 2001, Name = "AgustaWestland AW139", Price = "$6 milion", NumberBuild = 1100}
            };

            foreach(var helicopter in helicopters)
            {
                Console.WriteLine($"More than {helicopter.NumberBuild} {helicopter.Name} had been sold by {helicopter.Year} year. One cost around {helicopter.Price}.");
            }

            Console.ReadLine();

        }
    }
}
