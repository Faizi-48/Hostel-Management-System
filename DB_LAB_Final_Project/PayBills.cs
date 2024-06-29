using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_LAB_Final_Project
{
    public partial class PayBills : Form
    {
        public PayBills()
        {
            InitializeComponent();
        }

        private void PayBills_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void PayBill_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayHostelFee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from hostel_bill where S_ID='" + PayBill_TextBox.Text + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount == 0)
                {
                    MessageBox.Show("No Bill to Pay");
                }
                else
                {
                    string query;
                    query = " delete from hostel_bill where S_ID='" + PayBill_TextBox.Text + "'";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);

                    MessageBox.Show("Bill Paid");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ViewHostel_Button_Click(object sender, EventArgs e)
        {
            string connect = "User Id =SYSTEM;Password =system;" +
               "Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connect;
            con.Open();
            string query = "select * from Hostel_Bill where S_Id='"+ PayBill_TextBox.Text + "'";

            DataTable dt = new DataTable();

            OracleDataAdapter adapt = new OracleDataAdapter(query, con);

            adapt.Fill(dt);
            BillView_GridView.DataSource = dt;
        }

        private void ViewMess_Button_Click(object sender, EventArgs e)
        {
            string connect = "User Id =SYSTEM;Password =system;" +
               "Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connect;
            con.Open();
            string query = "select * from Mess_Bill where S_Id='" + PayBill_TextBox.Text + "'";

            DataTable dt = new DataTable();

            OracleDataAdapter adapt = new OracleDataAdapter(query, con);

            adapt.Fill(dt);
            BillView_GridView.DataSource = dt;
        }

        private void PayMessDues_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from mess_bill where S_ID='" + PayBill_TextBox.Text + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount == 0)
                {
                    MessageBox.Show("No Bill to Pay");
                }
                else
                {
                    string query;
                    query = " update mess_bill set total_bill=0,total_meals=0 where S_ID='" + PayBill_TextBox.Text + "'";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);

                    MessageBox.Show("Bill Paid");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
