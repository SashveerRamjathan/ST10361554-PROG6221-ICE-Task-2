namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class DeleteItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemForm));
            ItemNameLabel = new Label();
            ItemNameComboBox = new ComboBox();
            DeleteItemButton = new Button();
            DeleteItemHeadingLabel = new Label();
            ItemCategoryLabel = new Label();
            ItemCategoryComboBox = new ComboBox();
            CheckCategoryButton = new Button();
            SuspendLayout();
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(12, 111);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(290, 15);
            ItemNameLabel.TabIndex = 19;
            ItemNameLabel.Text = "Choose the name of the item you would like to delete";
            // 
            // ItemNameComboBox
            // 
            ItemNameComboBox.FormattingEnabled = true;
            ItemNameComboBox.Location = new Point(12, 139);
            ItemNameComboBox.Name = "ItemNameComboBox";
            ItemNameComboBox.Size = new Size(290, 23);
            ItemNameComboBox.TabIndex = 3;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteItemButton.Location = new Point(12, 187);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(90, 29);
            DeleteItemButton.TabIndex = 4;
            DeleteItemButton.Text = "Delete Item";
            DeleteItemButton.UseVisualStyleBackColor = false;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // DeleteItemHeadingLabel
            // 
            DeleteItemHeadingLabel.AutoSize = true;
            DeleteItemHeadingLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteItemHeadingLabel.Location = new Point(12, 9);
            DeleteItemHeadingLabel.Name = "DeleteItemHeadingLabel";
            DeleteItemHeadingLabel.Size = new Size(78, 17);
            DeleteItemHeadingLabel.TabIndex = 29;
            DeleteItemHeadingLabel.Text = "Delete Item";
            // 
            // ItemCategoryLabel
            // 
            ItemCategoryLabel.AutoSize = true;
            ItemCategoryLabel.Location = new Point(12, 41);
            ItemCategoryLabel.Name = "ItemCategoryLabel";
            ItemCategoryLabel.Size = new Size(309, 15);
            ItemCategoryLabel.TabIndex = 30;
            ItemCategoryLabel.Text = "Choose the category of the item you would like to delete:";
            // 
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Items.AddRange(new object[] { "Produce", "Dairy", "Meat", "Seafood", "Bakery", "Frozen_Foods", "Canned_Food", "Beverages", "Snacks", "Kitchen_Essentials", "Condiments", "Cleaning_Supplies", "Personal_Care", "Health_and_Wellness", "Other" });
            ItemCategoryComboBox.Location = new Point(12, 70);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(290, 23);
            ItemCategoryComboBox.TabIndex = 1;
            // 
            // CheckCategoryButton
            // 
            CheckCategoryButton.Location = new Point(308, 70);
            CheckCategoryButton.Name = "CheckCategoryButton";
            CheckCategoryButton.Size = new Size(107, 25);
            CheckCategoryButton.TabIndex = 2;
            CheckCategoryButton.Text = "Check Category For Items";
            CheckCategoryButton.UseVisualStyleBackColor = true;
            CheckCategoryButton.Click += CheckCategoryButton_Click;
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 227);
            Controls.Add(CheckCategoryButton);
            Controls.Add(ItemCategoryComboBox);
            Controls.Add(ItemCategoryLabel);
            Controls.Add(DeleteItemHeadingLabel);
            Controls.Add(DeleteItemButton);
            Controls.Add(ItemNameComboBox);
            Controls.Add(ItemNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ItemNameLabel;
        private ComboBox ItemNameComboBox;
        private Button DeleteItemButton;
        private Label DeleteItemHeadingLabel;
        private Label ItemCategoryLabel;
        private ComboBox ItemCategoryComboBox;
        private Button CheckCategoryButton;
    }
}