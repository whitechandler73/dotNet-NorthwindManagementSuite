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
                    this.Text = "Northwind Management Suite (Viewing Categories)";

                    categoriesDataGridView.Visible = true;
                    categoriesBindingNavigator.Visible = true;

                    
                    customersDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    customersBindingNavigator.Visible = false;
                    employeesBindingNavigator.Visible = false;
                    orderDetailsBindingNavigator.Visible = false;
                    ordersBindingNavigator.Visible = false;
                    productsBindingNavigator.Visible = false;
                    shippersBindingNavigator.Visible = false;
                    suppliersBindingNavigator1.Visible = false;

                    break;

                case 1:
                    this.Text = "Northwind Management Suite (Viewing Customers)";

                    customersDataGridView.Visible = true;
                    customersBindingNavigator.Visible = true;

                    categoriesDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    
                    categoriesBindingNavigator.Visible = false;
                    employeesBindingNavigator.Visible = false;
                    orderDetailsBindingNavigator.Visible = false;
                    ordersBindingNavigator.Visible = false;
                    productsBindingNavigator.Visible = false;
                    shippersBindingNavigator.Visible = false;
                    suppliersBindingNavigator1.Visible = false;

                    break;

                case 2:
                    this.Text = "Northwind Management Suite (Viewing Employees)";

                    employeesDataGridView.Visible = true;
                    employeesBindingNavigator.Visible = true;

                    customersDataGridView.Visible = false;            
                    categoriesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    categoriesBindingNavigator.Visible = false;
                    customersBindingNavigator.Visible = false;
                    categoriesBindingNavigator.Visible = false;
                    orderDetailsBindingNavigator.Visible = false;
                    productsBindingNavigator.Visible = false;
                    shippersBindingNavigator.Visible = false;
                    suppliersBindingNavigator1.Visible = false;

                    break;
                case 3:
                    this.Text = "Northwind Management Suite (Viewing Order Details)";

                    order_DetailsDataGridView.Visible = true;
                    orderDetailsBindingNavigator.Visible = true;

                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    categoriesBindingNavigator.Visible = false;
                    employeesBindingNavigator.Visible = false;
                    customersBindingNavigator.Visible = false;
                    categoriesBindingNavigator.Visible = false;
                    productsBindingNavigator.Visible = false;
                    productsBindingNavigator.Visible = false;
                    ordersBindingNavigator.Visible = false;
                    shippersBindingNavigator.Visible = false;
                    suppliersBindingNavigator1.Visible = false;

                    break;

                case 4:
                    this.Text = "Northwind Management Suite (Viewing Oders)";

                    ordersDataGridView.Visible = true;

                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    
                    categoriesBindingNavigator.Visible = false;
                    /* Delete me and finish setting visibilities */
                    break;

                case 5:
                    this.Text = "Northwind Management Suite (Viewing Products)";

                    productsDataGridView.Visible = true;


                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;


                    categoriesBindingNavigator.Visible = false;
                    /* Delete me and finish setting visibilities */
                    break;

                case 6:
                    this.Text = "Northwind Management Suite (Viewing Shippers)";

                    shippersDataGridView.Visible = true;

                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;


                    categoriesBindingNavigator.Visible = false;
                    /* Delete me and finish setting visibilities */
                    break;

                case 7:
                    this.Text = "Northwind Management Suite (Viewing Suppliers)";

                    suppliersDataGridView.Visible = true;

                    shippersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;


                    categoriesBindingNavigator.Visible = false;
                    /* Delete me and finish setting visibilities */
                    break;

                default:
                    viewControlComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();    
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDatabase);

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDatabase.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.businessDatabase.Suppliers);
            // TODO: This line of code loads data into the 'businessDatabase.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.businessDatabase.Shippers);
            // TODO: This line of code loads data into the 'businessDatabase.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.businessDatabase.Products);
            // TODO: This line of code loads data into the 'businessDatabase.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.businessDatabase.Orders);
            // TODO: This line of code loads data into the 'businessDatabase.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.businessDatabase.Order_Details);
            // TODO: This line of code loads data into the 'businessDatabase.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.businessDatabase.Employees);
            // TODO: This line of code loads data into the 'businessDatabase.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.businessDatabase.Customers);
            this.categoriesTableAdapter.Fill(this.businessDatabase.Categories); // This works

        }
    }
}
