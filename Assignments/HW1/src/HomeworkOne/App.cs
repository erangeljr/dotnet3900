using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne
{
    public class App
    {
        bool appStatus = false;
        public void Run(bool status)
        {
            appStatus = status;

            if (appStatus)
            {
                Startup();
            }
            else if(appStatus)
            {
                Shutdown();
            }
            else
            {
                Shutdown();
            }
        }

        public bool Exit()
        {
            return appStatus;
        }

        private void Startup()
        {
            //Do something
        }
        
        private void ProcessInput()
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

        private void Shutdown()
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

        private void LaunchWebApp()
        {
            Console.WriteLine("Launch...");
        }

        private void DisplayHtml()
        {
            Console.WriteLine("Show Files...");
        }

        private void SaveMembers()
        {
            Console.WriteLine("Save Objects into HTML...");
        }

        private void DisplayMembers()
        {
            Console.WriteLine("Show in Verctor and array...");
        }

        private void Sort()
        {
            Console.WriteLine("Sorting...");
        }

        private void Generate()
        {
            Console.WriteLine("Generating...");
            var result = AskForNumber();
            //GenerateMembers(result);
        }

        private int AskForNumber()
        {
            Console.WriteLine("Enter number of objects to generate: ");
            var result = Console.ReadLine();

            int number = 0;
            Int32.TryParse(result, out number);
            return number;

        }


        public void DisplayMenu()
        {
            ShowMenu();
        }
        private void ShowMenu()
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
