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
            App myApp = new App();
            bool running = true;
            myApp.Run(running);
            while(running) 
            {
                running = myApp.Exit();

            };

            myApp.Run(running);
            Console.Read();
        }

        
    }
}

