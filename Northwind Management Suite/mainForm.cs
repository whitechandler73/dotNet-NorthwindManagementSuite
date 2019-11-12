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
                    //categoriesBindingNavigator.Visible = true;

                    
                    customersDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    //customersBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 1:
                    this.Text = "Northwind Management Suite (Viewing Customers)";

                    customersDataGridView.Visible = true;
                    //customersBindingNavigator.Visible = true;

                    categoriesDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    
                    //categoriesBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 2:
                    this.Text = "Northwind Management Suite (Viewing Employees)";

                    employeesDataGridView.Visible = true;
                    //employeesBindingNavigator.Visible = true;

                    customersDataGridView.Visible = false;            
                    categoriesDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    //categoriesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;
                    //categoriesBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;
                case 3:
                    this.Text = "Northwind Management Suite (Viewing Order Details)";

                    order_DetailsDataGridView.Visible = true;
                    //orderDetailsBindingNavigator.Visible = true;

                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    //categoriesBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;
                    //categoriesBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 4:
                    this.Text = "Northwind Management Suite (Viewing Oders)";

                    ordersDataGridView.Visible = true;
                    //ordersBindingNavigator.Visible = true;

                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;

                    
                    //categoriesBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 5:
                    this.Text = "Northwind Management Suite (Viewing Products)";

                    productsDataGridView.Visible = true;
                    //productsBindingNavigator.Visible = true;


                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    shippersDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;


                    //categoriesBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 6:
                    this.Text = "Northwind Management Suite (Viewing Shippers)";

                    shippersDataGridView.Visible = true;
                    //shippersBindingNavigator.Visible = true;

                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;
                    suppliersDataGridView.Visible = false;


                    //categoriesBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;
                    //suppliersBindingNavigator1.Visible = false;

                    break;

                case 7:
                    this.Text = "Northwind Management Suite (Viewing Suppliers)";

                    suppliersDataGridView.Visible = true;
                    //suppliersBindingNavigator1.Visible = true;

                    shippersDataGridView.Visible = false;
                    productsDataGridView.Visible = false;
                    ordersDataGridView.Visible = false;
                    order_DetailsDataGridView.Visible = false;
                    employeesDataGridView.Visible = false;
                    customersDataGridView.Visible = false;
                    categoriesDataGridView.Visible = false;


                    //categoriesBindingNavigator.Visible = false;
                    //shippersBindingNavigator.Visible = false;
                    //productsBindingNavigator.Visible = false;
                    //ordersBindingNavigator.Visible = false;
                    //orderDetailsBindingNavigator.Visible = false;
                    //employeesBindingNavigator.Visible = false;
                    //customersBindingNavigator.Visible = false;

                    break;

                default:
                    viewControlComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.categoriesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.businessDatabase);
            } catch (Exception ex) {
                MessageBox.Show("Oopsie! Error!\n" + ex.StackTrace.ToString());
            }


        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.suppliersTableAdapter.Fill(this.businessDatabase.Suppliers);
                this.shippersTableAdapter.Fill(this.businessDatabase.Shippers);
                this.productsTableAdapter.Fill(this.businessDatabase.Products);
                this.ordersTableAdapter.Fill(this.businessDatabase.Orders);
                this.order_DetailsTableAdapter.Fill(this.businessDatabase.Order_Details);
                this.employeesTableAdapter.Fill(this.businessDatabase.Employees);
                this.customersTableAdapter.Fill(this.businessDatabase.Customers);
                this.categoriesTableAdapter.Fill(this.businessDatabase.Categories);
            } catch (Exception ex) { MessageBox.Show("Oopsie! Error!\n" + ex.StackTrace.ToString()); }


        }

        private void githubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/whitechandler73/dotNet-NorthwindManagementSuite");
            }
            catch (SystemException sysEx) { 
                MessageBox.Show("Oopsie! Error!\n" + sysEx.StackTrace.ToString()); 
            }
            catch (Exception ex) { 
                MessageBox.Show("Oopsie! Error!\n" + ex.StackTrace.ToString()); 
            }
        }
    }
}
