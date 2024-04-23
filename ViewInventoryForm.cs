using System;
using System.Collections;
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
    public partial class ViewInventoryForm : Form
    {
        private GroceryStore store;

        public ViewInventoryForm(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.store = groceryStore;

        }

        private void RefreshInventoryDisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(store.Inventory.inventory.Count == 0)
                {
                    ViewInventoryRichTextbox.Text = "No items are currently stored in inventory";
                }
                else
                {
                    ViewInventoryRichTextbox.Clear();

                    store.Inventory.DisplayInventory();

                    Dictionary<ItemCategory, List<string>> items = new Dictionary<ItemCategory, List<string>>();

                    for (int i = 0; i < store.Inventory.categoriesInDictionary.Count; i++)
                    {
                        items.Add(store.Inventory.categoriesInDictionary[i], store.Inventory.itemLists[i]);
                    }

                    foreach (KeyValuePair<ItemCategory, List<string>> kvp in items)
                    {
                        ViewInventoryRichTextbox.SelectionFont = new Font(ViewInventoryRichTextbox.Font, FontStyle.Bold);
                        ViewInventoryRichTextbox.AppendText($"Category: {kvp.Key}\n");
                        ViewInventoryRichTextbox.SelectionFont = new Font(ViewInventoryRichTextbox.Font, FontStyle.Regular);

                        foreach (string item in kvp.Value)
                        {
                            int i = 1;

                            ViewInventoryRichTextbox.AppendText($"\n{i}.{item}\n\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshItemHistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(store.Inventory.AddItemHistory.Count == 0)
                {
                    ItemHistoryRichTextbox.Text = "No items are currently stored in inventory";
                }
                else
                {
                    ItemHistoryRichTextbox.Clear();

                    string lastAddedItem = store.Inventory.DisplayItem(store.Inventory.DisplayLastAddedItem());

                    ItemHistoryRichTextbox.Text = lastAddedItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
