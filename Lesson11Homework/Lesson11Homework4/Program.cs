using System;

namespace Lesson11Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.a = 85;
            car.b = 101;
            car.price = 856.1;
            car.speed = 200;
            car.year = 2015;
            Console.WriteLine($"Coordinate of car is:{car.a};{car.b}.Price of car:{car.price};Speed of car:{car.speed};Year of car:{car.year}");
            Console.WriteLine();
            Plane plane = new Plane();
            plane.a = 1;
            plane.b = 11;
            plane.price = 8526.1;
            plane.speed = 20230;
            plane.year = 1995;
            Console.WriteLine($"Coordinate of plane is:{plane.a};{plane.b}.Price of plane:{plane.price};Speed of plane:{plane.speed};Year of plane:{plane.year};Plane high:{plane.high};Passenger:{plane.passenger}");
            Console.WriteLine();
            Ship ship = new Ship();
            ship.a = 5;
            ship.b = 561;
            ship.price = 12856.1;
            ship.speed = 400;
            ship.year = 2020;
            Console.WriteLine($"Coordinate of ship is:{ship.a};{ship.b}.Price of ship:{ship.price};Speed of ship:{ship.speed};Year of ship:{ship.year};Port:{ship.port};Passenger:{ship.passenger}");
        }
    }
}


