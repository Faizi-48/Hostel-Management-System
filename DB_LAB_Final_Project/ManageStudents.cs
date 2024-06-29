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
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStudent_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteStudent_TextBox.Text == "")
                {
                    MessageBox.Show("Empty Box");
                }
                else
                {
                  
                    //Getting Room
                    string room;
                    string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                    OracleConnection con = new OracleConnection(connect);
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select room_no from student where S_ID='" + DeleteStudent_TextBox.Text + "'";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    room = dr.GetString(0);
                    con.Close();

                    //Decreasing Strength
                    con = new OracleConnection(connect);
                    con.Open();
                    cmd = new OracleCommand();
                    cmd.CommandText = "Select room_no from student where S_ID='" + DeleteStudent_TextBox.Text + "'";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    room = dr.GetString(0);
                    con.Close();

                    

                    con = new OracleConnection();
                    con.ConnectionString = connect;
                    con.Open();

                    cmd = new OracleCommand();
                    cmd.CommandText = "select room_strength from room where room_no = " + room;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    string stringstrength;
                    stringstrength = dr.GetString(0);
                    int strength= Int32.Parse(stringstrength);
                    strength--;


                    //Updating Room Strength
                    DataTable dt1 = new DataTable();

                    OracleDataAdapter adapt1 = new OracleDataAdapter("UPDATE room SET room_strength =" + strength + "where room_no="+room+"", con);

                    adapt1.Fill(dt1);



                    DataTable dt = new DataTable();

                    OracleDataAdapter adapt = new OracleDataAdapter("delete from student_details where S_id='" + DeleteStudent_TextBox.Text + "'", con);

                    adapt.Fill(dt);
                    DataTable dtd = new DataTable();

                    OracleDataAdapter adaptd = new OracleDataAdapter("delete from student where S_id='" + DeleteStudent_TextBox.Text + "'", con);

                    adaptd.Fill(dtd);
                    MessageBox.Show("Student Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            AddStudent addstd = new AddStudent();
            this.Hide();
            addstd.Show();
        }

        private void ViewAllStudents_Button_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewSTD = new ViewAllStudents();
            this.Hide();
            viewSTD.Show();
        }
    }
}
