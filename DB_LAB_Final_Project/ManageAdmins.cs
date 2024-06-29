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
    public partial class ManageAdmins : Form
    {
        public ManageAdmins()
        {
            InitializeComponent();
        }

        private void DeleteAdmin_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginADMIN.admin_id != DeleteAdmin_TextBox.Text)
                {
                    if (DeleteAdmin_TextBox.Text == "")
                    {
                        MessageBox.Show("Empty Box");
                    }
                    else
                    {
                        string connect = "User Id =SYSTEM;Password =system;" +
                                   "Data Source=localhost:1521/XE;Pooling=false;";
                        OracleConnection con = new OracleConnection();
                        con.ConnectionString = connect;
                        con.Open();
                        DataTable dt = new DataTable();

                        OracleDataAdapter adapt = new OracleDataAdapter("delete from admin_details where a_id='" + DeleteAdmin_TextBox.Text + "'", con);

                        adapt.Fill(dt);
                        DataTable dtd = new DataTable();

                        OracleDataAdapter adaptd = new OracleDataAdapter("delete from admin where a_id='" + DeleteAdmin_TextBox.Text + "'", con);

                        adaptd.Fill(dtd);
                        MessageBox.Show("Admin Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Delete Yourself","Caution");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ManageAdmins_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void AddAdmin_Button_Click(object sender, EventArgs e)
        {
            AddAdmin addadm = new AddAdmin();
            this.Hide();
            addadm.Show();
        }

        private void ManageAdmin_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewAllAdmins viewadmin = new ViewAllAdmins();
            this.Hide();
            viewadmin.Show();
        }
    }
}
