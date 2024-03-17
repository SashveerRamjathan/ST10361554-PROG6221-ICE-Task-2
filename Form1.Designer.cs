namespace WinFormsCafeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WelcomeLabel = new Label();
            MenuLabel = new Label();
            MenuListBox = new ListBox();
            ItemUserChoiceLabel = new Label();
            ItemSelectComboBox = new ComboBox();
            ItemQuantityLabel = new Label();
            ItemQuantityTextBox = new TextBox();
            ShoppingCartLabel = new Label();
            ShoppingCartListBox = new ListBox();
            ConfirmActionButton = new Button();
            OrderInfoLabel = new Label();
            OrderInfoListBox = new ListBox();
            CheckOutInstructionLabel = new Label();
            CheckOutButton = new Button();
            WarningLabelQuantity = new Label();
            DeleteItemLabel = new Label();
            ItemDeleteComboBox = new ComboBox();
            DeleteItemButton = new Button();
            WarningLabelDelete = new Label();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = SystemColors.ControlText;
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(192, 20);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to my Cafe App!";
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuLabel.ForeColor = SystemColors.ControlText;
            MenuLabel.Location = new Point(12, 33);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(41, 15);
            MenuLabel.TabIndex = 1;
            MenuLabel.Text = "Menu:";
            // 
            // MenuListBox
            // 
            MenuListBox.BackColor = Color.FromArgb(241, 240, 239);
            MenuListBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuListBox.ForeColor = SystemColors.ControlText;
            MenuListBox.FormattingEnabled = true;
            MenuListBox.ItemHeight = 15;
            MenuListBox.Items.AddRange(new object[] { "1. Avocado Toast with Poached Egg - R75,99", "Multigrain toast topped with avocado, poached egg, cherry tomatoes, and feta cheese.", "", "2. Caprese Panini - R65,00", "Ciabatta sandwich with fresh mozzarella, tomatoes, basil, and balsamic glaze.", "", "3. Mushroom and Spinach Quiche - R120,00", "Savory quiche with mushrooms, spinach, and Swiss cheese in a flaky crust.", "", "4. Classic Caesar Salad with Grilled Chicken - R110,00", "Romaine lettuce, grilled chicken, cherry tomatoes, croutons, and Parmesan in Caesar dressing.", "", "5. Triple Chocolate Muffin - R54,99", "Decadent muffin with dark and milk chocolate, topped with white chocolate drizzle.", "", "6. Caramel Macchiato - R49,99", "Espresso, steamed milk, and a caramel drizzle for a sweet coffee treat.", "", "7. Berry Blast Smoothie - R69,99", "Mixed berry, banana, yogurt, and honey blend for a refreshing smoothie.", "", "8. Chai Latte - R35,99", "Black tea with aromatic spices and steamed milk for a comforting spiced beverage." });
            MenuListBox.Location = new Point(12, 51);
            MenuListBox.Name = "MenuListBox";
            MenuListBox.Size = new Size(528, 214);
            MenuListBox.TabIndex = 2;
            // 
            // ItemUserChoiceLabel
            // 
            ItemUserChoiceLabel.AutoSize = true;
            ItemUserChoiceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemUserChoiceLabel.ForeColor = SystemColors.ControlText;
            ItemUserChoiceLabel.Location = new Point(565, 279);
            ItemUserChoiceLabel.Name = "ItemUserChoiceLabel";
            ItemUserChoiceLabel.Size = new Size(273, 15);
            ItemUserChoiceLabel.TabIndex = 3;
            ItemUserChoiceLabel.Text = "Please select one of our items from the box below:";
            // 
            // ItemSelectComboBox
            // 
            ItemSelectComboBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemSelectComboBox.ForeColor = SystemColors.ControlText;
            ItemSelectComboBox.FormattingEnabled = true;
            ItemSelectComboBox.Items.AddRange(new object[] { "Avocado Toast with Poached Egg @ R75,99", "Caprese Panini @ R65,00", "Mushroom and Spinach Quiche @ R120,00                                ", "Classic Caesar Salad with Grilled Chicken @ R110,00", " Triple Chocolate Muffin @ R54,99                                ", "Caramel Macchiato @ R49,99", "Berry Blast Smoothie @ R69,99 ", "Chai Latte @ R35,99 " });
            ItemSelectComboBox.Location = new Point(565, 297);
            ItemSelectComboBox.Name = "ItemSelectComboBox";
            ItemSelectComboBox.Size = new Size(417, 23);
            ItemSelectComboBox.TabIndex = 4;
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemQuantityLabel.ForeColor = SystemColors.ControlText;
            ItemQuantityLabel.Location = new Point(565, 333);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(417, 15);
            ItemQuantityLabel.TabIndex = 5;
            ItemQuantityLabel.Text = "Please enter the quantity of the item you would like to order in the box below:";
            // 
            // ItemQuantityTextBox
            // 
            ItemQuantityTextBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemQuantityTextBox.ForeColor = SystemColors.ControlText;
            ItemQuantityTextBox.Location = new Point(565, 351);
            ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            ItemQuantityTextBox.Size = new Size(417, 23);
            ItemQuantityTextBox.TabIndex = 6;
            // 
            // ShoppingCartLabel
            // 
            ShoppingCartLabel.AutoSize = true;
            ShoppingCartLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShoppingCartLabel.ForeColor = SystemColors.ControlText;
            ShoppingCartLabel.Location = new Point(565, 33);
            ShoppingCartLabel.Name = "ShoppingCartLabel";
            ShoppingCartLabel.Size = new Size(88, 15);
            ShoppingCartLabel.TabIndex = 7;
            ShoppingCartLabel.Text = "Shopping cart: ";
            // 
            // ShoppingCartListBox
            // 
            ShoppingCartListBox.BackColor = Color.FromArgb(241, 240, 239);
            ShoppingCartListBox.ForeColor = SystemColors.ControlText;
            ShoppingCartListBox.FormattingEnabled = true;
            ShoppingCartListBox.ItemHeight = 15;
            ShoppingCartListBox.Location = new Point(565, 51);
            ShoppingCartListBox.Name = "ShoppingCartListBox";
            ShoppingCartListBox.Size = new Size(458, 214);
            ShoppingCartListBox.TabIndex = 8;
            // 
            // ConfirmActionButton
            // 
            ConfirmActionButton.BackColor = Color.ForestGreen;
            ConfirmActionButton.FlatStyle = FlatStyle.Popup;
            ConfirmActionButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ConfirmActionButton.ForeColor = Color.Snow;
            ConfirmActionButton.Location = new Point(565, 380);
            ConfirmActionButton.Name = "ConfirmActionButton";
            ConfirmActionButton.Size = new Size(131, 31);
            ConfirmActionButton.TabIndex = 9;
            ConfirmActionButton.Text = "Confirm";
            ConfirmActionButton.UseVisualStyleBackColor = false;
            ConfirmActionButton.Click += ConfirmActionButton_Click;
            // 
            // OrderInfoLabel
            // 
            OrderInfoLabel.AutoSize = true;
            OrderInfoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderInfoLabel.ForeColor = SystemColors.ControlText;
            OrderInfoLabel.Location = new Point(12, 279);
            OrderInfoLabel.Name = "OrderInfoLabel";
            OrderInfoLabel.Size = new Size(170, 15);
            OrderInfoLabel.TabIndex = 10;
            OrderInfoLabel.Text = "Customer Reciept Information:";
            // 
            // OrderInfoListBox
            // 
            OrderInfoListBox.BackColor = Color.FromArgb(241, 240, 239);
            OrderInfoListBox.ForeColor = SystemColors.ControlText;
            OrderInfoListBox.FormattingEnabled = true;
            OrderInfoListBox.ItemHeight = 15;
            OrderInfoListBox.Location = new Point(12, 297);
            OrderInfoListBox.Name = "OrderInfoListBox";
            OrderInfoListBox.Size = new Size(528, 169);
            OrderInfoListBox.TabIndex = 11;
            // 
            // CheckOutInstructionLabel
            // 
            CheckOutInstructionLabel.AutoSize = true;
            CheckOutInstructionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutInstructionLabel.ForeColor = SystemColors.ControlText;
            CheckOutInstructionLabel.Location = new Point(15, 478);
            CheckOutInstructionLabel.Name = "CheckOutInstructionLabel";
            CheckOutInstructionLabel.Size = new Size(263, 15);
            CheckOutInstructionLabel.TabIndex = 12;
            CheckOutInstructionLabel.Text = "Click the Check Out button to generate a reciept:";
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = Color.Teal;
            CheckOutButton.FlatStyle = FlatStyle.Popup;
            CheckOutButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CheckOutButton.ForeColor = Color.Snow;
            CheckOutButton.Location = new Point(15, 496);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(116, 35);
            CheckOutButton.TabIndex = 13;
            CheckOutButton.Text = "Check Out";
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // WarningLabelQuantity
            // 
            WarningLabelQuantity.AutoSize = true;
            WarningLabelQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabelQuantity.ForeColor = Color.Red;
            WarningLabelQuantity.Location = new Point(702, 386);
            WarningLabelQuantity.Name = "WarningLabelQuantity";
            WarningLabelQuantity.Size = new Size(0, 17);
            WarningLabelQuantity.TabIndex = 14;
            // 
            // DeleteItemLabel
            // 
            DeleteItemLabel.AutoSize = true;
            DeleteItemLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteItemLabel.ForeColor = SystemColors.ControlText;
            DeleteItemLabel.Location = new Point(565, 428);
            DeleteItemLabel.Name = "DeleteItemLabel";
            DeleteItemLabel.Size = new Size(254, 15);
            DeleteItemLabel.TabIndex = 15;
            DeleteItemLabel.Text = "To delete an item, select it from the box below:";
            // 
            // ItemDeleteComboBox
            // 
            ItemDeleteComboBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemDeleteComboBox.ForeColor = SystemColors.ControlText;
            ItemDeleteComboBox.FormattingEnabled = true;
            ItemDeleteComboBox.Location = new Point(565, 446);
            ItemDeleteComboBox.Name = "ItemDeleteComboBox";
            ItemDeleteComboBox.Size = new Size(417, 23);
            ItemDeleteComboBox.TabIndex = 16;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.BackColor = Color.Firebrick;
            DeleteItemButton.FlatStyle = FlatStyle.Popup;
            DeleteItemButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteItemButton.ForeColor = Color.Snow;
            DeleteItemButton.Location = new Point(565, 475);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(131, 34);
            DeleteItemButton.TabIndex = 17;
            DeleteItemButton.Text = "Delete item";
            DeleteItemButton.UseVisualStyleBackColor = false;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // WarningLabelDelete
            // 
            WarningLabelDelete.AutoSize = true;
            WarningLabelDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabelDelete.ForeColor = Color.Red;
            WarningLabelDelete.Location = new Point(702, 485);
            WarningLabelDelete.Name = "WarningLabelDelete";
            WarningLabelDelete.Size = new Size(0, 17);
            WarningLabelDelete.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 539);
            Controls.Add(WarningLabelDelete);
            Controls.Add(DeleteItemButton);
            Controls.Add(ItemDeleteComboBox);
            Controls.Add(DeleteItemLabel);
            Controls.Add(WarningLabelQuantity);
            Controls.Add(CheckOutButton);
            Controls.Add(CheckOutInstructionLabel);
            Controls.Add(OrderInfoListBox);
            Controls.Add(OrderInfoLabel);
            Controls.Add(ConfirmActionButton);
            Controls.Add(ShoppingCartListBox);
            Controls.Add(ShoppingCartLabel);
            Controls.Add(ItemQuantityTextBox);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(ItemSelectComboBox);
            Controls.Add(ItemUserChoiceLabel);
            Controls.Add(MenuListBox);
            Controls.Add(MenuLabel);
            Controls.Add(WelcomeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label MenuLabel;
        private ListBox MenuListBox;
        private Label ItemUserChoiceLabel;
        private ComboBox ItemSelectComboBox;
        private Label ItemQuantityLabel;
        private TextBox ItemQuantityTextBox;
        private Label ShoppingCartLabel;
        private ListBox ShoppingCartListBox;
        private Button ConfirmActionButton;
        private Label OrderInfoLabel;
        private ListBox OrderInfoListBox;
        private Label CheckOutInstructionLabel;
        private Button CheckOutButton;
        private Label WarningLabelQuantity;
        private Label DeleteItemLabel;
        private ComboBox ItemDeleteComboBox;
        private Button DeleteItemButton;
        private Label WarningLabelDelete;
    }
}
