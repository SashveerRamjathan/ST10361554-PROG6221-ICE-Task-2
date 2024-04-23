namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class PurchaseItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseItemForm));
            ItemCategoriesComboBox = new ComboBox();
            ItemCategoryLabel = new Label();
            ItemNameComboBox = new ComboBox();
            ItemNameLabel = new Label();
            ItemQuantityLabel = new Label();
            ItemQuantityNumBox = new NumericUpDown();
            PurchaseButton = new Button();
            PurchaseItemHeadingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).BeginInit();
            SuspendLayout();
            // 
            // ItemCategoriesComboBox
            // 
            ItemCategoriesComboBox.FormattingEnabled = true;
            ItemCategoriesComboBox.Items.AddRange(new object[] { "Produce", "Dairy", "Meat", "Seafood", "Bakery", "Frozen_Foods", "Canned_Food", "Beverages", "Snacks", "Kitchen_Essentials", "Condiments", "Cleaning_Supplies", "Personal_Care", "Health_and_Wellness", "Other" });
            ItemCategoriesComboBox.Location = new Point(12, 66);
            ItemCategoriesComboBox.Name = "ItemCategoriesComboBox";
            ItemCategoriesComboBox.Size = new Size(393, 23);
            ItemCategoriesComboBox.TabIndex = 22;
            // 
            // ItemCategoryLabel
            // 
            ItemCategoryLabel.AutoSize = true;
            ItemCategoryLabel.Location = new Point(12, 38);
            ItemCategoryLabel.Name = "ItemCategoryLabel";
            ItemCategoryLabel.Size = new Size(329, 15);
            ItemCategoryLabel.TabIndex = 21;
            ItemCategoryLabel.Text = "Choose the catergory of the item you would like to purchase:";
            // 
            // ItemNameComboBox
            // 
            ItemNameComboBox.FormattingEnabled = true;
            ItemNameComboBox.Location = new Point(12, 132);
            ItemNameComboBox.Name = "ItemNameComboBox";
            ItemNameComboBox.Size = new Size(393, 23);
            ItemNameComboBox.TabIndex = 24;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(12, 105);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(309, 15);
            ItemNameLabel.TabIndex = 23;
            ItemNameLabel.Text = "Choose the name of the item you would like to purchase:";
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Location = new Point(12, 172);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(310, 15);
            ItemQuantityLabel.TabIndex = 25;
            ItemQuantityLabel.Text = "Enter the quantity of the item you would like to purchase:";
            // 
            // ItemQuantityNumBox
            // 
            ItemQuantityNumBox.Location = new Point(12, 199);
            ItemQuantityNumBox.Name = "ItemQuantityNumBox";
            ItemQuantityNumBox.Size = new Size(393, 23);
            ItemQuantityNumBox.TabIndex = 26;
            // 
            // PurchaseButton
            // 
            PurchaseButton.BackColor = Color.FromArgb(128, 255, 128);
            PurchaseButton.Location = new Point(12, 251);
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.Size = new Size(112, 35);
            PurchaseButton.TabIndex = 27;
            PurchaseButton.Text = "Purchase Item";
            PurchaseButton.UseVisualStyleBackColor = false;
            PurchaseButton.Click += PurchaseButton_Click;
            // 
            // PurchaseItemHeadingLabel
            // 
            PurchaseItemHeadingLabel.AutoSize = true;
            PurchaseItemHeadingLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PurchaseItemHeadingLabel.Location = new Point(12, 9);
            PurchaseItemHeadingLabel.Name = "PurchaseItemHeadingLabel";
            PurchaseItemHeadingLabel.Size = new Size(95, 17);
            PurchaseItemHeadingLabel.TabIndex = 28;
            PurchaseItemHeadingLabel.Text = "Purchase Item";
            // 
            // PurchaseItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 312);
            Controls.Add(PurchaseItemHeadingLabel);
            Controls.Add(PurchaseButton);
            Controls.Add(ItemQuantityNumBox);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(ItemNameComboBox);
            Controls.Add(ItemNameLabel);
            Controls.Add(ItemCategoriesComboBox);
            Controls.Add(ItemCategoryLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PurchaseItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ItemCategoriesComboBox;
        private Label ItemCategoryLabel;
        private ComboBox ItemNameComboBox;
        private Label ItemNameLabel;
        private Label ItemQuantityLabel;
        private NumericUpDown ItemQuantityNumBox;
        private Button PurchaseButton;
        private Label PurchaseItemHeadingLabel;
    }
}