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
                Console.WriteLine("\t\nCurrent Shopping Cart: $"+ CalculateTotal()+ "\n");
                Console.WriteLine("\tBuild a Pizza");
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
            Console.WriteLine("\tPizza Size (choose one).");
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
                bool toggleBacon = false;
                bool toggleHam = false;
                bool togglePepperoni = false;
                bool toggleSausage = false;
                Console.WriteLine("\tAdd Meats (zero or more)\n\tChoose 5 when done with meats.");
                Console.WriteLine("\t1. Bacon (+$0.75) {0}", toggleBacon ? "Selected": " ");
                Console.WriteLine("\t2. Ham(+$0.75) {0}", toggleHam  ? "Selected": " ");
                Console.WriteLine("\t3. Pepperoni(+$0.75) {0}", togglePepperoni  ? "Selected": " ");
                Console.WriteLine("\t4. Sausage(+$0.75) {0}", toggleSausage  ? "Selected": " ");
                Console.WriteLine("\t5. Next");
                meat = ReadInt32(1, 5);
                switch (meat)
                {
                    case 1:
                        toggleBacon=true;
                    bacon = !bacon;
                    break;

                    case 2:
                        toggleHam = true;
                    ham = !ham;
                    break;

                    case 3:
                        togglePepperoni = true;
                    pepperoni = !pepperoni;
                    break;

                    case 4:
                        toggleSausage = true;
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
                bool toggleOlives = false;
                bool toggleShroom = false;
                bool toggleOnion = false;
                bool togglePep = false;
                Console.WriteLine("\tAdd Veggies (zero or more)\n\tChoose 5 when done with veggies.");
                Console.WriteLine("\t1. Black olives (+$0.50) {0}", toggleOlives==true ? "Selected": " ");
                Console.WriteLine("\t2. Mushrooms (+$0.50) {0}", toggleShroom==true ? "Selected": " ");
                Console.WriteLine("\t3. Onions (+$0.50) {0}", toggleOnion==true ? "Selected": " ");
                Console.WriteLine("\t4. Peppers (+$0.50) {0}", togglePep==true ? "Selected": " ");
                Console.WriteLine("\t5. Next");

             
                veggies = ReadInt32(1, 5);
                switch (veggies)
                {
                    case 1:
                        toggleOlives = true;
                        blackOlives = !blackOlives;
                        break;

                    case 2:
                        toggleShroom = true;
                        mushrooms = !mushrooms;
                        break;

                    case 3:
                        toggleOnion = true;
                        onions = !onions;
                        break;

                    case 4:
                        togglePep = true;
                        peppers = !peppers;
                        break;

                    case 5:
                        return;

                }

            }
        }

        private static void Sauce()
        {
            Console.WriteLine("\tPizza Sauce (choose one).");
            Console.WriteLine("\t1. Traditional (No cost) {0}", sauce == 1 ? "Selected" : " ");
            Console.WriteLine("\t2. Garlic ($1) {0}", sauce == 2 ? "Selected" : " ");
            Console.WriteLine("\t3. Oregano ($1) {0}", sauce == 3 ? "Selected" : " ");

            sauce = ReadInt32(1, 3);

        }

        private static void Cheese()
        {
            Console.WriteLine("\tHow much Cheese? (choose one). ");
            Console.WriteLine("\t1. Regular (No cost) {0}", cheese == 1 ? "Selected" : " ");
            Console.WriteLine("\t2. Extra (1.25) {0}", cheese == 2 ? "Selected" : " ");

            cheese = ReadInt32(1, 2);

        }

        private static void Delivery()
        {
            Console.WriteLine("\tDelivery (choose one).");
            Console.WriteLine("\t1. Take Out (No cost) {0}", delivery == 1 ? "Selected" : " ");
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
                Console.WriteLine("\tPlease reselct options.\n");
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
                Console.WriteLine("------------------------------------------\n");

                Console.WriteLine("\tYour Order Summary\n");
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
            Console.WriteLine("\n------------------------------------------\n");
                
                }
        }

        private static decimal CalculateTotal()
        {
            var totalVeggies = 0.50m;
            var totalMeats = 0.75m;
            var totalPrice = 0m;
            switch(size)
            { 
                case 1: totalPrice +=5;
                break;
                
                case 2: totalPrice +=6.25m;
                break;
                 
                case 3: totalPrice +=8.25m; break;
            };

            if (bacon)
                totalPrice += totalMeats;
            if (ham)
                totalPrice += totalMeats;
            if (pepperoni)
                totalPrice += totalMeats;
            if (sausage)
                totalPrice += totalMeats;
            if (blackOlives)
                totalPrice += totalVeggies;
            if (mushrooms)
                totalPrice += totalVeggies;
            if (onions)
                totalPrice += totalVeggies;
            if (peppers)
                totalPrice += totalVeggies;

            switch (sauce)
            {
                case 1: totalPrice += 0;
                
                break;

                case 2: totalPrice += 1m; break;

                case 3: totalPrice += 1m; break;

            }

            switch (cheese)
            {
                case 1: totalPrice += 0; break;

                case 2: totalPrice += 1.25m; break;

            }

            switch (delivery)
            {
                case 1: totalPrice += 0; break;

                case 2: totalPrice += 2.50m; break;
            }

            return totalPrice;
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