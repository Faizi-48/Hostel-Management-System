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
    public partial class STD_GOOUT : Form
    {
        public STD_GOOUT()
        {
            InitializeComponent();
        }

        private void STDGOOUT_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void STDGoOut_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STD_GoOutSubmit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                                   "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                string query = "insert into attendance values ('"+LoginSTD.std_id+"',to_date(sysdate,'dd/mm/yyyy'),'"+ STD_GoOut_OutTime_TextBox.Text + "','"+ STD_GoOut_InTime_TextBox.Text + "','"+ Reason_ComboBox.Text + "')";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                DataTable dtable = new DataTable();
                oracleDataAdapter.Fill(dtable);

                MessageBox.Show("You Can Go Out","Thank You");

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
