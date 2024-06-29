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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Add_AddStudent_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_AddSTD_Button_Click(object sender, EventArgs e)
        {

            try
            {
                int hostel;
                if(SelectHostel_AddSTD_ComboBox.Text=="Boys")
                {
                    hostel = 1;
                }
                else
                {
                    hostel = 2;
                }
                int capacity;
                int strength;

                //Getting Strength
                string stringstrength;
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select room_strength from room where room_no=" + AddSTDRoomNo_TextBox.Text + "and hostel_id = " + hostel;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringstrength = dr.GetString(0);
                strength = Int32.Parse(stringstrength);


                //Getting Capacity
                string stringcapacity;
                cmd = new OracleCommand();
                cmd.CommandText = "Select room_capacity from room where room_no=" + AddSTDRoomNo_TextBox.Text+"and hostel_id = " + hostel;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                stringcapacity = dr.GetString(0);
                capacity = Int32.Parse(stringcapacity);

                if (capacity > strength)
                {
                    con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();
                    string query = "insert into student values('" + AddSTDID_TextBox.Text + "','" + AddSTDName_TextBox.Text + "','" + AddSTDGuardian_TextBox.Text + "','"+ AddSTDPassword_TextBox .Text+ "',"+ AddSTDSemester_TextBox.Text + ","+ AddSTDRoomNo_TextBox.Text + ","+ hostel + ")";
                    string query1 = "insert into student_details values('" + AddSTDID_TextBox.Text + "','" + AddSTDCNIC_TextBox.Text + "'," + AddSTDPhone_TextBox.Text + ")";

                    strength++;

                    string query3 = "update room set room_strength="+strength+ "where room_no=" + AddSTDRoomNo_TextBox.Text + "and hostel_id = " + hostel;

                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                    adapt.Fill(dt);
                    DataTable dtd = new DataTable();

                    OracleDataAdapter adaptd = new OracleDataAdapter(query1, con);

                    adaptd.Fill(dtd);


                    DataTable dt3 = new DataTable();

                    OracleDataAdapter adapt3 = new OracleDataAdapter(query3, con);

                    adapt3.Fill(dt3);

                    MessageBox.Show("Student Added","Added!!");

                }
                else
                {

                    MessageBox.Show("Cannot Add More","Error" ) ;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }



        }

        private void Add_UpdateSTD_Button_Click(object sender, EventArgs e)
        {


            try
            {

                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                string query = "UPDATE student SET S_id = '" + AddSTDID_TextBox.Text + "', S_name = '" + AddSTDName_TextBox.Text + "',gurdian_name='" + AddSTDGuardian_TextBox.Text + "',S_password='" +AddSTDPassword_TextBox.Text+ "',Semester=" +AddSTDSemester_TextBox.Text+ " WHERE S_id='" + AddSTDID_TextBox.Text + "'";
                string query1 = "UPDATE student_details  SET s_id = '" + AddSTDID_TextBox.Text + "', CNIC = '" + AddSTDCNIC_TextBox.Text + "',phone_no = '" + AddSTDPhone_TextBox.Text + "' WHERE S_id = '" + AddSTDID_TextBox.Text + "'";
                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                adapt.Fill(dt);
                DataTable dtd = new DataTable();

                OracleDataAdapter adaptd = new OracleDataAdapter(query, con);

                adaptd.Fill(dtd);
                MessageBox.Show("Updated!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void Add_SearchSTD_Button_Click(object sender, EventArgs e)
        {
            try
            {

                //Password

                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select s_password from student where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDPassword_TextBox.Text = dr.GetString(0);
                con.Close();


                //Name

                con.Open();
                cmd.CommandText = "Select S_Name from student where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDName_TextBox.Text = dr.GetString(0);
                con.Close();

                //Guardian

                con.Open();
                cmd.CommandText = "Select Gurdian_Name from student where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDGuardian_TextBox.Text = dr.GetString(0);
                con.Close();

                //Semester
                con.Open();
                cmd.CommandText = "Select Semester from student where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDSemester_TextBox.Text = dr.GetString(0);
                con.Close();

                //RoomNO
                con.Open();
                cmd.CommandText = "Select Room_no from student where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDRoomNo_TextBox.Text = dr.GetString(0);
                con.Close();

                //CNIC
                con.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "Select CNIC from student_details where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDCNIC_TextBox.Text = dr.GetString(0);
                con.Close();

                //Phone
                con.Open();
                cmd.CommandText = "Select phone_no from student_details where S_ID='" + AddSTDID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                AddSTDPhone_TextBox.Text = dr.GetString(0);
                con.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
