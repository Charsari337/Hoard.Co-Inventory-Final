namespace Hoard.Co_Inventory_Final
{
    partial class generalInventoryScreen
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
            this.populationTrackerButton = new System.Windows.Forms.Button();
            this.assetsButton = new System.Windows.Forms.Button();
            this.energyStorageButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // populationTrackerButton
            // 
            this.populationTrackerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationTrackerButton.Location = new System.Drawing.Point(3, 3);
            this.populationTrackerButton.Name = "populationTrackerButton";
            this.populationTrackerButton.Size = new System.Drawing.Size(500, 325);
            this.populationTrackerButton.TabIndex = 0;
            this.populationTrackerButton.Text = "populationTrackerButton";
            this.populationTrackerButton.UseVisualStyleBackColor = true;
            // 
            // assetsButton
            // 
            this.assetsButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetsButton.Location = new System.Drawing.Point(3, 322);
            this.assetsButton.Name = "assetsButton";
            this.assetsButton.Size = new System.Drawing.Size(500, 325);
            this.assetsButton.TabIndex = 1;
            this.assetsButton.Text = "assetsButton";
            this.assetsButton.UseVisualStyleBackColor = true;
            // 
            // energyStorageButton
            // 
            this.energyStorageButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyStorageButton.Location = new System.Drawing.Point(497, 3);
            this.energyStorageButton.Name = "energyStorageButton";
            this.energyStorageButton.Size = new System.Drawing.Size(500, 325);
            this.energyStorageButton.TabIndex = 2;
            this.energyStorageButton.Text = "energyStorageButton";
            this.energyStorageButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(497, 322);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(500, 325);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(438, 288);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(119, 70);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "returnButton";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // generalInventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.energyStorageButton);
            this.Controls.Add(this.assetsButton);
            this.Controls.Add(this.populationTrackerButton);
            this.Name = "generalInventoryScreen";
            this.Size = new System.Drawing.Size(1000, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button populationTrackerButton;
        private System.Windows.Forms.Button assetsButton;
        private System.Windows.Forms.Button energyStorageButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button returnButton;
    }
}
