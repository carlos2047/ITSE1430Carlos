using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            } while (notQuit);
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Current Cart: $"+ CalculateTotal());
                Console.WriteLine("\t1. New Order ");
                Console.WriteLine("\t2. Modify Order ");
                Console.WriteLine("\t3. Display Order");
                Console.WriteLine("\t4. Quit ");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1': NewOrder(); return true;

                    case '2': ModifyOrder(); return true;

                    case '3': DisplayOrder(); return true;

                    case '4': return false;

                    default: Console.WriteLine("Please enter a valid value."); break;

                }
            };
        }

        private static void NewOrder()
        {
            Size();
            Meat();
            Veggies();
            Sauce();
            Cheese();
            Delivery();
            DisplayOrder();            
        }

        private static void Size()
        {
            Console.WriteLine("Size (one required).");
            Console.WriteLine("\t1. Small ($5) {0}", size == 1 ? "Selected": " ");
            Console.WriteLine("\t2. Medium ($6.25) {0}", size  == 2 ? "Selected" : " ");
            Console.WriteLine("\t3. Large ($8.25) {0}", size == 3 ? "Selected" : " ");
            size = ReadInt32(1, 3);
            orderExists = true;

        }

        private static int ReadInt32( int minValue, int maxValue )
        {
            while (true)
            {

                var input = Console.ReadLine();

                if (Int32.TryParse(input, out var result))
                {
                    if (result >= minValue && result <= maxValue)
                        return result;
                };

                Console.WriteLine($"You must enter a valid option between {minValue} and {maxValue}");
            };
        }

        private static void Meat()
        {
            while (true)
            {
                Console.WriteLine("Meats (zero or more) Choose 5 when done adding meats.");
                Console.WriteLine("\t1. Bacon (+$0.75) {0}", meat == 1 ? "Selected": " ");
                Console.WriteLine("\t2. Ham(+$0.75) {0}", meat == 2 ? "Selected": " ");
                Console.WriteLine("\t3. Pepperoni(+$0.75) {0}", meat == 3 ? "Selected": " ");
                Console.WriteLine("\t4. Sausage(+$0.75) {0}", meat == 4 ? "Selected": " ");
                Console.WriteLine("\t5. Done");
                meat = ReadInt32(1, 5);
                switch (meat)
                {
                    case 1:
                    bacon = !bacon;
                    break;

                    case 2:
                    ham = !ham;
                    break;

                    case 3:
                    pepperoni = !pepperoni;
                    break;

                    case 4:
                    sausage = !sausage;
                    break;

                    case 5: return;

                }

            }
        }

        private static void Veggies()
        {
            while (true)
            {
                Console.WriteLine("Veggies (zero or more) Choose 5 when done adding veggies.");
                Console.WriteLine("\t1. Black olives (+$0.50) {0}", veggies == 1 ? "Selected": " ");
                Console.WriteLine("\t2. Mushrooms (+$0.50) {0}", veggies == 2 ? "Selected": " ");
                Console.WriteLine("\t3. Onions (+$0.50) {0}", veggies == 3 ? "Selected": " ");
                Console.WriteLine("\t4. Peppers (+$0.50) {0}", veggies == 4 ? "Selected": " ");
                Console.WriteLine("\t5. Done");


                veggies = ReadInt32(1, 5);
                switch (veggies)
                {
                    case 1:
                    blackOlives = !blackOlives;
                    break;

                    case 2:
                    mushrooms = !mushrooms;
                    break;

                    case 3:
                    onions = !onions;
                    break;

                    case 4:
                    peppers = !peppers;
                    break;

                    case 5:
                    return;

                }

            }
        }

        private static void Sauce()
        {
            Console.WriteLine("Sauce (one is required).");
            Console.WriteLine("\t1. Traditional ($0) {0}", sauce == 1 ? "Selected" : " ");
            Console.WriteLine("\t2. Garlic ($1) {0}", sauce == 2 ? "Selected" : " ");
            Console.WriteLine("\t3. Oregano ($1) {0}", sauce == 3 ? "Selected" : " ");

            sauce = ReadInt32(1, 3);

        }

        private static void Cheese()
        {
            Console.WriteLine("Cheese (one is required). ");
            Console.WriteLine("\t1. Regular ($0) {0}", cheese == 1 ? "Selected" : " ");
            Console.WriteLine("\t2. Extra (1.25) {0}", cheese == 2 ? "Selected" : " ");

            cheese = ReadInt32(1, 2);

        }

        private static void Delivery()
        {
            Console.WriteLine("Delivery (one is required).");
            Console.WriteLine("\t1. Take Out ($0) {0}", delivery == 1 ? "Selected" : " ");
            Console.WriteLine("\t2. Delivery ($2.50) {0}", delivery == 2 ? "Selected" : " ");

            delivery = ReadInt32(1, 2);
        }

        private static void ModifyOrder()
        {
            if (!orderExists)
                {
                 Console.WriteLine("No order exists!");
                }
            else
            NewOrder();
        }

        private static void DisplayOrder()
        {
            if (!orderExists)
                {
                 Console.WriteLine("No order exists!");
                }
            else
                {
                Console.WriteLine("\tYour Order\n");
                switch (size)
                    {
                    case 1:
                        Console.WriteLine("\tSmall Pizza\t\t$5.00");
                        break;

                        case 2:
                        Console.WriteLine("\tMedium Pizza\t\t$6.25");
                        break;

                        case 3:
                        Console.WriteLine("\tLarge Pizza\t\t$8.25");
                        break;
                    }
                
            switch (delivery)
            {
                case 1:
                Console.WriteLine("\tTake Out");
                break;

                case 2:
                Console.WriteLine("\tDelivery\t\t$2.50");
                break;
            }
            
            Console.WriteLine("\tMeats");
            if (bacon)
                Console.WriteLine("\t\t-Bacon\t\t$0.75");
            if (ham)
                Console.WriteLine("\t\t-Ham\t\t$0.75");
            if (pepperoni)
                Console.WriteLine("\t\t-Pepperoni\t$0.75");
            if(sausage)
                Console.WriteLine("\t\t-Sausage\t$0.75");
            Console.WriteLine("\tVeggies");

            if (blackOlives)
                Console.WriteLine("\t\t-Black Olives\t$0.50");
            if (mushrooms)
                Console.WriteLine("\t\t-Mushrooms\t$0.50");
            if (onions)
                Console.WriteLine("\t\t-Onions\t\t$0.50");
            if (peppers)
                Console.WriteLine("\t\t-Peppers\t$0.50");

            Console.WriteLine("\tSauce");

            switch (sauce)
            {
                case 1:
                Console.WriteLine("\t\t-Traditional");
                break;

                case 2:
                Console.WriteLine("\t\t-Garlic\t\t$1.00");
                break;

                case 3:
                Console.WriteLine("\t\t-Oregano\t$1.00");
                break;

            }

            Console.WriteLine("\tCheese");

            switch (cheese)
            {
                case 1:
                Console.WriteLine("\t\t-Regular");
                break;

                case 2:
                Console.WriteLine("\t\t-Extra\t\t$1.25");
                break;
            }

            Console.WriteLine("\t______________________________");
            Console.WriteLine("\tTotal\t\t\t$" + CalculateTotal());            
                }
        }

        private static decimal CalculateTotal()
        {
            var veggies = 0.50m;
            var xMeats = 0.75m;
            var price = 0m;
            switch(size)
            { 
                case 1: price +=5;
                break;
                
                case 2: price +=6.25m;
                break;
                 
                case 3: price +=8.25m; break;
            };

            if (bacon)
                price += xMeats;
            if (ham)
                price += xMeats;
            if (pepperoni)
                price += xMeats;
            if (sausage)
                price += xMeats;
            if (blackOlives)
                price += veggies;
            if (mushrooms)
                price += veggies;
            if (onions)
                price += veggies;
            if (peppers)
                price += veggies;

            switch (sauce)
            {
                case 1: price += 0;
                
                break;

                case 2: price += 1m; break;

                case 3: price += 1m; break;

            }

            switch (cheese)
            {
                case 1: price += 0; break;

                case 2: price += 1.25m; break;

            }

            switch (delivery)
            {
                case 1: price += 0; break;

                case 2: price += 2.50m; break;
            }

            return price;
        }
        static int size;
        static bool bacon;
        static bool ham;
        static bool pepperoni;
        static bool sausage;
        static bool blackOlives;
        static bool mushrooms;
        static bool onions;
        static bool peppers;
        static int sauce;
        static int meat;
        static int veggies;
        static int cheese;
        static int delivery;
        static bool orderExists = false;
    }
}