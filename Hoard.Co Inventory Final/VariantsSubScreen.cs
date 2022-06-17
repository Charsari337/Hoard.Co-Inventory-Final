using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Hoard.Co_Inventory_Final
{
    public partial class VariantsSubScreen : UserControl
    {
        List<VariantSubType> varSubType = new List<VariantSubType>();
        public VariantsSubScreen()
        {
            InitializeComponent();

            variantTitleLabel.Text = "Variants Type";

            variantsListLabel.Text = "";

            variantTypeTextbox.Text = "Name";

            variantAmountTextbox.Text = "Amount";

            addButton.Text = "Add";

            removeButton.Text = "Remove";

            listButton.Text = "List";

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            SpecficVariantScreen svs = new SpecficVariantScreen();
            Form form = this.FindForm();

            form.Controls.Add(svs);
            form.Controls.Remove(this);

            svs.Location = new Point((form.Width - svs.Width) / 2, (form.Height - svs.Height) / 2);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            variantsListLabel.Text = "";

            foreach(VariantSubType var in varSubType)
            {
                variantsListLabel.Text += $"{var.name} {var.amount} \n";
            }
        }

        private void ClearInputs()
        {
            variantTypeTextbox.Text = "";
            variantAmountTextbox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = variantTypeTextbox.Text;
            string amount = variantAmountTextbox.Text;

            VariantSubType var = new VariantSubType(name, amount);
            varSubType.Add(var);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string name = variantTypeTextbox.Text;
            string amount = variantAmountTextbox.Text;

            VariantSubType var = new VariantSubType(name, amount);
            varSubType.Remove(var);
        }

        public void LoadData()
        {
            XmlReader reader = XmlReader.Create("Resources/VariantType.xml");

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Text)
                {
                    string name = reader.ReadString();

                    reader.ReadToNextSibling("amount");
                    string amount = reader.ReadString();

                    VariantSubType var = new VariantSubType(name, amount);
                    varSubType.Add(var);
                }
            }
            reader.Close();
        }
    }
}
