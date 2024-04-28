namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class AddItemForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            AddItemInstructionsLabel = new Label();
            ItemNameLabel = new Label();
            ItemNameTextbox = new TextBox();
            ItemPriceLabel = new Label();
            ItemPriceTextbox = new TextBox();
            ItemQuantityLabel = new Label();
            ItemCategoryLabel = new Label();
            ItemMinQuantityLabel = new Label();
            ItemCategoryComboBox = new ComboBox();
            AddToInventoryButton = new Button();
            ItemQuantityNumBox = new NumericUpDown();
            ItemMinQuantityNumBox = new NumericUpDown();
            AddItemHeadingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemMinQuantityNumBox).BeginInit();
            SuspendLayout();
            // 
            // AddItemInstructionsLabel
            // 
            AddItemInstructionsLabel.AutoSize = true;
            AddItemInstructionsLabel.Location = new Point(12, 38);
            AddItemInstructionsLabel.Name = "AddItemInstructionsLabel";
            AddItemInstructionsLabel.Size = new Size(373, 15);
            AddItemInstructionsLabel.TabIndex = 1;
            AddItemInstructionsLabel.Text = "To add an item to inventory please provide the following information:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(12, 72);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(120, 15);
            ItemNameLabel.TabIndex = 2;
            ItemNameLabel.Text = "Enter the item name: ";
            // 
            // ItemNameTextbox
            // 
            ItemNameTextbox.Location = new Point(138, 69);
            ItemNameTextbox.Name = "ItemNameTextbox";
            ItemNameTextbox.Size = new Size(354, 23);
            ItemNameTextbox.TabIndex = 1;
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Location = new Point(12, 112);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(113, 15);
            ItemPriceLabel.TabIndex = 4;
            ItemPriceLabel.Text = "Enter the item price:\r\n";
            // 
            // ItemPriceTextbox
            // 
            ItemPriceTextbox.Location = new Point(138, 109);
            ItemPriceTextbox.Name = "ItemPriceTextbox";
            ItemPriceTextbox.Size = new Size(354, 23);
            ItemPriceTextbox.TabIndex = 2;
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Location = new Point(12, 155);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(168, 15);
            ItemQuantityLabel.TabIndex = 6;
            ItemQuantityLabel.Text = "Enter the quantity of the item: \r\n";
            // 
            // ItemCategoryLabel
            // 
            ItemCategoryLabel.AutoSize = true;
            ItemCategoryLabel.Location = new Point(12, 197);
            ItemCategoryLabel.Name = "ItemCategoryLabel";
            ItemCategoryLabel.Size = new Size(259, 15);
            ItemCategoryLabel.TabIndex = 8;
            ItemCategoryLabel.Text = "Please choose the category the item belongs to:\r\n";
            // 
            // ItemMinQuantityLabel
            // 
            ItemMinQuantityLabel.AutoSize = true;
            ItemMinQuantityLabel.Location = new Point(12, 236);
            ItemMinQuantityLabel.Name = "ItemMinQuantityLabel";
            ItemMinQuantityLabel.Size = new Size(331, 15);
            ItemMinQuantityLabel.TabIndex = 10;
            ItemMinQuantityLabel.Text = "Enter the minimum quantity allowed of the item in inventory:\r\n";
            // 
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Items.AddRange(new object[] { "Produce", "Dairy", "Meat", "Seafood", "Bakery", "Frozen_Foods", "Canned_Food", "Beverages", "Snacks", "Kitchen_Essentials", "Condiments", "Cleaning_Supplies", "Personal_Care", "Health_and_Wellness", "Other" });
            ItemCategoryComboBox.Location = new Point(277, 194);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(215, 23);
            ItemCategoryComboBox.TabIndex = 4;
            // 
            // AddToInventoryButton
            // 
            AddToInventoryButton.BackColor = Color.FromArgb(128, 255, 128);
            AddToInventoryButton.Location = new Point(407, 291);
            AddToInventoryButton.Name = "AddToInventoryButton";
            AddToInventoryButton.Size = new Size(117, 35);
            AddToInventoryButton.TabIndex = 6;
            AddToInventoryButton.Text = "Add to inventory";
            AddToInventoryButton.UseVisualStyleBackColor = false;
            AddToInventoryButton.Click += AddToInventoryButton_Click;
            // 
            // ItemQuantityNumBox
            // 
            ItemQuantityNumBox.Location = new Point(186, 153);
            ItemQuantityNumBox.Name = "ItemQuantityNumBox";
            ItemQuantityNumBox.Size = new Size(306, 23);
            ItemQuantityNumBox.TabIndex = 3;
            // 
            // ItemMinQuantityNumBox
            // 
            ItemMinQuantityNumBox.Location = new Point(349, 234);
            ItemMinQuantityNumBox.Name = "ItemMinQuantityNumBox";
            ItemMinQuantityNumBox.Size = new Size(143, 23);
            ItemMinQuantityNumBox.TabIndex = 5;
            // 
            // AddItemHeadingLabel
            // 
            AddItemHeadingLabel.AutoSize = true;
            AddItemHeadingLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemHeadingLabel.Location = new Point(12, 9);
            AddItemHeadingLabel.Name = "AddItemHeadingLabel";
            AddItemHeadingLabel.Size = new Size(65, 17);
            AddItemHeadingLabel.TabIndex = 16;
            AddItemHeadingLabel.Text = "Add Item";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 338);
            Controls.Add(AddItemHeadingLabel);
            Controls.Add(ItemMinQuantityNumBox);
            Controls.Add(ItemQuantityNumBox);
            Controls.Add(AddToInventoryButton);
            Controls.Add(ItemCategoryComboBox);
            Controls.Add(ItemMinQuantityLabel);
            Controls.Add(ItemCategoryLabel);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(ItemPriceTextbox);
            Controls.Add(ItemPriceLabel);
            Controls.Add(ItemNameTextbox);
            Controls.Add(ItemNameLabel);
            Controls.Add(AddItemInstructionsLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemMinQuantityNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AddItemInstructionsLabel;
        private Label ItemNameLabel;
        private TextBox ItemNameTextbox;
        private Label ItemPriceLabel;
        private TextBox ItemPriceTextbox;
        private Label ItemQuantityLabel;
        private Label ItemCategoryLabel;
        private Label ItemMinQuantityLabel;
        private ComboBox ItemCategoryComboBox;
        private Button AddToInventoryButton;
        private NumericUpDown ItemQuantityNumBox;
        private NumericUpDown ItemMinQuantityNumBox;
        private Label AddItemHeadingLabel;
    }
}
