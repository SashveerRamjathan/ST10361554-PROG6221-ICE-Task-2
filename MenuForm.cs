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
    public partial class MenuForm : Form
    {
        public GroceryStore store = new GroceryStore();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void AddItemMenuButton_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm(store);
            form.Show();
        }

        private void DeleteItemMenuButton_Click(object sender, EventArgs e)
        {
            DeleteItemForm form = new DeleteItemForm(store);
            form.Show();
        }

        private void ViewInventoryMenuButton_Click(object sender, EventArgs e)
        {
            ViewInventoryForm form = new ViewInventoryForm(store);
            form.Show();
        }

        private void PurchaseItemMenuButton_Click(object sender, EventArgs e)
        {
            PurchaseItemForm form = new PurchaseItemForm(store);
            form.Show();
        }

        private void RestockInventoryMenuButton_Click(object sender, EventArgs e)
        {
            RestockInventoryForm form = new RestockInventoryForm(store);
            form.Show();
        }

    }
}
