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
    public partial class STDPersonalInfo : Form
    {
        public static string cnic;
        public STDPersonalInfo()
        {
            InitializeComponent();
            try
            {
                //Getting Data to Send to PersonalInfo Form
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select room_no from student where S_ID='" + LoginSTD.std_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                STDRoom_LabelText.Text = dr.GetString(0);



                //CNIC
                cmd.CommandText = "Select CNIC from student_details where S_ID='" + LoginSTD.std_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                STDCNIC_LabelText.Text = dr.GetString(0);
                cnic = STDCNIC_LabelText.Text;


                //Phone
                cmd.CommandText = "Select phone_no from student_details where S_ID='" + LoginSTD.std_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                STDPhoneNo_LabelText.Text = dr.GetString(0);

                //Semester
                cmd.CommandText = "Select semester from student where S_ID='" + LoginSTD.std_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                STDSemester_LabelText.Text = dr["Semester"].ToString();

                //Guardian
                cmd.CommandText = "Select gurdian_name from student where S_ID='" + LoginSTD.std_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                STDGuardian_LabelText.Text = dr.GetString(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            STDName_LabelText.Text = LoginSTD.std_name;
            STDID_LabelText.Text = LoginSTD.std_id;

        }

        private void STDPersonalInfo_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STDPersonalInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }
    }
}
