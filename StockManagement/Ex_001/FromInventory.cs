using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_001
{
    public partial class FromInventory : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FromInventory()
        {
            InitializeComponent();
        }

        private void btnInventoryInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblInventory(ProductName,pUnitPrice,pQuantity,PurchaseDate,Category,Supplier)VALUES(@n, @p, @q, @date, @category, @s)", con);
                cmd.Parameters.AddWithValue("@n", txtProductName.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@q", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@s", cmbSupplier.SelectedValue);

                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product inserted successfully !!!");
                    con.Close();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }


        }

        private void ClearTextBoxes()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbSupplier.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
        }

        private void FromInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplier.tblSuppliers' table. You can move, or remove it, as needed.
            this.tblSuppliersTableAdapter.Fill(this.dsSupplier.tblSuppliers);
            // TODO: This line of code loads data into the 'dsCategory.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.dsCategory.tblCategory);

        }

        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select i.ProductId,i.ProductName,i.pUnitPrice,i.pQuantity,i.PurchaseDate,c.CategoryName,s.SupplierName from tblInventory i join tblCategory c on i.Category =c.CategoryId join tblSuppliers s on s.SupplierId = i.Supplier", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                grdInventory.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM tblInventory WHERE ProductId = @search", con);
                cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Deleted Successfully!!!");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ProductName,pUnitPrice,pQuantity,PurchaseDate,Category,Supplier from tblInventory where ProductId = @search", con);
                cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtProductName.Text = dr.GetString(0);
                    txtPrice.Text = Convert.ToString(dr.GetDecimal(1));
                    txtQuantity.Text = Convert.ToString(dr.GetInt32(2));
                    dateTimePicker1.Text = Convert.ToString(dr.GetDateTime(3));
                    cmbCategory.SelectedValue = dr.GetInt32(4);
                    cmbSupplier.SelectedValue = dr.GetInt32(5);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }


        }

        private void btnInventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tblInventory SET ProductName = @name, pUnitPrice = @price, pQuantity = @quantity, PurchaseDate = @date, Category = @category, Supplier = @supplier WHERE ProductId = @search", con);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@supplier", cmbSupplier.SelectedValue);
                cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product updated successfully !!!");
                    con.Close();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }
        }
    }
}
