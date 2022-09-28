
namespace Ex_001
{
    partial class FromInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grdInventory = new System.Windows.Forms.DataGridView();
            this.btnInventoryUpdate = new System.Windows.Forms.Button();
            this.btnInventoryDelete = new System.Windows.Forms.Button();
            this.btnShowInventory = new System.Windows.Forms.Button();
            this.btnInventoryInsert = new System.Windows.Forms.Button();
            this.dsCategory = new Ex_001.dsCategory();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoryTableAdapter = new Ex_001.dsCategoryTableAdapters.tblCategoryTableAdapter();
            this.dsSupplier = new Ex_001.dsSupplier();
            this.tblSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSuppliersTableAdapter = new Ex_001.dsSupplierTableAdapters.tblSuppliersTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Supplier :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(560, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(543, 35);
            this.txtProductName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(560, 205);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(543, 35);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(560, 153);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(543, 35);
            this.txtPrice.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblCategoryBindingSource, "CategoryId", true));
            this.cmbCategory.DataSource = this.tblCategoryBindingSource;
            this.cmbCategory.DisplayMember = "CategoryName";
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(560, 308);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(543, 37);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.ValueMember = "CategoryId";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSuppliersBindingSource, "SupplierId", true));
            this.cmbSupplier.DataSource = this.tblSuppliersBindingSource;
            this.cmbSupplier.DisplayMember = "SupplierName";
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(560, 360);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(543, 37);
            this.cmbSupplier.TabIndex = 5;
            this.cmbSupplier.ValueMember = "SupplierId";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(543, 35);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // grdInventory
            // 
            this.grdInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdInventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInventory.Location = new System.Drawing.Point(274, 508);
            this.grdInventory.Name = "grdInventory";
            this.grdInventory.RowHeadersWidth = 62;
            this.grdInventory.RowTemplate.Height = 28;
            this.grdInventory.Size = new System.Drawing.Size(1271, 302);
            this.grdInventory.TabIndex = 49;
            // 
            // btnInventoryUpdate
            // 
            this.btnInventoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryUpdate.Location = new System.Drawing.Point(1185, 176);
            this.btnInventoryUpdate.Name = "btnInventoryUpdate";
            this.btnInventoryUpdate.Size = new System.Drawing.Size(126, 44);
            this.btnInventoryUpdate.TabIndex = 7;
            this.btnInventoryUpdate.Text = "Update";
            this.btnInventoryUpdate.UseVisualStyleBackColor = true;
            this.btnInventoryUpdate.Click += new System.EventHandler(this.btnInventoryUpdate_Click);
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.Location = new System.Drawing.Point(1185, 243);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(126, 54);
            this.btnInventoryDelete.TabIndex = 8;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnShowInventory
            // 
            this.btnShowInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInventory.Location = new System.Drawing.Point(1185, 347);
            this.btnShowInventory.Name = "btnShowInventory";
            this.btnShowInventory.Size = new System.Drawing.Size(133, 48);
            this.btnShowInventory.TabIndex = 9;
            this.btnShowInventory.Text = "Show Data";
            this.btnShowInventory.UseVisualStyleBackColor = true;
            this.btnShowInventory.Click += new System.EventHandler(this.btnShowInventory_Click);
            // 
            // btnInventoryInsert
            // 
            this.btnInventoryInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryInsert.Location = new System.Drawing.Point(1185, 106);
            this.btnInventoryInsert.Name = "btnInventoryInsert";
            this.btnInventoryInsert.Size = new System.Drawing.Size(126, 49);
            this.btnInventoryInsert.TabIndex = 6;
            this.btnInventoryInsert.Text = "Insert";
            this.btnInventoryInsert.UseVisualStyleBackColor = true;
            this.btnInventoryInsert.Click += new System.EventHandler(this.btnInventoryInsert_Click);
            // 
            // dsCategory
            // 
            this.dsCategory.DataSetName = "dsCategory";
            this.dsCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.dsCategory;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dsSupplier
            // 
            this.dsSupplier.DataSetName = "dsSupplier";
            this.dsSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSuppliersBindingSource
            // 
            this.tblSuppliersBindingSource.DataMember = "tblSuppliers";
            this.tblSuppliersBindingSource.DataSource = this.dsSupplier;
            // 
            // tblSuppliersTableAdapter
            // 
            this.tblSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(815, 441);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 35);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(947, 433);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 51);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(650, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Search by Id";
            // 
            // FromInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1771, 762);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInventoryUpdate);
            this.Controls.Add(this.btnInventoryDelete);
            this.Controls.Add(this.btnShowInventory);
            this.Controls.Add(this.btnInventoryInsert);
            this.Controls.Add(this.grdInventory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FromInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FromInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView grdInventory;
        private System.Windows.Forms.Button btnInventoryUpdate;
        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Button btnShowInventory;
        private System.Windows.Forms.Button btnInventoryInsert;
        private dsCategory dsCategory;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private dsCategoryTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private dsSupplier dsSupplier;
        private System.Windows.Forms.BindingSource tblSuppliersBindingSource;
        private dsSupplierTableAdapters.tblSuppliersTableAdapter tblSuppliersTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
    }
}