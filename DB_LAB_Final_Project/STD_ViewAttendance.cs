﻿using System;
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
    public partial class STD_ViewAttendance : Form
    {
        public STD_ViewAttendance()
        {
            InitializeComponent();
        }

        private void STDViewAttendance_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STD_ViewAttendance_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void STD_ViewAttendance_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "User Id =SYSTEM;Password =system;" +
                            "Data Source=localhost:1521/XE;Pooling=false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connect;
                con.Open();
                DataTable dt = new DataTable();


                OracleDataAdapter adapt = new OracleDataAdapter("select * from attendance where S_id='" + LoginSTD.std_id + "'", con);

                adapt.Fill(dt);
                STDAttendanceView_GridBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
