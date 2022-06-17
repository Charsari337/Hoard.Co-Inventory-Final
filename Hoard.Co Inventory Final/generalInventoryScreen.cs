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
    public partial class generalInventoryScreen : UserControl
    {
        public generalInventoryScreen()
        {
            InitializeComponent();

            populationTrackerButton.Text = "Population Tracker";

            energyStorageButton.Text = "Energy Storage";

            assetsButton.Text = "Assets";

            helpButton.Text = "Help";

            returnButton.Text = "Return";
        }

        private void populationTrackerButton_Click(object sender, EventArgs e)
        {
            SpecficVariantScreen svs = new SpecficVariantScreen();
            Form form = this.FindForm();

            form.Controls.Add(svs);
            form.Controls.Remove(this);

            svs.Location = new Point((form.Width - svs.Width) / 2, (form.Height - svs.Height) / 2);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
