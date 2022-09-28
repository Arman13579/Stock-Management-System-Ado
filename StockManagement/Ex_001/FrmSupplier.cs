using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex_001
{
    
    public partial class FrmSupplier : Form
    {
        // creating a connection string to the database
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void btnSupplierInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblSuppliers(SupplierName,SupplierAddress) VALUES(@n,@add)", con);
                cmd.Parameters.AddWithValue("@n", txtSupplierName.Text);
                cmd.Parameters.AddWithValue("@add", txtSupplierAddress.Text);

                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Supplier Added Succuessfully!!!");
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
            txtSupplierAddress.Clear();
            txtSupplierName.Clear();
        }

        private void btnShowSupplier_Click(object sender, EventArgs e)
        {
            con.Open();
           
            SqlCommand cmd = new SqlCommand("Select * from tblSuppliers", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdSupplier.DataSource = dt;
            con.Close();
        }
    }
}
