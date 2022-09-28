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
    public partial class FrmCustomer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerId as Id, CustomerName as Name, CustomerAddress as Address, Phone  from tblCustomers", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdCustomer.DataSource = dt;
            con.Close();
        }
    }
}
