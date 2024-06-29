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
    public partial class LoginSTD : Form
    {
        public static string std_name;
        public static string std_id;
        public LoginSTD()
        {
            InitializeComponent();
        }

        private void LoginSTD_Load(object sender, EventArgs e)
        {

        }

        private void ADMINLogin_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginADMIN admin = new LoginADMIN();
            admin.Show();
        }

        private void STD_SignIn_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting Name to Print on Dashboard
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand username = new OracleCommand();
                username.CommandText = "Select s_name from student where S_ID='" + STD_Username_TextBox.Text + "'";
                username.Connection = con;
                username.CommandType = CommandType.Text;
                OracleDataReader dr = username.ExecuteReader();
                dr.Read();
                std_name = dr.GetString(0);

                //Getting Password to Check
                OracleCommand password = new OracleCommand();
                password.CommandText = "Select s_password from student where S_ID='" + STD_Username_TextBox.Text + "'";
                password.Connection = con;
                password.CommandType = CommandType.Text;
                OracleDataReader pdr = password.ExecuteReader();
                pdr.Read();
                string stdpass = pdr.GetString(0);
                std_id = STD_Username_TextBox.Text;
                if (STD_Password_TextBox.Text == stdpass)
                {
                    //Calling Dashboard
                    STDDashboard stddashboard = new STDDashboard();
                    this.Hide();
                    stddashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                    STD_Password_TextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }
    }
}
