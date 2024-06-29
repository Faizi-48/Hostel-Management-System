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
    public partial class LoginADMIN : Form
    {
        public static string admin_name;
        public static string admin_id;
        public LoginADMIN()
        {
            InitializeComponent();
        }

        private void STDLogin_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginSTD std = new LoginSTD();
            std.Show();
        }

        private void ADMIN_SignIn_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting Name to Print on Dashboard
                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand username = new OracleCommand();
                username.CommandText = "Select Aname from admin where A_ID='" + ADMIN_Username_TextBox.Text + "'";
                username.Connection = con;
                username.CommandType = CommandType.Text;
                OracleDataReader dr = username.ExecuteReader();
                dr.Read();
                admin_name = dr.GetString(0);

                //Getting Password to Check
                OracleCommand password = new OracleCommand();
                password.CommandText = "Select password from admin where A_ID='" + ADMIN_Username_TextBox.Text + "'";
                password.Connection = con;
                password.CommandType = CommandType.Text;
                OracleDataReader pdr = password.ExecuteReader();
                pdr.Read();
                string adminpass = pdr.GetString(0);
                admin_id = ADMIN_Username_TextBox.Text;
                if (ADMIN_Password_TextBox.Text == adminpass)
                {
                    
                    //Calling Dashboard
                    AdminDashboard admindashboard = new AdminDashboard();
                    this.Hide();
                    admindashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                    ADMIN_Password_TextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LoginADMIN_Load(object sender, EventArgs e)
        {
           
        }
    }
}
