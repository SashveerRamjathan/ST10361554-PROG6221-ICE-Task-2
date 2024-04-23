﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public class InventoryItem
    {
        public string? ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public ItemCategory Category { get; set; }
        public int MinimumQuantity { get; set; }

    }
}
