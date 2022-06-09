using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoard.Co_Inventory_Final
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();

            titleLabel.Text = "Hoard.CO Inventory System";

            inventoryButton.Text = "Inventory";
            helpButton.Text = "Help";
            exitButton.Text = "Exit";
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            generalInventoryScreen gis = new generalInventoryScreen();
            Form form = this.FindForm();

            form.Controls.Add(gis);
            form.Controls.Remove(this);

            gis.Location = new Point((form.Width - gis.Width) / 2, (form.Height - gis.Height) / 2);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
