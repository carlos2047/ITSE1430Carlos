﻿using System;
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
            //DisplayMenu();
            PlayWithStrings();
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
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case 'A': AddMovie(); break;
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': ViewMovie(); break;
                case 'Q': ; break;

                default: Console.WriteLine("Please enter a valid value."); break;
                ;
            };
        }

        private static void ViewMovie()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void AddMovie()
        {
            throw new NotImplementedException();
        }
    }
}