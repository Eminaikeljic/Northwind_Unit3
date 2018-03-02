using System;
using System.Windows.Forms;
using Business_Logic;

namespace Northwind
{
    public partial class CEO : Form
    {
        public Operations opr = new Operations();

        public CEO()
        {
            InitializeComponent();
        }

        private void CEO_Load(object sender, EventArgs e)
        { }
        
        private void bt_Employees_Click_1(object sender, EventArgs e)
        {
            Operations Employees = new Operations();
            dataGridView1.DataSource = Employees.Employees();
        }

        private void bt_ECount_Click_1(object sender, EventArgs e)
        {
            Operations ECount = new Operations();
            dataGridView2.DataSource = ECount.CountEmployees();
        }

        private void bt_Customers_Click_1(object sender, EventArgs e)
        {
            Operations cust = new Operations();
            dataGridView3.DataSource = cust.Customers();
        }

        private void bt_cCount_Click_1(object sender, EventArgs e)
        {
            Operations count = new Operations();
            dataGridView4.DataSource = count.CountCustomer();
        }

        private void bt_Orders_Click_1(object sender, EventArgs e)
        {
            Operations Orders = new Operations();
            dataGridView5.DataSource = Orders.Orders();
        }

        private void bt_OCount_Click_1(object sender, EventArgs e)
        {
            Operations OCount = new Operations();
            dataGridView6.DataSource = OCount.CountOrders();
        }
    }
}
