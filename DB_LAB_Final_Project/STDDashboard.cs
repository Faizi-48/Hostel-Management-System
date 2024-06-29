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
    public partial class STDDashboard : Form
    {
        public static string std_id = LoginSTD.std_id;
        public static string std_name = LoginSTD.std_name;
        public static string std_room;
        public static string std_cnic;
        public static string std_phone;
        public static string std_guardian;
        public static string std_semester;
        public STDDashboard()
        {
           
            InitializeComponent();
            //Printing Name on Dashboard
            STD_Welcome.Text = "Welcome " + LoginSTD.std_name;
           
        }
        Boolean WelcomeSTDLabel_Visible = true;
        private void STDWelcome_Timer_Tick(object sender, EventArgs e)
        {
            if (WelcomeSTDLabel_Visible == true)
            {
                STD_Welcome.Visible = true;
                WelcomeSTDLabel_Visible = false;
            }
            else
            {
                STD_Welcome.Visible = false;
                WelcomeSTDLabel_Visible = true;

            }
        }

        private void STD_Logout_Button_Click(object sender, EventArgs e)
        {
            LoginSTD Loginstd = new LoginSTD();
            this.Hide();
            Loginstd.Show();
        }

        private void Exit_STD_Dashboard_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void STD_PersonalInfo_Button_Click(object sender, EventArgs e)
        {

           
             
           

            STDPersonalInfo stdpersonal = new STDPersonalInfo();
            stdpersonal.Show();
        }

        private void STD_ViewBills_Button_Click(object sender, EventArgs e)
        {
            STDViewBills stdbill = new STDViewBills();
            stdbill.Show();
        }

        private void STDViewAttendance_Button_Click(object sender, EventArgs e)
        {
            STD_ViewAttendance viewattendance = new STD_ViewAttendance();
            viewattendance.Show();
        }

        private void STDViewVisitors_Button_Click(object sender, EventArgs e)
        {
            STDViewVisitors stdvisitor = new STDViewVisitors();
            stdvisitor.Show();
        }

        private void STDRoomShift_Button_Click(object sender, EventArgs e)
        {
            STDShiftRequest roomshift = new STDShiftRequest();
            roomshift.Show();
        }

        private void STD_GoOut_Button_Click(object sender, EventArgs e)
        {
            STD_GOOUT stdout = new STD_GOOUT();
            stdout.Show();
        }

        private void STD_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void STDDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
