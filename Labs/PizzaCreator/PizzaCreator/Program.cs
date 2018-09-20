using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            }
            while (notQuit);
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("N)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "n":
                    case "N": NewOrder();
                        break;

                    case "m":
                    case "M": ModifyOrder();
                        break;

                    case "d":
                    case "D": DisplayOrder();
                        break;

                    case "q":
                    case "Q": return false;

                    default:
                        Console.WriteLine("Please enter a valid value.\n");
                        break;
                };
                Console.WriteLine("\n-------------------\n");
            };

        }

        private static void NewOrder()
        {
            size = Size("What size did you want? \nS)mall ($5.00)\nM)edium ($6.25)\nL)arge ($8.75)", true);
            meats = Meats("What meats did you want? \nB)acon ($0.75)\nH)am ($0.75)\nP)epperoni ($0.75)\nS)ausage ($0.75)", false);
            vegetables = Vegetables("What vegetables did you want?\nB)lack Olives ($0.50)\nM)ushrooms ($0.50)\nO)nions ($0.50)\nP)eppers ($0.50)", false);
            sauce = Sauce("What sauce did you want?\nT)raditional ($0.00)\nG)arlic ($1.00)\nO)regano ($1.00)", true);
            cheese = Cheese("What cheese did you want?\nR)egular ($0.00)\nE)xtra ($1.25)", true);
            delivery = Delivery("Did you want it delivered or take out?\nT)ake Out ($0.00)\nD)elivered ($2.50)", true);

            DisplayOrder();
        }

        private static void ModifyOrder()
        {
                       if (String.IsNullOrEmpty(size))
            {
                Console.WriteLine("No order placed");
                return;
            }
                       DisplayOrder();

            var newSize = Size("Enter a size (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newSize))
                size = newSize;

            var newMeats = Meats("Enter type of meats (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newMeats))
                size = newMeats;

            var newVegetables = Vegetables("Enter type of vegetables (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newVegetables))
                size = newVegetables;

            var newSauce = Sauce("Enter a sauce (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newSauce))
                size = newSauce;

            var newCheese = Cheese("Enter type of cheese (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newCheese))
                size = newCheese;

            var newDelivery = Delivery("Enter a delivery option (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newDelivery))
                size = newDelivery;
        }

        private static void DisplayOrder()
        {
            if (String.IsNullOrEmpty(size))
            {
                Console.WriteLine("No order placed");
                return;
            }

            Console.WriteLine(size);

            if (!String.IsNullOrEmpty(meats))
                Console.WriteLine(meats);

            if (!String.IsNullOrEmpty(vegetables))
                Console.WriteLine(vegetables);

            if (!String.IsNullOrEmpty(sauce))
                Console.WriteLine(sauce);

            if (!String.IsNullOrEmpty(cheese))
                Console.WriteLine(cheese);

            if (!String.IsNullOrEmpty(delivery))
                Console.WriteLine(delivery);
        }

        private static string Size(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                switch (input)
                {
                    case "s":
                    case "S": "Small";
                        break;

                    case "m":
                    case "M": "Medium";
                        break;

                    case "l":
                    case "L": "Large";
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice.\n");
                        break;
                };

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        private static string Meats(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        private static string Vegetables(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        private static string Sauce(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        private static string Cheese(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        private static string Delivery(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value.");
            };
        }

        static string size;
        static string meats;
        static string vegetables;
        static string sauce;
        static string cheese;
        static string delivery;
    }

}