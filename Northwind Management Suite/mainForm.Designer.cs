namespace Northwind_Management_Suite
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.viewControlGroupBox = new System.Windows.Forms.GroupBox();
            this.viewControlComboBox = new System.Windows.Forms.ComboBox();
            this.viewControlPromptLabel = new System.Windows.Forms.Label();
            this.businessDatabase = new Northwind_Management_Suite.BusinessDatabase();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Northwind_Management_Suite.BusinessDatabaseTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new Northwind_Management_Suite.BusinessDatabaseTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.viewControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.viewControlGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 485);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 1;
            // 
            // viewControlGroupBox
            // 
            this.viewControlGroupBox.Controls.Add(this.viewControlComboBox);
            this.viewControlGroupBox.Controls.Add(this.viewControlPromptLabel);
            this.viewControlGroupBox.Location = new System.Drawing.Point(3, 5);
            this.viewControlGroupBox.Name = "viewControlGroupBox";
            this.viewControlGroupBox.Size = new System.Drawing.Size(267, 209);
            this.viewControlGroupBox.TabIndex = 0;
            this.viewControlGroupBox.TabStop = false;
            this.viewControlGroupBox.Text = "View Control";
            // 
            // viewControlComboBox
            // 
            this.viewControlComboBox.FormattingEnabled = true;
            this.viewControlComboBox.Items.AddRange(new object[] {
            "Categories",
            "Customers",
            "Employees",
            "Order Details",
            "Orders",
            "Products",
            "Shippers",
            "Suppliers"});
            this.viewControlComboBox.Location = new System.Drawing.Point(13, 36);
            this.viewControlComboBox.Name = "viewControlComboBox";
            this.viewControlComboBox.Size = new System.Drawing.Size(152, 21);
            this.viewControlComboBox.TabIndex = 1;
            this.viewControlComboBox.SelectedIndexChanged += new System.EventHandler(this.viewControlComboBox_SelectedIndexChanged);
            // 
            // viewControlPromptLabel
            // 
            this.viewControlPromptLabel.AutoSize = true;
            this.viewControlPromptLabel.Location = new System.Drawing.Point(10, 20);
            this.viewControlPromptLabel.Name = "viewControlPromptLabel";
            this.viewControlPromptLabel.Size = new System.Drawing.Size(76, 13);
            this.viewControlPromptLabel.TabIndex = 0;
            this.viewControlPromptLabel.Text = "Select a Table";
            // 
            // businessDatabase
            // 
            this.businessDatabase.DataSetName = "BusinessDatabase";
            this.businessDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.businessDatabase;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Northwind_Management_Suite.BusinessDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "Northwind Management Suite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.viewControlGroupBox.ResumeLayout(false);
            this.viewControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox viewControlGroupBox;
        private System.Windows.Forms.ComboBox viewControlComboBox;
        private System.Windows.Forms.Label viewControlPromptLabel;
        private BusinessDatabase businessDatabase;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private BusinessDatabaseTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private BusinessDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

