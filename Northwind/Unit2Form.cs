using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using Business_Logic;

namespace Northwind
{
    public partial class Unit2Form : Form
    { 
        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();

        public Unit2Form()
        {
            InitializeComponent();
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            Operations cust = new Operations();
            dataGridView2.DataSource = cust.Customers();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            Operations count = new Operations();
            dataGridView1.DataSource = count.CountCustomer();
        }

        private void Unit2Form_Load(object sender, EventArgs e)
        {

        }
    }
}
