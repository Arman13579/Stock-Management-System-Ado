
namespace Ex_001
{
    partial class FrmSales
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
            this.grdSales = new System.Windows.Forms.DataGridView();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.btnShowSales = new System.Windows.Forms.Button();
            this.btnSalesInsert = new System.Windows.Forms.Button();
            this.txtCusAdd = new System.Windows.Forms.TextBox();
            this.txtCusPhn = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProductUpload = new System.Windows.Forms.Button();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsSales = new Ex_001.dsSales();
            this.tblInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblInventoryTableAdapter = new Ex_001.dsSalesTableAdapters.tblInventoryTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSales
            // 
            this.grdSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSales.Location = new System.Drawing.Point(203, 566);
            this.grdSales.Name = "grdSales";
            this.grdSales.RowHeadersWidth = 62;
            this.grdSales.RowTemplate.Height = 28;
            this.grdSales.Size = new System.Drawing.Size(1371, 343);
            this.grdSales.TabIndex = 48;
            // 
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesUpdate.Location = new System.Drawing.Point(521, 484);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(126, 58);
            this.btnSalesUpdate.TabIndex = 10;
            this.btnSalesUpdate.Text = "Update";
            this.btnSalesUpdate.UseVisualStyleBackColor = true;
            this.btnSalesUpdate.Click += new System.EventHandler(this.btnSalesUpdate_Click);
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesDelete.Location = new System.Drawing.Point(659, 484);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(126, 58);
            this.btnSalesDelete.TabIndex = 11;
            this.btnSalesDelete.Text = "Delete";
            this.btnSalesDelete.UseVisualStyleBackColor = true;
            this.btnSalesDelete.Click += new System.EventHandler(this.btnSalesDelete_Click);
            // 
            // btnShowSales
            // 
            this.btnShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSales.Location = new System.Drawing.Point(797, 484);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(159, 58);
            this.btnShowSales.TabIndex = 12;
            this.btnShowSales.Text = "Show Data";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // btnSalesInsert
            // 
            this.btnSalesInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesInsert.Location = new System.Drawing.Point(382, 484);
            this.btnSalesInsert.Name = "btnSalesInsert";
            this.btnSalesInsert.Size = new System.Drawing.Size(126, 58);
            this.btnSalesInsert.TabIndex = 9;
            this.btnSalesInsert.Text = "Insert";
            this.btnSalesInsert.UseVisualStyleBackColor = true;
            this.btnSalesInsert.Click += new System.EventHandler(this.btnSalesInsert_Click);
            // 
            // txtCusAdd
            // 
            this.txtCusAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAdd.Location = new System.Drawing.Point(454, 339);
            this.txtCusAdd.Name = "txtCusAdd";
            this.txtCusAdd.Size = new System.Drawing.Size(341, 35);
            this.txtCusAdd.TabIndex = 5;
            // 
            // txtCusPhn
            // 
            this.txtCusPhn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhn.Location = new System.Drawing.Point(454, 386);
            this.txtCusPhn.Name = "txtCusPhn";
            this.txtCusPhn.Size = new System.Drawing.Size(341, 35);
            this.txtCusPhn.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(454, 195);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(341, 35);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(454, 239);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(341, 35);
            this.txtDiscount.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(454, 292);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(341, 35);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(454, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(341, 35);
            this.txtPrice.TabIndex = 1;
            // 
            // cmbProductName
            // 
            this.cmbProductName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblInventoryBindingSource, "ProductId", true));
            this.cmbProductName.DataSource = this.tblInventoryBindingSource;
            this.cmbProductName.DisplayMember = "ProductName";
            this.cmbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(454, 102);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(341, 37);
            this.cmbProductName.TabIndex = 0;
            this.cmbProductName.ValueMember = "ProductId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "Product Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Discount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Customer Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Customer Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1261, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(843, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sales";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(1467, 102);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(107, 37);
            this.lblTotalAmount.TabIndex = 49;
            this.lblTotalAmount.Text = "00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(903, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 8;
            // 
            // btnProductUpload
            // 
            this.btnProductUpload.Location = new System.Drawing.Point(874, 102);
            this.btnProductUpload.Name = "btnProductUpload";
            this.btnProductUpload.Size = new System.Drawing.Size(146, 37);
            this.btnProductUpload.TabIndex = 7;
            this.btnProductUpload.Text = "Upload Picture";
            this.btnProductUpload.UseVisualStyleBackColor = true;
            this.btnProductUpload.Click += new System.EventHandler(this.btnProductUpload_Click);
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicturePath.Location = new System.Drawing.Point(1039, 102);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(148, 35);
            this.txtPicturePath.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(874, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // dsSales
            // 
            this.dsSales.DataSetName = "dsSales";
            this.dsSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblInventoryBindingSource
            // 
            this.tblInventoryBindingSource.DataMember = "tblInventory";
            this.tblInventoryBindingSource.DataSource = this.dsSales;
            // 
            // tblInventoryTableAdapter
            // 
            this.tblInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1340, 496);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(69, 35);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1437, 490);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 47);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1152, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 29);
            this.label11.TabIndex = 54;
            this.label11.Text = "Search By Id :";
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1655, 958);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPicturePath);
            this.Controls.Add(this.btnProductUpload);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.grdSales);
            this.Controls.Add(this.btnSalesUpdate);
            this.Controls.Add(this.btnSalesDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowSales);
            this.Controls.Add(this.btnSalesInsert);
            this.Controls.Add(this.txtCusAdd);
            this.Controls.Add(this.txtCusPhn);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSales;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.Button btnSalesInsert;
        private System.Windows.Forms.TextBox txtCusAdd;
        private System.Windows.Forms.TextBox txtCusPhn;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProductUpload;
        private System.Windows.Forms.TextBox txtPicturePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dsSales dsSales;
        private System.Windows.Forms.BindingSource tblInventoryBindingSource;
        private dsSalesTableAdapters.tblInventoryTableAdapter tblInventoryTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
    }
}