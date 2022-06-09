namespace Hoard.Co_Inventory_Final
{
    partial class SpecficVariantScreen
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
            this.variantsButton = new System.Windows.Forms.Button();
            this.typeTotalButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.variantsLabel = new System.Windows.Forms.Label();
            this.typeTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // variantsButton
            // 
            this.variantsButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantsButton.Location = new System.Drawing.Point(167, 19);
            this.variantsButton.Name = "variantsButton";
            this.variantsButton.Size = new System.Drawing.Size(260, 115);
            this.variantsButton.TabIndex = 0;
            this.variantsButton.Text = "variantsButton";
            this.variantsButton.UseVisualStyleBackColor = true;
            this.variantsButton.Click += new System.EventHandler(this.variantsButton_Click);
            // 
            // typeTotalButton
            // 
            this.typeTotalButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTotalButton.Location = new System.Drawing.Point(576, 19);
            this.typeTotalButton.Name = "typeTotalButton";
            this.typeTotalButton.Size = new System.Drawing.Size(260, 115);
            this.typeTotalButton.TabIndex = 1;
            this.typeTotalButton.Text = "typetotalButton";
            this.typeTotalButton.UseVisualStyleBackColor = true;
            this.typeTotalButton.Click += new System.EventHandler(this.typeTotalButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(851, 498);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(146, 52);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "helpButton";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(3, 498);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(146, 52);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "returnButton";
            this.returnButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // variantsLabel
            // 
            this.variantsLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.variantsLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variantsLabel.Location = new System.Drawing.Point(117, 141);
            this.variantsLabel.Name = "variantsLabel";
            this.variantsLabel.Size = new System.Drawing.Size(356, 346);
            this.variantsLabel.TabIndex = 4;
            this.variantsLabel.Text = "variantsLabel";
            this.variantsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // typeTotalLabel
            // 
            this.typeTotalLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.typeTotalLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTotalLabel.Location = new System.Drawing.Point(525, 141);
            this.typeTotalLabel.Name = "typeTotalLabel";
            this.typeTotalLabel.Size = new System.Drawing.Size(356, 346);
            this.typeTotalLabel.TabIndex = 5;
            this.typeTotalLabel.Text = "typeTotalLabel";
            this.typeTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpecficVariantScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeTotalLabel);
            this.Controls.Add(this.variantsLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.typeTotalButton);
            this.Controls.Add(this.variantsButton);
            this.Name = "SpecficVariantScreen";
            this.Size = new System.Drawing.Size(1000, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button variantsButton;
        private System.Windows.Forms.Button typeTotalButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label variantsLabel;
        private System.Windows.Forms.Label typeTotalLabel;
    }
}
