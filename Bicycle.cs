using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neal_Inventory
{
    class Bicycle : IShippable
    {
        private decimal _shipCost = 9.5M;

        public decimal ShipCost
        {
            get { return _shipCost; }
        }

        public string Product
        {
            get
            {
                return "Bicycle";
            }
        }
    }
}
