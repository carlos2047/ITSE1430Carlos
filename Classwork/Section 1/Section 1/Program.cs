using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1
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
            //PlayWithStrings();
        }

        private static void PlayWithStrings()
        {
            string hoursString = "10";

            //from string
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString, out hours);
            bool result = Int32.TryParse(hoursString, out int hours);

            //to string
            // hoursString = hours.ToString();
            // 4.75.ToString();
            // Console.ReadLine().ToString();

            string message = "Hello\tworld";
            string filepath = "C:\\Temp\\Test";

            //Verbatim Strings
            filepath = @"c:\Temp\Test";

            //Concat
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + " " + lastName;

            //strings are immutable, below will create new strings
            //name = "Hello " + name;
            Console.WriteLine("Hello " + name);// approach 1
            Console.WriteLine("Hello {0} {1}", firstName, lastName); //approach 2
            string str = String.Format("Hello {0} {1}", firstName, lastName); // approach 3
            Console.WriteLine(str);

            //approach 4
            Console.WriteLine($"Hello {firstName} {lastName}");

            //null vs empty
            string missing = null;
            string empty = "";
            string empty2 = String.Empty;
            
            //checking for empty strings
            //if (firstName.Length == 0)
            //if(firstName != null && firstName != "")
            if (!String.IsNullOrEmpty(firstName))
                Console.WriteLine(firstName);

            //other stuff
            string upperName = firstName.ToUpper();
            string lowerName = firstName.ToLower();

            //comparison
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower();
            areEqual = String.Compare(firstName, lastName, true) == 0; //case insensitive set 3rd parameter to false or blank for case sensitive

            bool startsWithA = firstName.StartsWith("A");
            bool endsWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0;
            string subset = firstName.Substring(4);

            // clean up
            string cleanMe = firstName.Trim(); // TrimStart, TrimEnd
            string makeLonger = firstName.PadLeft(20); //PadRight

        }

        private static bool DisplayMenu()
        {
            while (true)
            { 
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie(); return true;
                    case 'e':
                    case 'E': EditMovie(); return true;
                    case 'd':
                    case 'D': DeleteMovie(); return true;
                    case 'v':
                    case 'V': ViewMovie(); return true;
                    case 'q':
                    case 'Q': return false;

                    default:
                         Console.WriteLine("Please enter a valid value.\n"); break;
                    ;
                };
            };
        }

        private static void ViewMovie()
        {
            Console.WriteLine("View Movie\n");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("Delete Movie\n");
        }

        private static void EditMovie()
        {
            Console.WriteLine("Edit Movie\n");
        }

        private static void AddMovie()
        {
            Console.WriteLine("Add Movie\n");
        }
    }
}
