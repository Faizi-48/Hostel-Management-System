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
    public partial class AdminDashboard : Form
    {
        public static string admin_id = LoginADMIN.admin_id;
        public static string admin_name = LoginADMIN.admin_name;
        public static string admin_cnic;
        public static string admin_phone;
        public AdminDashboard()
        {
            InitializeComponent();
            ADMIN_Welcome.Text = "WELCOME " + LoginADMIN.admin_name;
        }

        private void ADMIN_Logout_Button_Click(object sender, EventArgs e)
        {
            LoginADMIN Login = new LoginADMIN();
            this.Hide();
            Login.Show();
        }

        private void Exit_Admin_Dashboard_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean WelcomeAdminLabel_Visible = true;
        private void WelcomeAdmin_Timer_Tick(object sender, EventArgs e)
        {
            if(WelcomeAdminLabel_Visible==true)
            {
                ADMIN_Welcome.Visible = true;
                WelcomeAdminLabel_Visible = false;
            }
            else
            {
                ADMIN_Welcome.Visible = false;
                WelcomeAdminLabel_Visible = true;

            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            WelcomeAdmin_Timer.Enabled = true;
            WelcomeAdmin_Timer.Start();
        }

        private void Admin_PersonalInfo_Button_Click(object sender, EventArgs e)
        {
            Admin_PersonalInfo AdminPersonal = new Admin_PersonalInfo();
            AdminPersonal.Show();
        }

        private void ManageHostel_Button_Click(object sender, EventArgs e)
        {
            ManageHostels MngHstl = new ManageHostels();
            MngHstl.Show();
        }

        private void ManageAdmin_Button_Click(object sender, EventArgs e)
        {
            ManageAdmins mngadmin = new ManageAdmins();
            mngadmin.Show();
        }

        private void ManageSTD_Button_Click(object sender, EventArgs e)
        {
            ManageStudents mngstd = new ManageStudents();
            mngstd.Show();
        }

        private void ManageBills_Button_Click(object sender, EventArgs e)
        {
            ManageBills mngbill = new ManageBills();
            mngbill.Show();
        }

        private void MessAttendance_Button_Click(object sender, EventArgs e)
        {
            AddMessAttendance addmess = new AddMessAttendance();
            addmess.Show();
            
        }

        private void RoomShift_Button_Click(object sender, EventArgs e)
        {
            ManageRoomShift roomshft = new ManageRoomShift();
            roomshft.Show();
        }

        private void Visitor_Button_Click(object sender, EventArgs e)
        {
            ManageVisitor mngvisitor = new ManageVisitor();
            mngvisitor.Show();
        }

        private void ADMIN_Welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
