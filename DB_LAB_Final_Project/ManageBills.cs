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
    public partial class ManageBills : Form
    {
        public ManageBills()
        {
            InitializeComponent();
        }

        private void GenerateBill_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageBills_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void PayBill_Button_Click(object sender, EventArgs e)
        {
            PayBills paybill = new PayBills();
            this.Hide();
            paybill.Show();
        }

        private void GenerateHostelFee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from hostel_bill where S_ID='" + GenerateBill_TextBox.Text + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount != 0)
                {
                    MessageBox.Show("Get Last Bill First");
                }
                else
                {
                    string query;
                    query = " insert into hostel_bill values('" + GenerateBill_TextBox.Text + "', 36000)";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);

                    MessageBox.Show("Bill Generated");
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
