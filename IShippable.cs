﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neal_Inventory
{
    interface IShippable
    {
        decimal ShipCost { get; }

        string Product { get; }
    }
}
