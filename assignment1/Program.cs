using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            // this is the main 

            // this starts the UserInterface class
            Console.Clear();
            UserInterface load = new UserInterface();
            load.MainMenu();
        }

        // this exits the program when called
        public void Exit()
        {
            Environment.Exit(0);
        }

    }
}
