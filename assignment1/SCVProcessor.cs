﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class SCVProcessor
    {
        // this class handles reading and writing the information taken from the WineList.csv file into an array


         string wineItem;       
         



        // public constructor
        public void LoadFile()
        {
            StreamReader inputFile = new StreamReader("WineList.csv");

            while (!inputFile.EndOfStream)
            {
                wineItem = inputFile.ReadLine();
                wineArray.Items.Add(wineItem);
            }

                       
            inputFile.Close();
        }
    }
}
