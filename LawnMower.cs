using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neal_Inventory
{
    class LawnMower : IShippable
    {
        private decimal _shipCost = 24M;

        public decimal ShipCost
        {
            get { return _shipCost; }
        }

        public string Product
        {
            get
            {
                return "Lawn Mower";
            }
        }
    }
}
