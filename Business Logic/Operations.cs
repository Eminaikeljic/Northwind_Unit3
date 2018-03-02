using Database_Access_Tier;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace Business_Logic
{
    public class Operations
    {
        public DBConnection db = new DBConnection();
        public Informations info = new Informations();

        public DataTable Customers()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ContactName From Customers";
            return db.ExeReader(cmd);
        }
        public DataTable CountCustomer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count(CustomerID) From Customers";
            return db.ExeReader(cmd);
        }
        public DataTable Employees()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select FirstName From Employees";
            return db.ExeReader(cmd);
        }
        public DataTable CountEmployees()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count(EmployeeID) From Employees";
            return db.ExeReader(cmd);
        }
        public DataTable Orders()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Orders";
            return db.ExeReader(cmd);
        }
        public DataTable CountOrders()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count(OrderID) From Orders";
            return db.ExeReader(cmd);
        }

    }
}
