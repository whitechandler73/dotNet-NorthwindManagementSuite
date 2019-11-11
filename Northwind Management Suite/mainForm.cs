using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_Management_Suite
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void viewControlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(viewControlComboBox.SelectedIndex)
            {
                case 0:

                    break;

                case 1:

                    break;

                case 2:

                    break;
                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                default:

                    break;
            }
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDatabase);

        }
    }
}
