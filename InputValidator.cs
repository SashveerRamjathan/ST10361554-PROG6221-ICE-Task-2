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
       public bool CheckItem(InventoryItem item)
       {
            bool isValid = false;

            if (item != null)
            {
                isValid = true;
            }

            return isValid;
       }
    }
}
