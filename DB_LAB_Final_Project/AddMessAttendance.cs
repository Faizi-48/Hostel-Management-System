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
    public partial class AddMessAttendance : Form
    {
        public AddMessAttendance()
        {
            InitializeComponent();
        }

        private void AddMessAttendance_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void MessAttendance_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMessAttendance_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from mess_bill where S_ID='" + MessAttendanceID_TextBox.Text + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount == 0)
                {
                    string query;
                    query = " insert into mess_bill values(1,100,100,'"+ MessAttendanceID_TextBox.Text + "')";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);
                    MessageBox.Show("Bill Added");
                }
                else
                {
                    //total meals
                    count = new OracleCommand();
                    count.CommandText = "Select total_meals from mess_bill where S_ID='" + MessAttendanceID_TextBox.Text + "'";
                    count.Connection = con;
                    count.CommandType = CommandType.Text;
                    gym = count.ExecuteReader();
                    gym.Read();
                    int totalmeals;
                    Int32.TryParse(gym.GetString(0), out totalmeals);
                    int cost = 100;
                    totalmeals++;
                    int bill = cost * totalmeals;
                    //Updating Mess
                    string query;
                    query = "update mess_bill set total_meals =  "+totalmeals+",total_bill= "+bill+"where S_ID='"+ MessAttendanceID_TextBox.Text + "'";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);

                    MessageBox.Show("Bill Updated");
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
