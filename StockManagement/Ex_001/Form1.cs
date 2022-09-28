using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategory c = new FrmCategory();
            c.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplier s = new FrmSupplier();
            s.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromInventory i = new FromInventory();
            i.Show(); 
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSales sales = new FrmSales();
            sales.Show(); 
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee employee = new FrmEmployee();
            employee.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport report = new FrmReport();
            report.Show();
            
        }
    }
}
