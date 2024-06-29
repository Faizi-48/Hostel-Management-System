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
    public partial class ManageVisitor : Form
    {
        public ManageVisitor()
        {
            InitializeComponent();
        }

        private void ManageVisitor_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageVisitor_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void ViewAllVisitors_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewVisitors adminviewvisitor = new AdminViewVisitors();
            adminviewvisitor.Show();
        }

        private void AddVisitor_Button_Click(object sender, EventArgs e)
        {
            try
            {

                string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection(connect);
                con.Open();
                string query = "Insert into visitor Values ('"+ VisitorCNIC_TextBox .Text+ "','"+ VisitorName_TextBox.Text + "','"+ VisitorSTDID_TextBox.Text+ "',to_date(sysdate,'dd/mm/yyyy'),'"+ VisitorOutTime_TextBox .Text+ "','"+ VisitorInTime_TextBox .Text+ "')";
                DataTable dt = new DataTable();

                OracleDataAdapter adapt = new OracleDataAdapter(query, con);

                adapt.Fill(dt);
                MessageBox.Show("Welcome Visitor", "Welcome");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
