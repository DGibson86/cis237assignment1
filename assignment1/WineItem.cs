using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {

        // this class handles an individual wine item loaded from the WineList.csv file

        // wine item variables
        string wineId;
        string wineName;
        string wineSize;   
        
        // default constructor
        public WineItem()
        {

        }

        // my 3 parameter constructor
        public WineItem(string wineId, string wineName, string wineSize)
        {
            this.wineId = wineId;
            this.wineName = wineName;
            this.wineSize = wineSize;
        }

        // public methods
        public void DisplayWineItem()
        {
            Console.WriteLine(this.wineId + " " + this.wineName + " " + this.wineSize);
        }
    }
}
