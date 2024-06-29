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
    public partial class Admin_PersonalInfo : Form
    {
        public Admin_PersonalInfo()
        {
            try
            {
                InitializeComponent();

                //CNIC
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select CNIC from admin_details where A_ID='" + LoginADMIN.admin_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AdminCNIC_LabelText.Text = dr.GetString(0);


                //Phone
                cmd.CommandText = "Select phone_no from admin_details where A_ID='" + LoginADMIN.admin_id + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                AdminPhone_LabelText.Text = dr.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
            AdminID_LabelText.Text = AdminDashboard.admin_id;
            AdminName_LabelText.Text = AdminDashboard.admin_name;
        }

        private void Admin_PersonalInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550,240);
        }

        private void AdminPersonalInfo_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPersonal_Info_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
