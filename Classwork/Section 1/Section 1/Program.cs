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
        private static void PlayWithObjects ()
        {
            int hours = 10;
            Int32 hoursFull = 10;
            var areEqual = hours == hoursFull;

            DisplayObject("Hello");
            var obj1 = "Hello";    
            DisplayObject(obj1);
        }
        private static void DisplayObject (object value)
        {
            if (value == null)
                return;
            //approach 1
            if (value is string)
            {
                var str = (string)value;
                Console.WriteLine(str);
            } else
            {
                var str = value.ToString();
                Console.WriteLine(str);
            }

            //approach 2
            var str2 = value as string;
            if (str2 != null)
                Console.WriteLine(str2);
            else
                Console.WriteLine(value.ToString());

            //approach 3
            var str3 = value as string;
            Console.WriteLine((str3 != null) ? str3.ToString() : value.ToString());

            //approach 4
            var str4 = value as string;
            Console.WriteLine((str4 ?? value).ToString());

            //approach 5**
            //var str5 = value is string;
            if (value is string str5)
                Console.WriteLine(str5.ToString());
            else
                Console.WriteLine(value.ToString());

            //approach 6
            var str6 = value as string;
            Console.WriteLine(str6?.ToString());
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

            //string interpulation approach 4
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

        private static void PlayWithArrays()
        {
            int count = ReadInt32("How many names? ", 1);
            string[] names = new string[count];
            for (int index = 0; index < count; ++index)
            {
                Console.WriteLine("Name? ");
                names[index] = Console.ReadLine();
            }

            //for (int index = 0; index < names.Length; ++index)
            foreach(string name in names)
            {
                //readonly - not allowed
                //nname = "";
                string str = name;
                str = "";
                //Console.WriteLine(names[index]);
                Console.WriteLine(name);
            };
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
            Console.WriteLine("ViewMovies");
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("No movies available");
                return;
            };
            Console.WriteLine(name);
            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);
            //Console.WriteLine("Run length (mins) = " + runLength);
            Console.WriteLine($"Run length = {runLength} mins");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
            if (Confirm("Are you sure you want to delete this movie?"))
            {
                //"Delete" the movie
                name = null;
                description = null;
                runLength = 0;
            };
        }
        private static bool Confirm( string message )
        {
            Console.WriteLine($"{message} (Y/N)");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                    return true;
                    case 'N':
                    case 'n':
                    return false;
                };
            } while (true);
            //if (key.KeyChar == 'Y')
            //    return true;
            //else if (key.KeyChar == 'N')
            //    return false;
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
            ViewMovie();
            var newName = ReadString("Enter a name (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newName))
                name = newName;
            var newDescription = ReadString("Enter a description (or press ENTER for default): ");
            if (!String.IsNullOrEmpty(newDescription))
                description = newDescription;
            var newLength = ReadInt32("Enter run length (in minutes): ", 0);
            if (newLength > 0)
                runLength = newLength;
        }

        private static void AddMovie()
        {
           name = ReadString("Enter a name: ", true);
           description = ReadString("Enter a description: ");
           runLength = ReadInt32("Enter the run length (in minutes): ", 0);

        }
        private static int ReadInt32( string message, int minValue )
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                //Int.TryParse();
                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an integer value >= {minValue}");
            };
        }
        private static string ReadString (string message)
        {
            return ReadString(message, false);
        }
        private static string ReadString( string message, bool required)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if(!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value. ");
            };
        }
        
        //A movie
        static string name;
        static string description;
        static int runLength;
        static DateTime releaseDate;
    }
    
}
