using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        // this class is set up to create a helpful interface for the user

        public void MainMenu()
        {
            Console.WriteLine("Main Menu" + Environment.NewLine + Environment.NewLine +
                "Enter corresponding number to select option" + Environment.NewLine + Environment.NewLine +
                " Press [1] To Load Wine Records" + Environment.NewLine +
                " Press [2] To View Wine Item List" + Environment.NewLine +
                " Press [3] To Search For A Wine Item By ID" + Environment.NewLine +
                " Press [4] To Print The Entire Wine List" + Environment.NewLine +
                " Press [5] To Add An Item To The Wine List" + Environment.NewLine +
                " Press [6] To Exit The Program");


            string answer = Convert.ToString(Console.ReadLine());   // based on the answer input, the corresponding
                                                                    // Class is used, or asks for new input
            if (answer == "1")
            {
               // load wine list
                SCVProcessor load = new SCVProcessor();
                load.LoadFile();
            }

            else
            {
                if (answer == "2")
                {
                   // view wine list
                }

                else
                {
                    if (answer == "3")
                    {
                       // search for wine by ID
                    }

                    else
                    {
                        if (answer == "4")
                        {
                           // print wine list
                        }

                        else
                        {
                            if (answer == "5")
                            {
                                // add item to wine list
                            }

                            else
                            {
                                if (answer == "6")
                                {
                                    // exit the program
                                    Console.Clear();
                                    Program load = new Program();
                                    load.Exit();
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Input not recongnized, please try again" + Environment.NewLine);
                                    MainMenu();
                                }
                            }
                        }
                    }
                }
            }

            Console.Clear();
            MainMenu();

        }
    }
}
