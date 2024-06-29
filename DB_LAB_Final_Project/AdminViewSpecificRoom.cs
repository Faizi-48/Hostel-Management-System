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
    public partial class AdminViewSpecificRoom : Form
    {
        public AdminViewSpecificRoom()
        {
            InitializeComponent();
        }

        private void AdminViewSpecificRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void ViewSpecificRoom_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewSpecificRoom_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectHostel_Specific_ComboBox.Text == "Boys")
                {
                    string connect = "User Id =SYSTEM;Password =system;" +
                            "Data Source=localhost:1521/XE;Pooling=false;";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();
                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter("select s_id,s_name from student where room_no=" + ViewSpecificRoom_TextBox.Text + "and hostel_id = 1", con);

                    adapt.Fill(dt);
                    AdminViewSpecificRoom_GridView.DataSource = dt;
                }
                else if (SelectHostel_Specific_ComboBox.Text == "Girls")
                {
                    string connect = "User Id =SYSTEM;Password =system;" +
                           "Data Source=localhost:1521/XE;Pooling=false;";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();
                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter("select s_id,s_name from student where room_no="+ ViewSpecificRoom_TextBox .Text+ "and hostel_id = 2", con);

                    adapt.Fill(dt);
                    AdminViewSpecificRoom_GridView.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
