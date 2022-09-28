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
    public partial class FrmEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DBStockManagement; Integrated Security=True");
        public FrmEmployee()
        {
            InitializeComponent();
        }

        

        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblEmployee(EmployeeName,EmployeeAddress,EmployeePhone) VALUES(@name,@add,@phone)", con);
                cmd.Parameters.AddWithValue("@name", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@add", txtEmpAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtEmpPhone.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee Inserted Successfully!!!");
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
            txtEmpName.Clear();
            txtEmpAddress.Clear();
            txtEmpPhone.Clear();         
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblEmployee",con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdEmployee.DataSource = dt;
            con.Close();
        }
    }
}
