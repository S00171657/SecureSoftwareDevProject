using System;
using System.Collections.Generic;
using System.IO;
using static SecureSoftwareDevProject.UserRole;

namespace SecureSoftwareDevProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Method method = new Method();
            
            method.Login();
        }
    }

    class Method
    {
        private List<Car> cars;
        private List<Van> vans;
        private List<Motorbike> motorbikes;
        private List<UserRole> userRoles;
        public UserRole activeUser;

        private void CreateUsers()
        {
            userRoles = new List<UserRole>()
            {
                new UserRole()
                {
                    UserName = "JDoe",
                    Password = "Donedeal",
                    Position = Role.Admin
                },
                new UserRole()
                {
                    UserName = "WSmith",
                    Password = "Freshprince",
                    Position = Role.Manager
                },
                new UserRole()
                {
                    UserName = "ECartman",
                    Password = "Southpark",
                    Position = Role.Employee

                }
            };
        }//Creates List of users and roles

        public void Login()
        {
            CreateUsers();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("--USER LOGIN--\n");

                Console.Write("Username: ");
                string user = Console.ReadLine();

                Console.Write("Password: ");
                string password = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                        {
                            password = password.Substring(0, (password.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true); //Password Masker


                foreach (UserRole u in userRoles)
                {
                    if(user == u.UserName && password == u.Password)
                    {
                        Console.Clear();
                        activeUser = u;
                        CreateData();
                        Menu();
                    }
                }

                Console.Clear();

                Console.WriteLine("Invalid login please try again\n");
            }

            Console.Write("Credentials entered incorrectly too many times. Press Enter to exit.");
        }//Login Screen

        private void CreateData()
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
        }//Creates list of vehicles

        private void Menu()
        {
            Console.WriteLine("--SECURE SOFTWARE DEVELOPEMENT PROJECT--\n\n1. View Table\n0. Exit\n");

            Console.Write("Option: ");

            int option = int.Parse(Console.ReadLine());

            Console.Clear();

            if (option == 1)
            {
                PrintTable();
            }
            else if(option == 0)
            {
                Environment.Exit(0);
            }
            

        }//Menu with view list option and exit application

        private void PrintTable()
        {
            string table = "|{0, -3}|{1, -15}|{2, -15}|{3, -15}|{4, -15}|{5, -15}|{6, -15}|{7, -15}|";

            Console.WriteLine("--CARS--\n");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "MODEL", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "BODY-TYPE"));

            Console.WriteLine();

            foreach (Car c in cars)
            {
                Console.WriteLine(String.Format(table, c.ID, c.Make, c.Model, c.Colour, c.Year, c.Price, c.EngineSize, c.BodyType));
            }

            Console.WriteLine();

            Console.WriteLine("--VANS--\n");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "MODEL", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "WHEELBASE"));

            Console.WriteLine();

            foreach (Van v in vans)
            {
                Console.WriteLine(String.Format(table, v.ID, v.Make, v.Model, v.Colour, v.Year, v.Price, v.EngineSize, v.Wheelbase));
            }

            Console.WriteLine();

            Console.WriteLine("--MOTORBIKES--\n");

            Console.WriteLine(String.Format(table, "ID", "MAKE", "MODEL", "COLOUR", "YEAR", "PRICE", "ENGINE-SIZE", "TYPE"));

            Console.WriteLine();

            foreach (Motorbike m in motorbikes)
            {
                Console.WriteLine(String.Format(table, m.ID, m.Make, m.Model, m.Colour, m.Year, m.Price, m.EngineSize, m.Type));
            }

            Console.WriteLine("\nOptions with *()* around it are unavailable to the current user.");

            if(activeUser.Position == Role.Admin)
                Console.WriteLine("\n1: Add Vehicle   2.Edit Vehicle   3.Delete Vehicle   4.Read txt File   5.Save to txt File  0. Exit");
            else if (activeUser.Position == Role.Manager)
                Console.WriteLine("\n1: Add Vehicle   2.Edit Vehicle   *(3.Delete Vehicle)*   4.Read txt File   5.Save to txt File  0. Exit");
            else if (activeUser.Position == Role.Employee)
                Console.WriteLine("\n1: Add Vehicle   *(2.Edit Vehicle)*   *(3.Delete Vehicle)*   4.Read txt File   5.Save to txt File  0. Exit");

            for (int i = 0; i < 100; i++)
            {
                Console.Write("\nOption: ");
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if(option == 1)
                {
                    AddVehicle();
                }
                else if (option == 2)
                {
                    if(activeUser.Position != Role.Employee)
                    {
                        EditVehicle();
                    }
                    else
                    {
                        Console.WriteLine("Unavailable to user");
                    }
                }
                else if (option == 3)
                {
                    if (activeUser.Position == Role.Admin)
                    {
                        DeleteVehicle();
                    }
                    else
                    {
                        Console.WriteLine("Unavailable to user");
                    }
                }
                else if(option == 5)
                {
                    WriteTextFile();
                }
                else if (option == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }

        }//Prints tables of the three different types of vehicles

        private void AddVehicle()
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
        }//Adds new vehicle to list

        private void EditVehicle()
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

                foreach (Van van in vans)
                {
                    if (van.ID == id)
                    {
                        Console.Write("\nWhat field do you want to edit?\n1. Make\n2. Model\n3. Colour\n4. Year\n5. Price\n6.Engine-Size\n7. Wheelbase\nOption: ");
                        int opt = int.Parse(Console.ReadLine());

                        Console.Write("\nNew field: ");
                        string field = Console.ReadLine();

                        if (opt == 1)
                        {
                            van.Make = field;
                        }
                        else if (opt == 2)
                        {
                            van.Model = field;
                        }
                        else if (opt == 3)
                        {
                            van.Colour = field;
                        }
                        else if (opt == 4)
                        {
                            van.Year = int.Parse(field);
                        }
                        else if (opt == 5)
                        {
                            van.Price = float.Parse(field);
                        }
                        else if (opt == 6)
                        {
                            van.EngineSize = float.Parse(field);
                        }
                        else if (opt == 7)
                        {
                            van.Wheelbase = field;
                        }
                    }
                }
            }
            else if (option == 3)
            {
                Console.Write("\nEnter the motorbikes's ID number: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Motorbike bike in motorbikes)
                {
                    if (bike.ID == id)
                    {
                        Console.Write("\nWhat field do you want to edit?\n1. Make\n2. Model\n3. Colour\n4. Year\n5. Price\n6.Engine-Size\n7. Type\nOption: ");
                        int opt = int.Parse(Console.ReadLine());

                        Console.Write("\nNew field: ");
                        string field = Console.ReadLine();

                        if (opt == 1)
                        {
                            bike.Make = field;
                        }
                        else if (opt == 2)
                        {
                            bike.Model = field;
                        }
                        else if (opt == 3)
                        {
                            bike.Colour = field;
                        }
                        else if (opt == 4)
                        {
                            bike.Year = int.Parse(field);
                        }
                        else if (opt == 5)
                        {
                            bike.Price = float.Parse(field);
                        }
                        else if (opt == 6)
                        {
                            bike.EngineSize = float.Parse(field);
                        }
                        else if (opt == 7)
                        {
                            bike.Type = field;
                        }
                    }
                }
            }

            Console.Clear();

            PrintTable();
        }//Edits a vehicle's field

        private void DeleteVehicle()
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
        }//Deletes a vehicle from the list

        private void WriteTextFile()
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:/Users/Liam/Documents/GitHub/SecureSoftwareDevProject/SecureSoftwareDevProject/TestFiles/Test.txt");

                foreach (Car c in cars)
                {
                    sw.WriteLine(c.GetType().Name
                        + "," + c.ID
                        + "," + c.Make
                        + "," + c.Model
                        + "," + c.Colour
                        + "," + c.Year
                        + "," + c.Price
                        + "," + c.EngineSize
                        + "," + c.BodyType);
                }//Cars

                foreach (Van v in vans)
                {
                    sw.WriteLine(v.GetType().Name
                        + "," + v.ID
                        + "," + v.Make
                        + "," + v.Model
                        + "," + v.Colour
                        + "," + v.Year
                        + "," + v.Price
                        + "," + v.EngineSize
                        + "," + v.Wheelbase);
                }//Vans

                foreach (Motorbike m in motorbikes)
                {
                    sw.WriteLine(m.GetType().Name
                        + "," + m.ID
                        + "," + m.Make
                        + "," + m.Model
                        + "," + m.Colour
                        + "," + m.Year
                        + "," + m.Price
                        + "," + m.EngineSize
                        + "," + m.Type);
                }//Vans

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.Clear();
                Console.WriteLine("SAVED TO FILE.");
                PrintTable();
            }
        }//Write list of vehicles to a txt file

        private void ReadTextFile()
        {
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:/Users/Liam/Documents/GitHub/SecureSoftwareDevProject/SecureSoftwareDevProject/TestFiles/Test.txt");

                //Read the first line of text
                string line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
