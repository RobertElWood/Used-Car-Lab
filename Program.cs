namespace Used_Cars_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            List <Car> inventory = new List<Car>();
            inventory.Add (new Car ("Toyota", "4Runner", 2023, 34999));
            inventory.Add(new Car("Bentley", "Azure", 2023, 307845));
            inventory.Add(new Car("Land Rover", "p400", 2023, 117500));
            inventory.Add(new UsedCar("Toyota", "Tacoma", 2016, 20000, 58821));
            inventory.Add(new UsedCar("Chevrolet", "Volt", 2014, 11000, 101083));
            inventory.Add(new UsedCar("Chrysler", "300", 2011, 9000, 140000));

            Console.WriteLine ("\nWelcome to Grand Circus' new and used car dealership!\n");
            Console.WriteLine ("Where the prices are so crazy...You'll think the circus is in town!\n");

            while (goOn)
            {
                if (inventory.Count == 0) 
                {
                    Console.WriteLine("\nMy apologies! We currently have no more vehicles to sell.\n");
                    Console.WriteLine("Have a nice day, and thank you for shopping at the Grand Circus Dealership!\n");
                    break;
                }

                Console.WriteLine("Here is our current list of new and used vehicles:\n");

                int index = 1;

                foreach (Car car in inventory)
                {
                    Console.WriteLine(index + ":  " + car);
                    index++;
                }

                Console.WriteLine("\nWhich car would you like to purchase? Please select the number on our inventory sheet.\n");

                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Congratulations! You purchased our {inventory[input-1].Year} {inventory[input-1].Make} " +
                    $"{inventory[input-1].Model} for ${inventory[input-1].Price}.\n");

                inventory.RemoveAt(input - 1);

                goOn = runAgain();
                

            }


        }
        public static bool runAgain()
        {
            Console.WriteLine("\nWould you like to purchase another vehicle? Y/N?\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine();
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nThank you for your interest in our vehicles! Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand that. Please try again!");
                return runAgain();
            }
        }
    }
}