using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public partial class RestockInventoryForm : Form
    {
        private GroceryStore store;

        public RestockInventoryForm(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.store = groceryStore;
        }

        
        private void CheckInventoryButton_Click(object sender, EventArgs e)
        {
            store.Inventory.CheckItemsToRestock();

            store.Inventory.DisplayRestockItemQueue();

            if (store.Inventory.restockItemsDisplay.Count == 0)
            {
                RestockInventoryRichTextbox.Text = "There are currently no items to restock";
            }
            else
            {
                RestockInventoryRichTextbox.Clear();

                foreach (string item in store.Inventory.restockItemsDisplay)
                {
                    int i = 1;

                    RestockInventoryRichTextbox.AppendText($"\n{i}.{item}\n\n");
                }
            }
        }
    }
}
