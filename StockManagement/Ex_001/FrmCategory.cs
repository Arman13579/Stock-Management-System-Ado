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
    public partial class FrmCategory : Form
    {
        // creating a connection string to the database
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnInsetCategory_Click(object sender, EventArgs e)
        {
            try { 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO tblCategory(CategoryName) VALUES(@categoryName)";
                cmd.Parameters.AddWithValue("@categoryName",txtCategory.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product Inserted succesfully!!!");
                    con.Close();
                    ClearTextBoxes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Insert Correctly. Error Occurred!!" + ex);
            }

        }

        private void ClearTextBoxes()
        {
            txtCategory.Clear();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            con.Open();
            string selectQuery = "SELECT * FROM tblCategory";
            SqlCommand cmd = new SqlCommand(selectQuery,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdCategory.DataSource = dt;
            con.Close();
           
        }

       

       

       
    }
}
