using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    class Program
    {


        static void Main(string[] args)
        {
            DisplayMenu();
            ProcessInput();
            Console.Read();
        }

        
        private static void ProcessInput()
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "G":
                case "g":
                    Generate();
                    break;
                case "S":
                case "s":
                    Sort();
                    break;
                case "V":
                case "v":
                    DisplayMembers();
                    break;
                case "O":
                case "o":
                    SaveMembers();
                    break;
                case "F":
                case "f":
                    DisplayHtml();
                    break;
                case "L":
                case "l":
                    LaunchWebApp();
                    break;
                case "H":
                case "h":
                    DisplayMenu();
                    break;
                case "E":
                case "e":
                    Shutdown();
                    break;
                default:
                    Console.WriteLine("Invalid input:");
                    break;

            }
        }

        private static void Shutdown()
        {
            Console.WriteLine("Are you sure?[y/n]");
            var result = Console.ReadLine();
            switch (result)
            {
                case "Y":
                case "y":
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    DisplayMenu();
                    break;
            }
        }

        private static void LaunchWebApp()
        {
            Console.WriteLine("Launch...");
        }

        private static void DisplayHtml()
        {
            Console.WriteLine("Show Files...");
        }

        private static void SaveMembers()
        {
            Console.WriteLine("Save Objects into HTML...");
        }

        private static void DisplayMembers()
        {
            Console.WriteLine("Show in Verctor and array...");
        }

        private static void Sort()
        {
            Console.WriteLine("Sorting...");
        }

        private static void Generate()
        {
            Console.WriteLine("Generating...");
            var result = AskForNumber();
            //GenerateMembers(result);
        }

        private static int AskForNumber()
        {
            Console.WriteLine("Enter number of objects to generate: ");
            var result = Console.ReadLine();

            int number = 0;
            Int32.TryParse(result, out number);
            return number;

        }

        
        private static void DisplayMenu()
        {
            ShowMenu();
        }
        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("================ CS 3900 Assignment 1 ===============\n");
            Console.WriteLine("G/g:   Ask for a N, and generate N members of mixed\n" +
                    "\tMember class's objects, and store in a List\n" +
                    "\tand a array Objects.\n");
            Console.WriteLine("S/s/ : Sort the members in the List and array in\n" +
                    "\tascending order.\n");
            Console.WriteLine("V/v/ : Show the members in the List and array.\n");
            Console.WriteLine("D/d/ : Save objects inside List into a HTML file\n" +
                    "\twith objects saved in the format of HTML Table.\n");
            Console.WriteLine("F/f  : Show HTML file contents on screen.\n");
            Console.WriteLine("L/l  : Launch the default internet browser to\n" +
                   "\tdisplay the generated HTML file.\n");
            Console.WriteLine("--------------------------------------------------\n");
            Console.WriteLine("H/h/?: Display this menu.\n");
            Console.WriteLine("E/e  : Exit\n");
            Console.WriteLine("=================================================\n");

        }
    }
}

