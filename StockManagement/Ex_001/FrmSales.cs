using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ex_001
{
    public partial class FrmSales : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSales.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.dsSales.tblInventory);

        }

        private void btnSalesInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPicturePath.Text);
                MemoryStream memoryStream = new MemoryStream();
                img.Save(memoryStream, ImageFormat.Bmp);

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblSales(ProductName,sUnitPrice,sQuantity,Discount,CustomerName,CusAddress,CusPhone,ProductPicture,ProductId) Values(@name, @price, @quantity, @dis, @cusName, @cusAdd, @cusPhone, @picture, @pid)", con);
                cmd.Parameters.AddWithValue("@name", cmbProductName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@dis", txtDiscount.Text);
                cmd.Parameters.AddWithValue("@cusName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@cusAdd", txtCusAdd.Text);
                cmd.Parameters.AddWithValue("@cusPhone", txtCusPhn.Text);
                cmd.Parameters.Add(new SqlParameter("@picture", SqlDbType.VarBinary) { Value = memoryStream.ToArray() });
                cmd.Parameters.AddWithValue("@pid", cmbProductName.SelectedValue);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sales Generated Successfully!!!");
                    con.Close();
                    clearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }
        }
        private void clearText()
        {
            cmbProductName.SelectedIndex = -1;
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
            txtCustomerName.Clear();
            txtCusAdd.Clear();
            txtCusPhn.Clear();
            txtPicturePath.Clear();
            
        }

        private void btnProductUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select SalesId as Id, ProductName as 'Product Name',sUnitPrice as Price,sQuantity as Quantity,Discount,TotalAmount as 'Amount After Discount',ProductPicture as Picture from tblSales ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdSales.DataSource = dt;
            con.Close();
        }

        private void btnSalesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tblSales WHERE SalesId ='" + txtSearch.Text + "' ", con);
                //cmd.Parameters.AddWithValue("@i", txtSearch.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Deleted successfully!!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }

        }

        private void btnSalesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPicturePath.Text);
                MemoryStream memoryStream = new MemoryStream();
                img.Save(memoryStream, ImageFormat.Bmp);


                SqlCommand cmd = new SqlCommand("UPDATE tblSales SET ProductName = @name,sUnitPrice = @price, sQuantity = @quantity, Discount = @dis, ProductId=@pid, ProductPicture = @pic WHERE SalesId = @search", con);


                cmd.Parameters.AddWithValue("@name", cmbProductName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@dis", txtDiscount.Text);
                //cmd.Parameters.AddWithValue("@cname", txtCustomerName.Text);
                //cmd.Parameters.AddWithValue("@cAdd", txtCusAdd.Text);
                //cmd.Parameters.AddWithValue("@cPhn", txtCusPhn.Text);
                cmd.Parameters.AddWithValue("@pid", cmbProductName.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = memoryStream.ToArray() });
                cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Updated successfully!!!");
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
                SqlCommand cmd = new SqlCommand("select ProductName ,sUnitPrice,sQuantity ,Discount,CustomerName,CusAddress,CusPhone,ProductId,ProductPicture  from tblSales where SalesId = '" + txtSearch.Text + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cmbProductName.Text = dr.GetString(0);
                    txtPrice.Text = Convert.ToString(dr.GetDecimal(1));
                    txtQuantity.Text = Convert.ToString(dr.GetInt32(2));
                    txtDiscount.Text = Convert.ToString(dr.GetDouble(3));
                    txtCustomerName.Text = dr.GetString(4);
                    txtCusAdd.Text = dr.GetString(5);
                    txtCusPhn.Text = dr.GetString(6);
                    cmbProductName.SelectedValue = dr.GetInt32(7);
                    pictureBox1.Image = Image.FromStream(dr.GetStream(8));
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }
        }
    }
}
