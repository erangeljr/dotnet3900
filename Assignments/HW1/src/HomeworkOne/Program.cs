using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    class Program
    {
        const string MENU =
           "================ CS 394 Assignment 1 ===============  \n" +
           "G/g : Ask for a N, and Gen N members of mixed \n" +
           "       Member class's objects, and store in a List  \n" +
           "       and a array Objects.\n" +
           "S/s/: Sort the members in the List and array in \n" +
           "       ascending order.\n" +
           "V/v/: Show the members in the List and array .\n" +
           "O/o/: Save objects inside List into a HTML file \n" +
           "       with objects saved in the format of HTML \n" +
           "       Table.\n" +
           "F/f : Show HTML file contents on screen.\n" +
           "L/l : Launch the default internet browser to \n" +
           "       display the generated HTML file.\n" +
           " --------------------------------------------------\n" +
           " H/h/?: Display this menu.\n" +
           " E/e  : Exit\n" +
           " =================================================";
        static void Main(string[] args)
        {
            DisplayMenu();
            ProcessInput();
            System.Console.Read();
        }

        private static void ProcessInput()
        {
            var input = System.Console.ReadLine();

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
                    System.Console.WriteLine("Invalid input:");
                    break;

            }
        }

        private static void Shutdown()
        {
            System.Console.WriteLine("Exit...");
        }

        private static void LaunchWebApp()
        {
            System.Console.WriteLine("Launch...");
        }

        private static void DisplayHtml()
        {
            System.Console.WriteLine("Show Files...");
        }

        private static void SaveMembers()
        {
            System.Console.WriteLine("Save Objects into HTML...");
        }

        private static void DisplayMembers()
        {
            System.Console.WriteLine("Show in Verctor and array...");
        }

        private static void Sort()
        {
            System.Console.WriteLine("Sorting...");
        }

        private static void Generate()
        {
            System.Console.WriteLine("Generating...");
            Console.Write("How many members would you like to create? ");
            var result = Console.ReadLine();

            int number = 0;
            if (Int32.TryParse(result, out number))
            {
                GenerateMembers(number);
            }

        }

        private static void GenerateMembers(int number)
        {

            Console.WriteLine($"Generating {number} members");
        }

        private static void DisplayMenu()
        {
            System.Console.WriteLine(MENU);
        }
    }
}

