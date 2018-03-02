using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void bt_Login_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter sdf = new SqlDataAdapter("Select * from login_database where Username='" + txt_UserName.Text + "' and Password='" + txt_PWD.Text + "'", con);
                DataTable dt = new DataTable();
                sdf.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();

                    if (dt.Rows[0][0].ToString() == "HR")
                    {
                        HR hr = new HR();
                        hr.Show();
                    }
                    else if (dt.Rows[0][0].ToString() == "CEO")
                    {
                        CEO ceo = new CEO();
                        ceo.Show();
                    }
                    else if (dt.Rows[0][0].ToString() == "Sales")
                    {
                        Sales sales = new Sales();
                        sales.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
               }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}