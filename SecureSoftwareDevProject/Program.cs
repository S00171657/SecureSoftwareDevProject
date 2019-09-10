using System;
using System.Collections.Generic;

namespace SecureSoftwareDevProject
{
    class Program
    {
        static private List<Vehicle> vehicles;

        static void Main(string[] args)
        {
            Print();

            Console.ReadLine();
        }

        static public void CreateData()
        {
            vehicles = new List<Vehicle>()
            {
                new Car()
                {
                    ID = 1,
                    Make = "Dodge",
                    Model = "Challenger",
                    Colour = "Green",
                    Year = 1970,
                    Price = 47995,
                    EngineSize = 6.2f,
                    BodyType = "Coupe"
                },
                new Car()
                {
                    ID = 2,
                    Make = "Subaru",
                    Model = "Impreza",
                    Colour = "Blue",
                    Year = 2008,
                    Price = 2700,
                    EngineSize = 2.0f,
                    BodyType = "Hatchback"
                },
                new Car()
                {
                    ID = 3,
                    Make = "Mercedes-Benz",
                    Model = "E 350",
                    Colour = "White",
                    Year = 2010,
                    Price = 10000,
                    EngineSize = 3.5f,
                    BodyType = "Sedan"
                },
                new Van()
                {
                    ID = 4,
                    Make = "Ford",
                    Model = "Transit",
                    Colour = "Silver",
                    Year = 2017,
                    Price = 14000,
                    EngineSize = 2.0f,
                    Wheelbase = "Regular"
                },
                new Van()
                {
                    ID = 5,
                    Make = "GMC",
                    Model = "Savana Cargo",
                    Colour = "Blue",
                    Year = 2006,
                    Price = 8000,
                    EngineSize = 5.3f,
                    Wheelbase = "Regular"
                },
                new Van()
                {
                    ID = 6,
                    Make = "Mercedes-Benz",
                    Model = "Sprinter",
                    Colour = "Black",
                    Year = 2014,
                    Price = 14000,
                    EngineSize = 2.1f,
                    Wheelbase = "Large"
                },
                new Motorbike()
                {
                    ID = 7,
                    Make = "Harley-Davidson",
                    Model = "Softail Slim",
                    Colour = "Blue",
                    Year = 2019,
                    Price = 22000,
                    Type = "Cruiser"
                },
                new Motorbike()
                {
                    ID = 8,
                    Make = "Yamaha",
                    Model = "R1",
                    Colour = "Red",
                    Year = 2009,
                    Price = 6650,
                    Type = "Sports"
                },
                new Motorbike()
                {
                    ID = 9,
                    Make = "Honda",
                    Model = "Goldwing",
                    Colour = "Black",
                    Year = 1997,
                    Price = 5500,
                    Type = "Tourer"
                }
            };
        }

        static public void Print()
        {
            CreateData();

            string table = "{0, -5}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}{6, -15}";

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.ID.ToString(), v.Make, v.Model, v.Colour, v.Year, v.Price, v.EngineSize, table);
            }
        }
    }
}
