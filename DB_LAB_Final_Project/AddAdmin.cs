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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void AdminPersonalInfo_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_AddAdmin_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                               "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
                string query = "insert into admin values('" + AddAdminID_TextBox.Text + "','" + AddAdminName_TextBox.Text + "','" + AddAdminPassword_TextBox.Text + "')";
                string query1 = "insert into admin_details values('" + AddAdminID_TextBox.Text + "','" + AddAdminCNIC_TextBox.Text + "'," + AddAdminPhone_TextBox.Text + ")";

                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                adapt.Fill(dt);
                DataTable dtd = new DataTable();

                OracleDataAdapter adaptd = new OracleDataAdapter(query1, con);

                adaptd.Fill(dtd);

                MessageBox.Show("Admin Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void Add_SearchAdmin_Button_Click(object sender, EventArgs e)
        {
            try
            {

                //Password

                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select password from admin where A_ID='" + AddAdminID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddAdminPassword_TextBox.Text = dr.GetString(0);
                con.Close();


                //Name

                con.Open();
                cmd.CommandText = "Select AName from admin where A_ID='" + AddAdminID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddAdminName_TextBox.Text = dr.GetString(0);
                con.Close();

                //CNIC
                con.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "Select CNIC from admin_details where A_ID='" + AddAdminID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
                dr.Read();
                AddAdminCNIC_TextBox.Text = dr.GetString(0);
                con.Close();

                //Phone
                con.Open();
                cmd.CommandText = "Select phone_no from admin_details where A_ID='" + AddAdminID_TextBox.Text + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                AddAdminPhone_TextBox.Text = dr.GetString(0);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Add_UpdateAdmin_Button_Click(object sender, EventArgs e)
        {
            try
            {

                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                string query= "UPDATE admin SET a_id = '"+AddAdminID_TextBox.Text+"', Aname = '"+AddAdminName_TextBox.Text+"',password='"+AddAdminPassword_TextBox.Text+"' WHERE A_id='"+AddAdminID_TextBox.Text+"'";
                string query1 = "UPDATE admin_details  SET a_id = '" + AddAdminID_TextBox.Text + "', CNIC = '" + AddAdminCNIC_TextBox.Text + "',phone_no = '" + AddAdminPhone_TextBox.Text + "' WHERE A_id = '" + AddAdminID_TextBox.Text + "'";
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
    }
}
