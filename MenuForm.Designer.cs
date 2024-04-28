namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class MenuForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            WelcomeLabel = new Label();
            MenuInstructionLabel = new Label();
            AddItemMenuButton = new Button();
            DeleteItemMenuButton = new Button();
            PurchaseItemMenuButton = new Button();
            RestockInventoryMenuButton = new Button();
            ViewInventoryMenuButton = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(370, 17);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to my Grocery Store Inventory Management App";
            // 
            // MenuInstructionLabel
            // 
            MenuInstructionLabel.AutoSize = true;
            MenuInstructionLabel.Location = new Point(12, 43);
            MenuInstructionLabel.Name = "MenuInstructionLabel";
            MenuInstructionLabel.Size = new Size(245, 15);
            MenuInstructionLabel.TabIndex = 1;
            MenuInstructionLabel.Text = "Please select one of the menu options below:";
            // 
            // AddItemMenuButton
            // 
            AddItemMenuButton.Location = new Point(12, 86);
            AddItemMenuButton.Name = "AddItemMenuButton";
            AddItemMenuButton.Size = new Size(152, 36);
            AddItemMenuButton.TabIndex = 1;
            AddItemMenuButton.Text = "Add Item";
            AddItemMenuButton.UseVisualStyleBackColor = true;
            AddItemMenuButton.Click += AddItemMenuButton_Click;
            // 
            // DeleteItemMenuButton
            // 
            DeleteItemMenuButton.Location = new Point(12, 160);
            DeleteItemMenuButton.Name = "DeleteItemMenuButton";
            DeleteItemMenuButton.Size = new Size(152, 36);
            DeleteItemMenuButton.TabIndex = 2;
            DeleteItemMenuButton.Text = "Delete Item";
            DeleteItemMenuButton.UseVisualStyleBackColor = true;
            DeleteItemMenuButton.Click += DeleteItemMenuButton_Click;
            // 
            // PurchaseItemMenuButton
            // 
            PurchaseItemMenuButton.Location = new Point(230, 86);
            PurchaseItemMenuButton.Name = "PurchaseItemMenuButton";
            PurchaseItemMenuButton.Size = new Size(152, 36);
            PurchaseItemMenuButton.TabIndex = 4;
            PurchaseItemMenuButton.Text = "Purchase Item";
            PurchaseItemMenuButton.UseVisualStyleBackColor = true;
            PurchaseItemMenuButton.Click += PurchaseItemMenuButton_Click;
            // 
            // RestockInventoryMenuButton
            // 
            RestockInventoryMenuButton.Location = new Point(230, 160);
            RestockInventoryMenuButton.Name = "RestockInventoryMenuButton";
            RestockInventoryMenuButton.Size = new Size(152, 36);
            RestockInventoryMenuButton.TabIndex = 5;
            RestockInventoryMenuButton.Text = "Restock Inventory";
            RestockInventoryMenuButton.UseVisualStyleBackColor = true;
            RestockInventoryMenuButton.Click += RestockItemMenuButton_Click;
            // 
            // ViewInventoryMenuButton
            // 
            ViewInventoryMenuButton.Location = new Point(12, 241);
            ViewInventoryMenuButton.Name = "ViewInventoryMenuButton";
            ViewInventoryMenuButton.Size = new Size(152, 36);
            ViewInventoryMenuButton.TabIndex = 3;
            ViewInventoryMenuButton.Text = "View Inventory";
            ViewInventoryMenuButton.UseVisualStyleBackColor = true;
            ViewInventoryMenuButton.Click += ViewInventoryMenuButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 311);
            Controls.Add(ViewInventoryMenuButton);
            Controls.Add(RestockInventoryMenuButton);
            Controls.Add(PurchaseItemMenuButton);
            Controls.Add(DeleteItemMenuButton);
            Controls.Add(AddItemMenuButton);
            Controls.Add(MenuInstructionLabel);
            Controls.Add(WelcomeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label MenuInstructionLabel;
        private Button AddItemMenuButton;
        private Button DeleteItemMenuButton;
        private Button RestockInventoryMenuButton;
        private Button PurchaseItemMenuButton;
        private Button ViewInventoryMenuButton;
    }
}