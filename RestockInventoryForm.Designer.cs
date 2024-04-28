namespace ST10361554_PROG6221_ICE_Task__2
{
    partial class RestockInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockInventoryForm));
            RestockInventoryLabel = new Label();
            RestockInventoryRichTextbox = new RichTextBox();
            CheckInventoryButton = new Button();
            RestockInventoryHeadingLabel = new Label();
            SuspendLayout();
            // 
            // RestockInventoryLabel
            // 
            RestockInventoryLabel.AutoSize = true;
            RestockInventoryLabel.Location = new Point(24, 43);
            RestockInventoryLabel.Name = "RestockInventoryLabel";
            RestockInventoryLabel.Size = new Size(242, 15);
            RestockInventoryLabel.TabIndex = 20;
            RestockInventoryLabel.Text = "Items in inventory that need to be restocked:";
            // 
            // RestockInventoryRichTextbox
            // 
            RestockInventoryRichTextbox.Location = new Point(24, 70);
            RestockInventoryRichTextbox.Name = "RestockInventoryRichTextbox";
            RestockInventoryRichTextbox.Size = new Size(394, 297);
            RestockInventoryRichTextbox.TabIndex = 21;
            RestockInventoryRichTextbox.Text = "";
            // 
            // CheckInventoryButton
            // 
            CheckInventoryButton.Location = new Point(24, 384);
            CheckInventoryButton.Name = "CheckInventoryButton";
            CheckInventoryButton.Size = new Size(122, 36);
            CheckInventoryButton.TabIndex = 1;
            CheckInventoryButton.Text = "Check Inventory";
            CheckInventoryButton.UseVisualStyleBackColor = true;
            CheckInventoryButton.Click += CheckInventoryButton_Click;
            // 
            // RestockInventoryHeadingLabel
            // 
            RestockInventoryHeadingLabel.AutoSize = true;
            RestockInventoryHeadingLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestockInventoryHeadingLabel.Location = new Point(12, 9);
            RestockInventoryHeadingLabel.Name = "RestockInventoryHeadingLabel";
            RestockInventoryHeadingLabel.Size = new Size(119, 17);
            RestockInventoryHeadingLabel.TabIndex = 29;
            RestockInventoryHeadingLabel.Text = "Restock Inventory";
            // 
            // RestockInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 437);
            Controls.Add(RestockInventoryHeadingLabel);
            Controls.Add(CheckInventoryButton);
            Controls.Add(RestockInventoryRichTextbox);
            Controls.Add(RestockInventoryLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RestockInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store Inventory App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RestockInventoryLabel;
        private RichTextBox RestockInventoryRichTextbox;
        private Button CheckInventoryButton;
        private Label RestockInventoryHeadingLabel;
    }
}