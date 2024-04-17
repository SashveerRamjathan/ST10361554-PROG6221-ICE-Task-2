using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    internal class Inventory
    {
        //key = categories
        //value = list of items in the category
        Dictionary<string, List<InventoryItem>> inventory = new Dictionary<string, List<InventoryItem>>();

        //Keep track of history of added items
        //item added pushed onto stack
        //item removed popped from stack
        //LIFO
        Stack<InventoryItem> AddItemHistory = new Stack<InventoryItem>();

        //keep track of items that need to be restocked
        //quantity goes below certain amount, added to queue to order
        //FIFO
        Queue<InventoryItem> queue = new Queue<InventoryItem>();


    }
}
