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
    public partial class STDViewBills : Form
    {
        public STDViewBills()
        {
            InitializeComponent();
        }

        private void STDViewBills_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STDViewBills_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void STDViewBills_Label_Click(object sender, EventArgs e)
        {

        }

        private void STD_ViewMess_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                            "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter("select * from mess_bill where S_id='" + LoginSTD.std_id + "'", con);

                adapt.Fill(dt);
                STDBillView_GridBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void STD_ViewHostel_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                            "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter("select * from hostel_bill where S_id='"+LoginSTD.std_id+"'", con);

                adapt.Fill(dt);
                STDBillView_GridBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }



        }

        private void ViewBills_ApplyGYM_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
               
                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from gym_application where S_ID='" + LoginSTD.std_id + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount != 0)
                {
                    MessageBox.Show("Already Applied");
                }
                else
                {
                    string query;
                    query = " insert into gym_application (s_id,Apply_Date)values('" + LoginSTD.std_id + "', TO_Date(SYSDATE, 'DD-MM-YYYY'))";
                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                    DataTable dtable = new DataTable();
                    oracleDataAdapter.Fill(dtable);
                    
                    MessageBox.Show("Applied");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
