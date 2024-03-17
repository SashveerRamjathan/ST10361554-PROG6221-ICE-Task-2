using System.Collections;
using System.Text.RegularExpressions;

namespace WinFormsCafeApp
{
    public partial class Form1 : Form
    {
        // Declare ArrayLists and arrays for storing items, quantities, prices, and bill breakdown
        ArrayList itemOrderedIndexes = new ArrayList();
        ArrayList itemsOrderedNames = new ArrayList();
        ArrayList ItemQuantities = new ArrayList();
        ArrayList billBreakdown = new ArrayList();
        ArrayList shoppingCart = new ArrayList();
        double[] itemPrices = { 75.99, 65.00, 120.00, 110.00, 54.99, 49.99, 69.99, 35.99 };
        string[] menuItems = { "Avocado Toast with Poached Egg", "Caprese Panini", "Mushroom and Spinach Quiche",
                                "Classic Caesar Salad with Grilled Chicken", "Triple Chocolate Muffin",
                                "Caramel Macchiato", "Berry Blast Smoothie", "Chai Latte" };

        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmActionButton_Click(object sender, EventArgs e)
        {
            // Gets index of selected item in combo box
            int itemIndex = ItemSelectComboBox.SelectedIndex;

            // Gets the item quantity in text box
            string itemQuantity = ItemQuantityTextBox.Text;

            // Declare and initialize some variables
            int orderQuantity = 0;
            string itemName;

            // Checks if quantity is empty, is a letter, or no item is chosen
            if (itemQuantity == "" || IsLetters(itemQuantity) || itemIndex == -1)
            {
                WarningLabelQuantity.Text = "You have selected an invalid quantity and item";
            }
            else
            {
                WarningLabelQuantity.Text = null;

                // Converts quantity to an int
                orderQuantity = Convert.ToInt32(ItemQuantityTextBox.Text);

                // Gets the item name
                itemName = GetItemName(itemIndex, menuItems);

                // Adds item name to ArrayList
                itemsOrderedNames.Add(itemName);

                // Adds item index to ArrayList
                itemOrderedIndexes.Add(itemIndex);

                // Adds quantity of item to ArrayList
                ItemQuantities.Add(orderQuantity);

                // Adds the item as a whole to the shopping cart list
                shoppingCart.Add(ShoppingCartDisplayItem(itemIndex, orderQuantity, menuItems));

                // Adds the item's name to the delete combo box so the customer can delete it
                ItemDeleteComboBox.Items.Add(itemName);

                // Display the item to the user
                ShoppingCartListBox.Items.Add(ShoppingCartDisplayItem(itemIndex, orderQuantity, menuItems));

                // Clear all the inputs
                ItemSelectComboBox.SelectedIndex = -1;
                ItemQuantityTextBox.Clear();
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            // Gets index from the delete combo box
            int itemToDelete = ItemDeleteComboBox.SelectedIndex;

            // Checks if index is not valid
            if (itemToDelete == -1)
            {
                WarningLabelDelete.Text = "Invalid choice selected";
            }
            else
            {
                WarningLabelDelete.Text = null;

                // Clear the display
                ShoppingCartListBox.Items.Clear();

                // Removes the item index from the list
                itemOrderedIndexes.RemoveAt(itemToDelete);

                // Removes item name from list
                itemsOrderedNames.RemoveAt(itemToDelete);

                // Removes the item quantity from the list
                ItemQuantities.RemoveAt(itemToDelete);

                // Removes the item as a whole from the shopping cart
                shoppingCart.RemoveAt(itemToDelete);

                // Reset the selected item to default state
                ItemDeleteComboBox.SelectedIndex = -1;

                // Remove all items from the combo box
                ItemDeleteComboBox.Items.Clear();

                // Add all the items in the cart back to the delete combo box
                foreach (string item in itemsOrderedNames)
                {
                    ItemDeleteComboBox.Items.Add(item);
                }

                // Re-display the details of the order
                foreach (string item in shoppingCart)
                {
                    ShoppingCartListBox.Items.Add(item);
                }
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            // Clear the OrderInfoListBox
            OrderInfoListBox.Items.Clear();

            // Generate invoice details
            string recieptHeading = "Cafe App Invoice";
            Random random = new Random();
            int recieptNumber = random.Next(10000, 100000);
            DateTime recieptGenerationDateTime = DateTime.Now;
            string dateTimeOfReciept = recieptGenerationDateTime.ToString();
            double total = Math.Round(GenerateTotal(itemOrderedIndexes, ItemQuantities, menuItems, itemPrices, billBreakdown), 2);
            double VAT = Math.Round(CalculateVAT(total), 2);
            double totalPayable = Math.Round(CalculateTotalPayable(total, VAT), 2);

            // Add invoice details to OrderInfoListBox
            OrderInfoListBox.Items.Add(recieptHeading);
            OrderInfoListBox.Items.Add("");
            OrderInfoListBox.Items.Add("Reciept number: " + recieptNumber);
            OrderInfoListBox.Items.Add(dateTimeOfReciept);
            OrderInfoListBox.Items.Add("");
            OrderInfoListBox.Items.Add("Items:");
            foreach (string item in billBreakdown)
            {
                OrderInfoListBox.Items.Add(item);
            }
            OrderInfoListBox.Items.Add("");
            OrderInfoListBox.Items.Add("VAT: " + VAT);
            OrderInfoListBox.Items.Add("Total Due: " + totalPayable);
            OrderInfoListBox.Items.Add("");
            OrderInfoListBox.Items.Add("Thank You For Your Support");
            OrderInfoListBox.Items.Add("Please Call Again!");
        }

        public bool IsLetters(string value)
        {
            // Check if the input string contains only letters
            string pattern = "^[a-zA-Z]+$";
            return Regex.IsMatch(value, pattern);
        }

        public string ShoppingCartDisplayItem(int index, int itemQunatity, string[] menuItems)
        {
            // Generate the display string for a shopping cart item
            string itemDescription;
            itemDescription = itemQunatity + " " + menuItems[index];
            return itemDescription;
        }

        public string GetItemName(int index, string[] items)
        {
            // Get the item name based on its index
            string name = items[index];
            return name;
        }

        public static double GenerateTotal(ArrayList itemsOrdered, ArrayList orderQuantity, string[] menuItems, double[] menuItemPrices, ArrayList billBreakdown)
        {
            // Calculate the total cost of the order and generate bill breakdown
            double total = 0;
            int itemOrdered = -1;
            int itemQuantity = -1;
            double itemPrice = -1;
            double itemCost = 0;
            String billDescription;

            for (int i = 0; i < itemsOrdered.Count; i++)
            {
                itemOrdered = Convert.ToInt32(itemsOrdered[i]);
                itemQuantity = Convert.ToInt32(orderQuantity[i]);
                itemPrice = menuItemPrices[itemOrdered];

                itemCost = Math.Round((itemPrice * itemQuantity), 2);
                total += itemCost;

                billDescription = itemQuantity + " " + menuItems[itemOrdered] + " @ R" + menuItemPrices[itemOrdered] + " => R" + itemCost;
                billBreakdown.Add(billDescription);
            }

            return total;
        }

        public static double CalculateVAT(double total)
        {
            // Calculate VAT based on the total cost
            double vat = (total * 0.15);
            return vat;
        }

        public static double CalculateTotalPayable(double total, double VAT)
        {
            // Calculate the total amount payable including VAT
            double totalPayable = (total + VAT);
            return totalPayable;
        }
    }
}

