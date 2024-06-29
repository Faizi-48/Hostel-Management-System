namespace DB_LAB_Final_Project
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.Admin_NavigatorBar_Label = new System.Windows.Forms.Label();
            this.ADMIN_Welcome = new System.Windows.Forms.Label();
            this.Exit_Admin_Dashboard_Button = new Guna.UI2.WinForms.Guna2Button();
            this.WelcomeAdmin_Timer = new System.Windows.Forms.Timer(this.components);
            this.Dashboard_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ADMIN_Logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Visitor_Button = new Guna.UI2.WinForms.Guna2Button();
            this.RoomShift_Button = new Guna.UI2.WinForms.Guna2Button();
            this.MessAttendance_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ManageBills_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ManageSTD_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ManageAdmin_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ManageHostel_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Admin_PersonalInfo_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Admin_NavigatorBar_Label
            // 
            this.Admin_NavigatorBar_Label.AutoSize = true;
            this.Admin_NavigatorBar_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Admin_NavigatorBar_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_NavigatorBar_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Admin_NavigatorBar_Label.Location = new System.Drawing.Point(24, 18);
            this.Admin_NavigatorBar_Label.Name = "Admin_NavigatorBar_Label";
            this.Admin_NavigatorBar_Label.Size = new System.Drawing.Size(227, 38);
            this.Admin_NavigatorBar_Label.TabIndex = 1;
            this.Admin_NavigatorBar_Label.Text = "Navigation Bar";
            // 
            // ADMIN_Welcome
            // 
            this.ADMIN_Welcome.AutoSize = true;
            this.ADMIN_Welcome.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ADMIN_Welcome.Location = new System.Drawing.Point(426, 9);
            this.ADMIN_Welcome.Name = "ADMIN_Welcome";
            this.ADMIN_Welcome.Size = new System.Drawing.Size(550, 62);
            this.ADMIN_Welcome.TabIndex = 2;
            this.ADMIN_Welcome.Text = "WELCOME ADMIN";
            this.ADMIN_Welcome.Click += new System.EventHandler(this.ADMIN_Welcome_Click);
            // 
            // Exit_Admin_Dashboard_Button
            // 
            this.Exit_Admin_Dashboard_Button.BorderColor = System.Drawing.Color.White;
            this.Exit_Admin_Dashboard_Button.BorderRadius = 19;
            this.Exit_Admin_Dashboard_Button.BorderThickness = 1;
            this.Exit_Admin_Dashboard_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Exit_Admin_Dashboard_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.Exit_Admin_Dashboard_Button.CheckedState.Parent = this.Exit_Admin_Dashboard_Button;
            this.Exit_Admin_Dashboard_Button.CustomImages.Parent = this.Exit_Admin_Dashboard_Button;
            this.Exit_Admin_Dashboard_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.Exit_Admin_Dashboard_Button.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.Exit_Admin_Dashboard_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Exit_Admin_Dashboard_Button.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.Exit_Admin_Dashboard_Button.HoverState.Parent = this.Exit_Admin_Dashboard_Button;
            this.Exit_Admin_Dashboard_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Exit_Admin_Dashboard_Button.Location = new System.Drawing.Point(1282, 18);
            this.Exit_Admin_Dashboard_Button.Name = "Exit_Admin_Dashboard_Button";
            this.Exit_Admin_Dashboard_Button.ShadowDecoration.Parent = this.Exit_Admin_Dashboard_Button;
            this.Exit_Admin_Dashboard_Button.Size = new System.Drawing.Size(46, 45);
            this.Exit_Admin_Dashboard_Button.TabIndex = 12;
            this.Exit_Admin_Dashboard_Button.Text = "X";
            this.Exit_Admin_Dashboard_Button.Click += new System.EventHandler(this.Exit_Admin_Dashboard_Button_Click);
            // 
            // WelcomeAdmin_Timer
            // 
            this.WelcomeAdmin_Timer.Enabled = true;
            this.WelcomeAdmin_Timer.Interval = 1000;
            this.WelcomeAdmin_Timer.Tick += new System.EventHandler(this.WelcomeAdmin_Timer_Tick);
            // 
            // Dashboard_Elipse
            // 
            this.Dashboard_Elipse.BorderRadius = 40;
            this.Dashboard_Elipse.TargetControl = this;
            // 
            // ADMIN_Logout_Button
            // 
            this.ADMIN_Logout_Button.BorderColor = System.Drawing.Color.White;
            this.ADMIN_Logout_Button.BorderRadius = 19;
            this.ADMIN_Logout_Button.BorderThickness = 1;
            this.ADMIN_Logout_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ADMIN_Logout_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ADMIN_Logout_Button.CheckedState.Parent = this.ADMIN_Logout_Button;
            this.ADMIN_Logout_Button.CustomImages.Parent = this.ADMIN_Logout_Button;
            this.ADMIN_Logout_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ADMIN_Logout_Button.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.ADMIN_Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ADMIN_Logout_Button.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.ADMIN_Logout_Button.HoverState.Parent = this.ADMIN_Logout_Button;
            this.ADMIN_Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("ADMIN_Logout_Button.Image")));
            this.ADMIN_Logout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.ADMIN_Logout_Button.Location = new System.Drawing.Point(1087, 18);
            this.ADMIN_Logout_Button.Name = "ADMIN_Logout_Button";
            this.ADMIN_Logout_Button.ShadowDecoration.Parent = this.ADMIN_Logout_Button;
            this.ADMIN_Logout_Button.Size = new System.Drawing.Size(165, 45);
            this.ADMIN_Logout_Button.TabIndex = 11;
            this.ADMIN_Logout_Button.Text = "Log Out";
            this.ADMIN_Logout_Button.Click += new System.EventHandler(this.ADMIN_Logout_Button_Click);
            // 
            // Visitor_Button
            // 
            this.Visitor_Button.BorderRadius = 19;
            this.Visitor_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Visitor_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Visitor_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.Visitor_Button.CheckedState.Parent = this.Visitor_Button;
            this.Visitor_Button.CustomImages.Parent = this.Visitor_Button;
            this.Visitor_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.Visitor_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Visitor_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Visitor_Button.HoverState.Parent = this.Visitor_Button;
            this.Visitor_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._16981;
            this.Visitor_Button.Location = new System.Drawing.Point(24, 632);
            this.Visitor_Button.Name = "Visitor_Button";
            this.Visitor_Button.ShadowDecoration.Parent = this.Visitor_Button;
            this.Visitor_Button.Size = new System.Drawing.Size(215, 45);
            this.Visitor_Button.TabIndex = 10;
            this.Visitor_Button.Text = "Visitor";
            this.Visitor_Button.Click += new System.EventHandler(this.Visitor_Button_Click);
            // 
            // RoomShift_Button
            // 
            this.RoomShift_Button.BorderRadius = 19;
            this.RoomShift_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RoomShift_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.RoomShift_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.RoomShift_Button.CheckedState.Parent = this.RoomShift_Button;
            this.RoomShift_Button.CustomImages.Parent = this.RoomShift_Button;
            this.RoomShift_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.RoomShift_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomShift_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.RoomShift_Button.HoverState.Parent = this.RoomShift_Button;
            this.RoomShift_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._2911176;
            this.RoomShift_Button.Location = new System.Drawing.Point(24, 552);
            this.RoomShift_Button.Name = "RoomShift_Button";
            this.RoomShift_Button.ShadowDecoration.Parent = this.RoomShift_Button;
            this.RoomShift_Button.Size = new System.Drawing.Size(215, 45);
            this.RoomShift_Button.TabIndex = 9;
            this.RoomShift_Button.Text = "Room Shift";
            this.RoomShift_Button.Click += new System.EventHandler(this.RoomShift_Button_Click);
            // 
            // MessAttendance_Button
            // 
            this.MessAttendance_Button.BorderRadius = 19;
            this.MessAttendance_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MessAttendance_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.MessAttendance_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.MessAttendance_Button.CheckedState.Parent = this.MessAttendance_Button;
            this.MessAttendance_Button.CustomImages.Parent = this.MessAttendance_Button;
            this.MessAttendance_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.MessAttendance_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessAttendance_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.MessAttendance_Button.HoverState.Parent = this.MessAttendance_Button;
            this.MessAttendance_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._66118951;
            this.MessAttendance_Button.Location = new System.Drawing.Point(24, 468);
            this.MessAttendance_Button.Name = "MessAttendance_Button";
            this.MessAttendance_Button.ShadowDecoration.Parent = this.MessAttendance_Button;
            this.MessAttendance_Button.Size = new System.Drawing.Size(215, 45);
            this.MessAttendance_Button.TabIndex = 8;
            this.MessAttendance_Button.Text = "Mess Attendance";
            this.MessAttendance_Button.Click += new System.EventHandler(this.MessAttendance_Button_Click);
            // 
            // ManageBills_Button
            // 
            this.ManageBills_Button.BorderRadius = 19;
            this.ManageBills_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ManageBills_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ManageBills_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ManageBills_Button.CheckedState.Parent = this.ManageBills_Button;
            this.ManageBills_Button.CustomImages.Parent = this.ManageBills_Button;
            this.ManageBills_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ManageBills_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageBills_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageBills_Button.HoverState.Parent = this.ManageBills_Button;
            this.ManageBills_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._2152696;
            this.ManageBills_Button.Location = new System.Drawing.Point(24, 391);
            this.ManageBills_Button.Name = "ManageBills_Button";
            this.ManageBills_Button.ShadowDecoration.Parent = this.ManageBills_Button;
            this.ManageBills_Button.Size = new System.Drawing.Size(215, 45);
            this.ManageBills_Button.TabIndex = 7;
            this.ManageBills_Button.Text = "Manage Bills";
            this.ManageBills_Button.Click += new System.EventHandler(this.ManageBills_Button_Click);
            // 
            // ManageSTD_Button
            // 
            this.ManageSTD_Button.BorderRadius = 19;
            this.ManageSTD_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ManageSTD_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ManageSTD_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ManageSTD_Button.CheckedState.Parent = this.ManageSTD_Button;
            this.ManageSTD_Button.CustomImages.Parent = this.ManageSTD_Button;
            this.ManageSTD_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ManageSTD_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageSTD_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageSTD_Button.HoverState.Parent = this.ManageSTD_Button;
            this.ManageSTD_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._3135755;
            this.ManageSTD_Button.Location = new System.Drawing.Point(24, 320);
            this.ManageSTD_Button.Name = "ManageSTD_Button";
            this.ManageSTD_Button.ShadowDecoration.Parent = this.ManageSTD_Button;
            this.ManageSTD_Button.Size = new System.Drawing.Size(215, 45);
            this.ManageSTD_Button.TabIndex = 6;
            this.ManageSTD_Button.Text = "Manage Students";
            this.ManageSTD_Button.Click += new System.EventHandler(this.ManageSTD_Button_Click);
            // 
            // ManageAdmin_Button
            // 
            this.ManageAdmin_Button.BorderRadius = 19;
            this.ManageAdmin_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ManageAdmin_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ManageAdmin_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ManageAdmin_Button.CheckedState.Parent = this.ManageAdmin_Button;
            this.ManageAdmin_Button.CustomImages.Parent = this.ManageAdmin_Button;
            this.ManageAdmin_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ManageAdmin_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageAdmin_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageAdmin_Button.HoverState.Parent = this.ManageAdmin_Button;
            this.ManageAdmin_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._3934107;
            this.ManageAdmin_Button.Location = new System.Drawing.Point(24, 237);
            this.ManageAdmin_Button.Name = "ManageAdmin_Button";
            this.ManageAdmin_Button.ShadowDecoration.Parent = this.ManageAdmin_Button;
            this.ManageAdmin_Button.Size = new System.Drawing.Size(215, 45);
            this.ManageAdmin_Button.TabIndex = 5;
            this.ManageAdmin_Button.Text = "Manage Admins";
            this.ManageAdmin_Button.Click += new System.EventHandler(this.ManageAdmin_Button_Click);
            // 
            // ManageHostel_Button
            // 
            this.ManageHostel_Button.BorderRadius = 19;
            this.ManageHostel_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ManageHostel_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ManageHostel_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ManageHostel_Button.CheckedState.Parent = this.ManageHostel_Button;
            this.ManageHostel_Button.CustomImages.Parent = this.ManageHostel_Button;
            this.ManageHostel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ManageHostel_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageHostel_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageHostel_Button.HoverState.Parent = this.ManageHostel_Button;
            this.ManageHostel_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._233433;
            this.ManageHostel_Button.Location = new System.Drawing.Point(24, 164);
            this.ManageHostel_Button.Name = "ManageHostel_Button";
            this.ManageHostel_Button.ShadowDecoration.Parent = this.ManageHostel_Button;
            this.ManageHostel_Button.Size = new System.Drawing.Size(215, 45);
            this.ManageHostel_Button.TabIndex = 4;
            this.ManageHostel_Button.Text = "View Hostels Rooms";
            this.ManageHostel_Button.Click += new System.EventHandler(this.ManageHostel_Button_Click);
            // 
            // Admin_PersonalInfo_Button
            // 
            this.Admin_PersonalInfo_Button.BorderRadius = 19;
            this.Admin_PersonalInfo_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Admin_PersonalInfo_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Admin_PersonalInfo_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.Admin_PersonalInfo_Button.CheckedState.Parent = this.Admin_PersonalInfo_Button;
            this.Admin_PersonalInfo_Button.CustomImages.Parent = this.Admin_PersonalInfo_Button;
            this.Admin_PersonalInfo_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.Admin_PersonalInfo_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Admin_PersonalInfo_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Admin_PersonalInfo_Button.HoverState.Parent = this.Admin_PersonalInfo_Button;
            this.Admin_PersonalInfo_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._1077114;
            this.Admin_PersonalInfo_Button.Location = new System.Drawing.Point(24, 94);
            this.Admin_PersonalInfo_Button.Name = "Admin_PersonalInfo_Button";
            this.Admin_PersonalInfo_Button.ShadowDecoration.Parent = this.Admin_PersonalInfo_Button;
            this.Admin_PersonalInfo_Button.Size = new System.Drawing.Size(215, 45);
            this.Admin_PersonalInfo_Button.TabIndex = 3;
            this.Admin_PersonalInfo_Button.Text = "Personal Info";
            this.Admin_PersonalInfo_Button.Click += new System.EventHandler(this.Admin_PersonalInfo_Button_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1368, 721);
            this.Controls.Add(this.Exit_Admin_Dashboard_Button);
            this.Controls.Add(this.ADMIN_Logout_Button);
            this.Controls.Add(this.Visitor_Button);
            this.Controls.Add(this.RoomShift_Button);
            this.Controls.Add(this.MessAttendance_Button);
            this.Controls.Add(this.ManageBills_Button);
            this.Controls.Add(this.ManageSTD_Button);
            this.Controls.Add(this.ManageAdmin_Button);
            this.Controls.Add(this.ManageHostel_Button);
            this.Controls.Add(this.Admin_PersonalInfo_Button);
            this.Controls.Add(this.ADMIN_Welcome);
            this.Controls.Add(this.Admin_NavigatorBar_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Admin_NavigatorBar_Label;
        private System.Windows.Forms.Label ADMIN_Welcome;
        private Guna.UI2.WinForms.Guna2Button Admin_PersonalInfo_Button;
        private Guna.UI2.WinForms.Guna2Button ManageHostel_Button;
        private Guna.UI2.WinForms.Guna2Button ManageAdmin_Button;
        private Guna.UI2.WinForms.Guna2Button ManageSTD_Button;
        private Guna.UI2.WinForms.Guna2Button ManageBills_Button;
        private Guna.UI2.WinForms.Guna2Button MessAttendance_Button;
        private Guna.UI2.WinForms.Guna2Button RoomShift_Button;
        private Guna.UI2.WinForms.Guna2Button Visitor_Button;
        private Guna.UI2.WinForms.Guna2Button ADMIN_Logout_Button;
        private Guna.UI2.WinForms.Guna2Button Exit_Admin_Dashboard_Button;
        private System.Windows.Forms.Timer WelcomeAdmin_Timer;
        private Guna.UI2.WinForms.Guna2Elipse Dashboard_Elipse;
    }
}