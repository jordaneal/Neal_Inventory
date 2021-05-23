using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neal_Inventory
{
    class Shipper
    {
        IShippable[] shippable = new IShippable[10];
        private int _counter = -1;
        private int _gloves;
        private int _bikes;
        private int _crackers;
        private int _mowers;


        public string Add(IShippable item)
        {
            _counter++;
            shippable[_counter] = item;
            switch (item.Product)
            {
                case "Baseball Glove":
                    _gloves++;
                    break;
                case "Bicycle":
                    _bikes++;
                    break;
                case "Crackers":
                    _crackers++;
                    break;
                case "Lawn Mower":
                    _mowers++;
                    break;
            }
            return $"\n1 {shippable[_counter].Product} has been added\n" +
                "Press any key to return to the menu. . .";
        }

        public string List()
        {
            string listOutput = "\n";

            if (_bikes == 1) listOutput += "1 Bicycle\n";
            else if (_bikes > 1) listOutput += $"{_bikes} Bicycles\n";

            if (_mowers == 1) listOutput += "1 Lawn Mower\n";
            else if (_mowers > 1) listOutput += $"{_mowers} Lawn Mowers\n";

            if (_gloves == 1) listOutput += "1 Baseball Glove\n";
            else if (_gloves > 1) listOutput += $"{_gloves} Baseball Gloves\n";

            if (_crackers > 0) listOutput += $"{_crackers} Crackers\n";

            return listOutput + "\nPress any key to return to the menu. . .";
        }

        public string ComputeShippingCost()
        {
            decimal totalCost = 0;

            for (int i = 0; i < _counter+1; i++)
            {
                totalCost += shippable[i].ShipCost;
            }

            return "\nTotal shipping cost for this order is " + Math.Round(totalCost, 2).ToString("C");
        }
    }
}
