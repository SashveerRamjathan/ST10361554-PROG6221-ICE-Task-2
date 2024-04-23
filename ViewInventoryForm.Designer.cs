namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class ViewInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInventoryForm));
            DisplayInventoryLabel = new Label();
            ViewInventoryRichTextbox = new RichTextBox();
            RefreshInventoryDisplayButton = new Button();
            ItemHistoryDisplayLabel = new Label();
            ItemHistoryRichTextbox = new RichTextBox();
            ViewInventoryHeadingLabel = new Label();
            RefreshItemHistoryButton = new Button();
            SuspendLayout();
            // 
            // DisplayInventoryLabel
            // 
            DisplayInventoryLabel.AutoSize = true;
            DisplayInventoryLabel.Location = new Point(12, 33);
            DisplayInventoryLabel.Name = "DisplayInventoryLabel";
            DisplayInventoryLabel.Size = new Size(138, 15);
            DisplayInventoryLabel.TabIndex = 0;
            DisplayInventoryLabel.Text = "Items saved in inventory:";
            // 
            // ViewInventoryRichTextbox
            // 
            ViewInventoryRichTextbox.Location = new Point(12, 54);
            ViewInventoryRichTextbox.Name = "ViewInventoryRichTextbox";
            ViewInventoryRichTextbox.Size = new Size(323, 329);
            ViewInventoryRichTextbox.TabIndex = 1;
            ViewInventoryRichTextbox.Text = "";
            // 
            // RefreshInventoryDisplayButton
            // 
            RefreshInventoryDisplayButton.Location = new Point(12, 403);
            RefreshInventoryDisplayButton.Name = "RefreshInventoryDisplayButton";
            RefreshInventoryDisplayButton.Size = new Size(158, 35);
            RefreshInventoryDisplayButton.TabIndex = 2;
            RefreshInventoryDisplayButton.Text = "Refresh Inventory Items";
            RefreshInventoryDisplayButton.UseVisualStyleBackColor = true;
            RefreshInventoryDisplayButton.Click += RefreshInventoryDisplayButton_Click;
            // 
            // ItemHistoryDisplayLabel
            // 
            ItemHistoryDisplayLabel.AutoSize = true;
            ItemHistoryDisplayLabel.Location = new Point(367, 33);
            ItemHistoryDisplayLabel.Name = "ItemHistoryDisplayLabel";
            ItemHistoryDisplayLabel.Size = new Size(161, 15);
            ItemHistoryDisplayLabel.TabIndex = 3;
            ItemHistoryDisplayLabel.Text = "Last item added to inventory:";
            // 
            // ItemHistoryRichTextbox
            // 
            ItemHistoryRichTextbox.Location = new Point(358, 54);
            ItemHistoryRichTextbox.Name = "ItemHistoryRichTextbox";
            ItemHistoryRichTextbox.Size = new Size(238, 329);
            ItemHistoryRichTextbox.TabIndex = 4;
            ItemHistoryRichTextbox.Text = "";
            // 
            // ViewInventoryHeadingLabel
            // 
            ViewInventoryHeadingLabel.AutoSize = true;
            ViewInventoryHeadingLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewInventoryHeadingLabel.Location = new Point(12, 9);
            ViewInventoryHeadingLabel.Name = "ViewInventoryHeadingLabel";
            ViewInventoryHeadingLabel.Size = new Size(100, 17);
            ViewInventoryHeadingLabel.TabIndex = 17;
            ViewInventoryHeadingLabel.Text = "View Inventory";
            // 
            // RefreshItemHistoryButton
            // 
            RefreshItemHistoryButton.Location = new Point(358, 403);
            RefreshItemHistoryButton.Name = "RefreshItemHistoryButton";
            RefreshItemHistoryButton.Size = new Size(158, 35);
            RefreshItemHistoryButton.TabIndex = 18;
            RefreshItemHistoryButton.Text = "Refresh Item History";
            RefreshItemHistoryButton.UseVisualStyleBackColor = true;
            RefreshItemHistoryButton.Click += RefreshItemHistoryButton_Click;
            // 
            // ViewInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 495);
            Controls.Add(RefreshItemHistoryButton);
            Controls.Add(ViewInventoryHeadingLabel);
            Controls.Add(ItemHistoryRichTextbox);
            Controls.Add(ItemHistoryDisplayLabel);
            Controls.Add(RefreshInventoryDisplayButton);
            Controls.Add(ViewInventoryRichTextbox);
            Controls.Add(DisplayInventoryLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayInventoryLabel;
        private RichTextBox ViewInventoryRichTextbox;
        private Button RefreshInventoryDisplayButton;
        private Label ItemHistoryDisplayLabel;
        private RichTextBox ItemHistoryRichTextbox;
        private Label ViewInventoryHeadingLabel;
        private Button RefreshItemHistoryButton;
    }
}