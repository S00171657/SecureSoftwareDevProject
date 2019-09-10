using System;
using System.Collections.Generic;

namespace SecureSoftwareDevProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Method method = new Method();

            method.CreateData();
            method.Print();

            Console.ReadLine();
        }
    }

    class Method
    {

        //private List<Vehicle> vehicles;
        private List<Car> cars;
        private List<Van> vans;
        private List<Motorbike> motorbikes;

        public void CreateData()
        {
            cars = new List<Car>()
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
            };

            vans = new List<Van>() {
                new Van()
                {
                    ID = 1,
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
                    ID = 2,
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
                    ID = 3,
                    Make = "Mercedes-Benz",
                    Model = "Sprinter",
                    Colour = "Black",
                    Year = 2014,
                    Price = 14000,
                    EngineSize = 2.1f,
                    Wheelbase = "Large"
                },
                };

            motorbikes = new List<Motorbike>() {
                new Motorbike()
                {
                    ID = 1,
                    Make = "Harley-Davidson",
                    Model = "Softail Slim",
                    Colour = "Blue",
                    Year = 2019,
                    Price = 22000,
                    Type = "Cruiser"
                },
                new Motorbike()
                {
                    ID = 2,
                    Make = "Yamaha",
                    Model = "R1",
                    Colour = "Red",
                    Year = 2009,
                    Price = 6650,
                    Type = "Sports"
                },
                new Motorbike()
                {
                    ID = 3,
                    Make = "Honda",
                    Model = "Goldwing",
                    Colour = "Black",
                    Year = 1997,
                    Price = 5500,
                    Type = "Tourer"
                }
            };
        }

        public void Print()
        {
            Console.WriteLine("1. View Table \n2. Add Entry \n3. Exit\n");

            Console.Write("Option: ");

            int option = int.Parse(Console.ReadLine());

            Console.Clear();

            if (option == 1)
            {
                PrintTable();
            }
            else if(option == 2)
            {
                AddEntry();
            }
            else if(option == 3)
            {
                Environment.Exit(0);
            }
            

        }

        public void PrintTable()
        {
            string table = "|{0, -3}|{1, -15}|{2, -15}|{3, -15}|{4, -15}|{5, -15}|{6, -15}|{7, -15}|";

            Console.WriteLine("--CARS--");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "Model", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "BODY-TYPE"));

            Console.WriteLine();

            foreach (Car c in cars)
            {
                Console.WriteLine(String.Format(table, c.ID, c.Make, c.Model, c.Colour, c.Year, c.Price, c.EngineSize, c.BodyType));
            }

            Console.WriteLine();

            Console.WriteLine("--VANS--");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "Model", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "WHEELBASE"));

            Console.WriteLine();

            foreach (Van v in vans)
            {
                Console.WriteLine(String.Format(table, v.ID, v.Make, v.Model, v.Colour, v.Year, v.Price, v.EngineSize, v.Wheelbase));
            }

            Console.WriteLine();

            Console.WriteLine("--MOTORBIKES--");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "Model", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "TYPE"));

            Console.WriteLine();

            foreach (Motorbike m in motorbikes)
            {
                Console.WriteLine(String.Format(table, m.ID, m.Make, m.Model, m.Colour, m.Year, m.Price, m.EngineSize, m.Type));
            }

            Console.WriteLine("\n1: Add Vehicle   2.Edit Vehicle   3.Delete Vehicle   4.Read txt File   0. Exit");

            Console.Write("\nOption: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if(option == 1)
            {
                AddEntry();
            }
            else if (option == 2)
            {
                EditVehicle();
            }
            else if (option == 3)
            {
                DeleteVehicle();
            }
            else if (option == 0)
            {
                Environment.Exit(0);
            }
        }

        public void AddEntry()
        {
            Console.WriteLine("What type of vehicle do you want to add?\n1.Car  2.Van   3.Motorbike");

            Console.Write("\nOption: ");

            int option = int.Parse(Console.ReadLine());

            Console.Clear();

            if(option == 1)
            {
                Console.WriteLine("--CAR--\n");

                Car c = new Car();

                c.ID = cars.Count + 1;

                Console.Write("Make: ");
                c.Make = Console.ReadLine();

                Console.Write("Model: ");
                c.Model = Console.ReadLine();

                Console.Write("Colour: ");
                c.Colour = Console.ReadLine();

                Console.Write("Year: ");
                c.Year = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                c.Price = float.Parse(Console.ReadLine());

                Console.Write("Engine-Size: ");
                c.EngineSize = float.Parse(Console.ReadLine());

                Console.Write("Body-Type: ");
                c.BodyType = Console.ReadLine();

                cars.Add(c);
            }
            else if (option == 2)
            {
                Console.WriteLine("--VAN--\n");

                Van v = new Van();

                v.ID = vans.Count + 1;

                Console.Write("Make: ");
                v.Make = Console.ReadLine();

                Console.Write("Model: ");
                v.Model = Console.ReadLine();

                Console.Write("Colour: ");
                v.Colour = Console.ReadLine();

                Console.Write("Year: ");
                v.Year = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                v.Price = float.Parse(Console.ReadLine());

                Console.Write("Engine-Size: ");
                v.EngineSize = float.Parse(Console.ReadLine());

                Console.Write("Wheel-base: ");
                v.Wheelbase = Console.ReadLine();

                vans.Add(v);
            }
            else if (option == 3)
            {
                Console.WriteLine("--MOTORBIKE--\n");

                Motorbike m = new Motorbike();

                m.ID = vans.Count + 1;

                Console.Write("Make: ");
                m.Make = Console.ReadLine();

                Console.Write("Model: ");
                m.Model = Console.ReadLine();

                Console.Write("Colour: ");
                m.Colour = Console.ReadLine();

                Console.Write("Year: ");
                m.Year = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                m.Price = float.Parse(Console.ReadLine());

                Console.Write("Engine-Size: ");
                m.EngineSize = float.Parse(Console.ReadLine());

                Console.Write("Type: ");
                m.Type = Console.ReadLine();

                motorbikes.Add(m);
            }

            Console.Clear();

            PrintTable();
        }

        public void EditVehicle()
        {
            Console.WriteLine("What type of vehicle do you want to edit?\n1.Car  2.Van   3.Motorbike");

            Console.Write("\nOption: ");

            int option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Console.Write("\nEnter the car's ID number: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Car car in cars)
                {
                    if(car.ID == id)
                    {
                        Console.Write("\nWhat field do you want to edit?\n1. Make\n2. Model\n3. Colour\n4. Year\n5. Price\n6.Engine-Size\n7. Body-Type\nOption: ");
                        int opt = int.Parse(Console.ReadLine());

                        Console.Write("\nNew field: ");
                        string field = Console.ReadLine();

                        if(opt == 1)
                        {
                            car.Make = field;
                        }
                        else if (opt == 2)
                        {
                            car.Model = field;
                        }
                        else if (opt == 3)
                        {
                            car.Colour = field;
                        }
                        else if (opt == 4)
                        {
                            car.Year = int.Parse(field);
                        }
                        else if (opt == 5)
                        {
                            car.Price = float.Parse(field);
                        }
                        else if (opt == 6)
                        {
                            car.EngineSize = float.Parse(field);
                        }
                        else if (opt == 7)
                        {
                            car.BodyType = field;
                        }
                    }
                }
            }
            else if (option == 2)
            {
                Console.Write("\nEnter the van's ID number: ");
                int id = int.Parse(Console.ReadLine());
            }
            else if (option == 3)
            {
                Console.Write("\nEnter the motorbikes's ID number: ");
                int id = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            PrintTable();
        }

        public void DeleteVehicle()
        {
            Console.WriteLine("What type of vehicle do you want to delete?\n1.Car  2.Van   3.Motorbike");

            Console.Write("\nOption: ");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("\nEnter the car's ID number: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Car car in cars)
                {
                    if (car.ID == id)
                    {
                        cars.Remove(car);
                    }
                }
            }
            else if (option == 2)
            {
                Console.Write("\nEnter the van's ID number: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Van van in vans)
                {
                    if (van.ID == id)
                    {
                        vans.Remove(van);
                    }
                }
            }
            else if (option == 3)
            {
                Console.Write("\nEnter the motorbikes's ID number: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Motorbike motorbike in motorbikes)
                {
                    if (motorbike.ID == id)
                    {
                        motorbikes.Remove(motorbike);
                    }
                }
            }

            Console.Clear();
            PrintTable();
        }
    }
}
