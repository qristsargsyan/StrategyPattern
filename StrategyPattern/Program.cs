using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");            
            string userStrategy = Console.ReadLine().ToLower();
            Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");

            switch (userStrategy)
            {
                case "car":
                    new TravelStrategy(new CarStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                case "bike":
                    new TravelStrategy(new BikeStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                case "bus":
                    new TravelStrategy(new BusStrategy()).GetTravelTime("Point A", "Point B");
                    break;
                default:
                    Console.WriteLine("You have chosen an invalid mode of transport.");
                    break;
            }
        }
    }
}
