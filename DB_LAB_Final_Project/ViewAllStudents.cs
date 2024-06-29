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
    public partial class ViewAllStudents : Form
    {
        public ViewAllStudents()
        {
            InitializeComponent();
        }

        private void ViewStudent_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550,240);
        }

        private void View_ViewAllStudents_Button_Click(object sender, EventArgs e)
        {
            string connect = "User Id =SYSTEM;Password =system;" +
               "Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connect;
            con.Open();
            string query = "select * from student";

            DataTable dt = new DataTable();

            OracleDataAdapter adapt = new OracleDataAdapter(query, con);

            adapt.Fill(dt);
            StudentView_GridBox.DataSource = dt;
        }
    }
}
