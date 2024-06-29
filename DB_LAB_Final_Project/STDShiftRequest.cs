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
    public partial class STDShiftRequest : Form
    {
        public STDShiftRequest()
        {
            InitializeComponent();
        }

        private void STDShiftAdd_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STDShiftRequest_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
            this.Other_Reason_TextBox.Visible= false;
           
        }

        private void Shift_Reason_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (Shift_Reason_Combobox.Text == "Other")
            {
                this.Other_Reason_TextBox.Visible = true;
            }
            else
            {
                this.Other_Reason_TextBox.Visible = false;
            }
        }

        private void STD_ADDShiftSendRequest_Button_Click(object sender, EventArgs e)
        {
            string room;
            string connect = "User Id =SYSTEM;Password =system;Data Source=localhost:1521/XE;Pooling=false;";
            OracleConnection con = new OracleConnection(connect);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "Select room_no from student where S_ID='" + LoginSTD.std_id + "'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr = cmd.ExecuteReader();
            dr.Read();
            room = dr.GetString(0);
            con.Close();
            try
            {
                con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();

                OracleCommand count = new OracleCommand();
                count.CommandText = "Select count(*) from shift where S_ID='" + LoginSTD.std_id + "'";
                count.Connection = con;
                count.CommandType = CommandType.Text;
                OracleDataReader gym = count.ExecuteReader();
                gym.Read();
                int gymcount;
                Int32.TryParse(gym.GetString(0), out gymcount);
                if (gymcount != 0)
                {
                    MessageBox.Show("Already Applied");
                }
                else
                {
                    if (Shift_Reason_Combobox.Text != "Other")
                    {
                        string query;
                        query = " insert into shift (s_id,c_roomno,s_roomno,reason)values('" + LoginSTD.std_id + "'," + room + "," + Shift_ShiftRoom_TextBox.Text + ",'" + Shift_Reason_Combobox.Text + "')";
                        OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                        DataTable dtable = new DataTable();
                        oracleDataAdapter.Fill(dtable);

                        MessageBox.Show("Applied");
                        
                    }
                    else
                    {
                        string query;
                        query = " insert into shift (s_id,c_roomno,s_roomno,reason)values('" + LoginSTD.std_id + "'," + room + "," + Shift_ShiftRoom_TextBox.Text + ",'" + Other_Reason_TextBox.Text + "')";
                        OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                        DataTable dtable = new DataTable();
                        oracleDataAdapter.Fill(dtable);

                        MessageBox.Show("Applied");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, STDDashboard.std_room);
            }
        }
    }
}
