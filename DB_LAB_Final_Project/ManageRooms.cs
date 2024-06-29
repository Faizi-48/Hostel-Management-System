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
    public partial class ManageHostels : Form
    {
        public ManageHostels()
        {
            InitializeComponent();
        }

        private void AddFloor_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Floor Added");
        }

        private void AdminPersonalInfo_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageHostels_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void AddRoom_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectHostel_ComboBox.Text == "Boys")
                {
                    string connect = "User Id =SYSTEM;Password =system;" +
                            "Data Source=localhost:1521/XE;Pooling=false;";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();
                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter("select * from room where hostel_id=1", con);

                    adapt.Fill(dt);
                    ViewAllRooms_GridView.DataSource = dt;
                }
                else if(SelectHostel_ComboBox.Text == "Girls")
                {
                    string connect = "User Id =SYSTEM;Password =system;" +
                           "Data Source=localhost:1521/XE;Pooling=false;";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();
                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter("select * from room where hostel_id=2", con);

                    adapt.Fill(dt);
                    ViewAllRooms_GridView.DataSource = dt;
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

           
        }

        private void ViewSpecificRoom_Button_Click(object sender, EventArgs e)
        {
            AdminViewSpecificRoom spcfroom = new AdminViewSpecificRoom();
            this.Close();
            spcfroom.Show();
        }
    }
}
