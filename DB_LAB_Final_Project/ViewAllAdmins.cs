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
    public partial class ViewAllAdmins : Form
    {
        public ViewAllAdmins()
        {
            InitializeComponent();
        }

        private void ViewAdmins_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllAdmins_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550,240);
        }

        private void ViewALLAdmins_view_Button_Click(object sender, EventArgs e)
        {
            string connect = "User Id =SYSTEM;Password =system;" +
                           "Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connect;
            con.Open();
            string query = "select * from admin_details";

            DataTable dt = new DataTable();

            OracleDataAdapter adapt = new OracleDataAdapter(query, con);

            adapt.Fill(dt);
            AdminView_GridBox.DataSource=dt;
        }
    }
}
