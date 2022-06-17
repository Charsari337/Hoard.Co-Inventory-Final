namespace Hoard.Co_Inventory_Final
{
    partial class VariantsSubScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.variantsListLabel = new System.Windows.Forms.Label();
            this.variantTitleLabel = new System.Windows.Forms.Label();
            this.variantTypeTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.variantAmountTextbox = new System.Windows.Forms.TextBox();
            this.listButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variantsListLabel
            // 
            this.variantsListLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.variantsListLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantsListLabel.Location = new System.Drawing.Point(82, 49);
            this.variantsListLabel.Name = "variantsListLabel";
            this.variantsListLabel.Size = new System.Drawing.Size(828, 460);
            this.variantsListLabel.TabIndex = 0;
            this.variantsListLabel.Text = "variantsListLabel";
            // 
            // variantTitleLabel
            // 
            this.variantTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.variantTitleLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantTitleLabel.Location = new System.Drawing.Point(82, 0);
            this.variantTitleLabel.Name = "variantTitleLabel";
            this.variantTitleLabel.Size = new System.Drawing.Size(828, 49);
            this.variantTitleLabel.TabIndex = 1;
            this.variantTitleLabel.Text = "variantTitleLabel";
            this.variantTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // variantTypeTextbox
            // 
            this.variantTypeTextbox.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantTypeTextbox.Location = new System.Drawing.Point(197, 538);
            this.variantTypeTextbox.Name = "variantTypeTextbox";
            this.variantTypeTextbox.Size = new System.Drawing.Size(279, 31);
            this.variantTypeTextbox.TabIndex = 4;
            this.variantTypeTextbox.Text = "variantTypeTextbox";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(348, 575);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 72);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(905, 601);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(92, 46);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "returnButton";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(525, 575);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(128, 72);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "removeButton";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // variantAmountTextbox
            // 
            this.variantAmountTextbox.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantAmountTextbox.Location = new System.Drawing.Point(525, 538);
            this.variantAmountTextbox.Name = "variantAmountTextbox";
            this.variantAmountTextbox.Size = new System.Drawing.Size(279, 31);
            this.variantAmountTextbox.TabIndex = 12;
            this.variantAmountTextbox.Text = "variantAmountTextbox";
            // 
            // listButton
            // 
            this.listButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButton.Location = new System.Drawing.Point(916, 263);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(78, 46);
            this.listButton.TabIndex = 13;
            this.listButton.Text = "listButton";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // VariantsSubScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.variantAmountTextbox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.variantTypeTextbox);
            this.Controls.Add(this.variantTitleLabel);
            this.Controls.Add(this.variantsListLabel);
            this.Name = "VariantsSubScreen";
            this.Size = new System.Drawing.Size(1000, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label variantsListLabel;
        private System.Windows.Forms.Label variantTitleLabel;
        private System.Windows.Forms.TextBox variantTypeTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox variantAmountTextbox;
        private System.Windows.Forms.Button listButton;
    }
}
