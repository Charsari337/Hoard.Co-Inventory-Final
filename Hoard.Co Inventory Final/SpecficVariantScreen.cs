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
    public partial class SpecficVariantScreen : UserControl
    {
        public SpecficVariantScreen()
        {
            InitializeComponent();

            variantsButton.Text = "Variants";
            typeTotalButton.Text = "Type Total";

            returnButton.Text = "Return";
            helpButton.Text = "Help";

            variantsLabel.Text = "View the specific types of Hoard." +
                "\n\nEdit and change the variants types.";

            typeTotalLabel.Text = "View the total population in specific types.";
        }

        private void variantsButton_Click(object sender, EventArgs e)
        {
            VariantsSubScreen vs = new VariantsSubScreen();
            Form form = this.FindForm();

            form.Controls.Add(vs);
            form.Controls.Remove(this);

            vs.Location = new Point((form.Width - vs.Width) / 2, (form.Height - vs.Height) / 2);
        }

        private void typeTotalButton_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
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
    }
}
