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

            // this is the main class

            Console.Clear();
            UserInterface load = new UserInterface();
            load.MainMenu();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

    }
}
