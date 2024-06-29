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
    public partial class ManageRoomShift : Form
    {
        public ManageRoomShift()
        {
            InitializeComponent();
        }

        private void RoomShift_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageRoomShift_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void AddMessAttendance_Button_Click(object sender, EventArgs e)
        {
            string connect = "User Id =SYSTEM;Password =system;" +
                                "Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connect;
            con.Open();
            string query = "select * from shift";

            DataTable dt = new DataTable();

            OracleDataAdapter adapt = new OracleDataAdapter(query, con);

            adapt.Fill(dt);
            ShiftApplications_GridView.DataSource = dt;
        }

        private void ApproveShift_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int hostel;
                int capacityshift;
                int strengthshift;
                int strengthcurrent;


                //Getting Hostel
                string stringhostel;
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select hostel_id from student where S_ID = '" + ShiftSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringhostel = dr.GetString(0);
                hostel = Int32.Parse(stringhostel);

                //Getting Shift Room_No
                string stringroom;
                con = new OracleConnection(connect);
                con.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "Select s_roomno from shift where S_ID = '" + ShiftSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringroom = dr.GetString(0);

                //Current Room
                string stringroomcurr;
                con = new OracleConnection(connect);
                con.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "Select c_roomno from shift where S_ID = '" + ShiftSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringroomcurr = dr.GetString(0);

                //Getting Strength
                string stringstrength;
                con = new OracleConnection(connect);
                con.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "Select room_strength from room where room_no=" + stringroom + "and hostel_id = " + hostel;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringstrength = dr.GetString(0);
                strengthshift = Int32.Parse(stringstrength);


                //Getting Capacity
                string stringcapacity;
                cmd = new OracleCommand();
                cmd.CommandText = "Select room_capacity from room where room_no=" + stringroom + "and hostel_id = " + hostel;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringcapacity = dr.GetString(0);
                capacityshift = Int32.Parse(stringcapacity);
                //If Capacity > Strength

                if (capacityshift > strengthshift)
                {
                    string stringstrengthcurr;
                    //Strength
                    cmd = new OracleCommand();
                    cmd.CommandText = "Select room_strength from room where room_no=" + stringroomcurr + "and hostel_id = " + hostel;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    dr = cmd.ExecuteReader();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    stringstrengthcurr = dr.GetString(0);
                    strengthcurrent = Int32.Parse(stringstrengthcurr);
                    strengthcurrent--;
                    strengthshift++;


                    //Student
                    string query = "Update student set room_no ="+stringroom;
                    //Changing Current Strength
                    string query1 = "Update room set room_strength=" + strengthcurrent + "where room_no=" + stringroomcurr + "and hostel_id=" + hostel;
                    //Changing Shift
                    string query2 = "update room set room_strength=" + strengthshift + "where room_no=" + stringroom + "and hostel_id = " + hostel;
                    //Deleting Request
                    string query3= "delete from shift where s_id='"+ ShiftSTDID_TextBox.Text + "'";

                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                    adapt.Fill(dt);
                    //Query 2
                    dt = new DataTable();
                    adapt = new OracleDataAdapter(query1, con);

                    adapt.Fill(dt);
                    //Query 3
                    dt = new DataTable();
                    adapt = new OracleDataAdapter(query2, con);

                    adapt.Fill(dt);
                    //Query 4
                    dt = new DataTable();
                    adapt = new OracleDataAdapter(query3, con);

                    adapt.Fill(dt);

                    MessageBox.Show("Shifted", "!!");


                }
                else
                {
                    MessageBox.Show("Cannot Approve Due to Capacity", "Error");
                
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DeclineShift_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                    "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
                string query = "delete from shift where s_id = '" + ShiftSTDID_TextBox.Text + "'" ;

                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                adapt.Fill(dt);

                MessageBox.Show("Declined","Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
