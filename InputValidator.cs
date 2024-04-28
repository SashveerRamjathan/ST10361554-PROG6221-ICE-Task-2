using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    internal class InputValidator
    {
        // This method checks if the given InventoryItem object is not null
        // and returns a boolean value indicating its validity
        public bool CheckItem(InventoryItem item)
        {
            bool isValid = false;

            if (item!= null)
            {
                isValid = true;
            }

            return isValid;
        }

        // This method checks if the given list of InventoryItem objects has at least one item
        // and returns a boolean value indicating its validity
        public bool ValidateList(List<InventoryItem> items)
        {
            bool isValid = false;

            if (items.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
