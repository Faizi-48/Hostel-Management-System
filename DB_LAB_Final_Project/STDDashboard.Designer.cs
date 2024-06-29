namespace DB_LAB_Final_Project
{
    partial class STDDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STDDashboard));
            this.STD_NavigatorBar_Label = new System.Windows.Forms.Label();
            this.STD_Welcome = new System.Windows.Forms.Label();
            this.STD_Dashboard_Elispse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.STDWelcome_Timer = new System.Windows.Forms.Timer(this.components);
            this.Exit_STD_Dashboard_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STD_GoOut_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STD_Logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STDViewVisitors_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STDRoomShift_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STDViewAttendance_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STD_ViewBills_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STD_PersonalInfo_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // STD_NavigatorBar_Label
            // 
            this.STD_NavigatorBar_Label.AutoSize = true;
            this.STD_NavigatorBar_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_NavigatorBar_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STD_NavigatorBar_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD_NavigatorBar_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_NavigatorBar_Label.Location = new System.Drawing.Point(12, 22);
            this.STD_NavigatorBar_Label.Name = "STD_NavigatorBar_Label";
            this.STD_NavigatorBar_Label.Size = new System.Drawing.Size(227, 38);
            this.STD_NavigatorBar_Label.TabIndex = 2;
            this.STD_NavigatorBar_Label.Text = "Navigation Bar";
            // 
            // STD_Welcome
            // 
            this.STD_Welcome.AutoSize = true;
            this.STD_Welcome.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_Welcome.Location = new System.Drawing.Point(443, 22);
            this.STD_Welcome.Name = "STD_Welcome";
            this.STD_Welcome.Size = new System.Drawing.Size(451, 62);
            this.STD_Welcome.TabIndex = 3;
            this.STD_Welcome.Text = "Welcome Student";
            this.STD_Welcome.Click += new System.EventHandler(this.STD_Welcome_Click);
            // 
            // STD_Dashboard_Elispse
            // 
            this.STD_Dashboard_Elispse.BorderRadius = 30;
            this.STD_Dashboard_Elispse.TargetControl = this;
            // 
            // STDWelcome_Timer
            // 
            this.STDWelcome_Timer.Enabled = true;
            this.STDWelcome_Timer.Interval = 1000;
            this.STDWelcome_Timer.Tick += new System.EventHandler(this.STDWelcome_Timer_Tick);
            // 
            // Exit_STD_Dashboard_Button
            // 
            this.Exit_STD_Dashboard_Button.BorderColor = System.Drawing.Color.White;
            this.Exit_STD_Dashboard_Button.BorderRadius = 19;
            this.Exit_STD_Dashboard_Button.BorderThickness = 1;
            this.Exit_STD_Dashboard_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Exit_STD_Dashboard_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.Exit_STD_Dashboard_Button.CheckedState.Parent = this.Exit_STD_Dashboard_Button;
            this.Exit_STD_Dashboard_Button.CustomImages.Parent = this.Exit_STD_Dashboard_Button;
            this.Exit_STD_Dashboard_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.Exit_STD_Dashboard_Button.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.Exit_STD_Dashboard_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.Exit_STD_Dashboard_Button.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.Exit_STD_Dashboard_Button.HoverState.Parent = this.Exit_STD_Dashboard_Button;
            this.Exit_STD_Dashboard_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Exit_STD_Dashboard_Button.Location = new System.Drawing.Point(1266, 22);
            this.Exit_STD_Dashboard_Button.Name = "Exit_STD_Dashboard_Button";
            this.Exit_STD_Dashboard_Button.ShadowDecoration.Parent = this.Exit_STD_Dashboard_Button;
            this.Exit_STD_Dashboard_Button.Size = new System.Drawing.Size(46, 45);
            this.Exit_STD_Dashboard_Button.TabIndex = 13;
            this.Exit_STD_Dashboard_Button.Text = "X";
            this.Exit_STD_Dashboard_Button.Click += new System.EventHandler(this.Exit_STD_Dashboard_Button_Click);
            // 
            // STD_GoOut_Button
            // 
            this.STD_GoOut_Button.BorderRadius = 19;
            this.STD_GoOut_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STD_GoOut_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_GoOut_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_GoOut_Button.CheckedState.Parent = this.STD_GoOut_Button;
            this.STD_GoOut_Button.CustomImages.Parent = this.STD_GoOut_Button;
            this.STD_GoOut_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_GoOut_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STD_GoOut_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_GoOut_Button.HoverState.Parent = this.STD_GoOut_Button;
            this.STD_GoOut_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._2152696;
            this.STD_GoOut_Button.Location = new System.Drawing.Point(21, 419);
            this.STD_GoOut_Button.Name = "STD_GoOut_Button";
            this.STD_GoOut_Button.ShadowDecoration.Parent = this.STD_GoOut_Button;
            this.STD_GoOut_Button.Size = new System.Drawing.Size(180, 45);
            this.STD_GoOut_Button.TabIndex = 14;
            this.STD_GoOut_Button.Text = "Go Out";
            this.STD_GoOut_Button.Click += new System.EventHandler(this.STD_GoOut_Button_Click);
            // 
            // STD_Logout_Button
            // 
            this.STD_Logout_Button.BorderColor = System.Drawing.Color.White;
            this.STD_Logout_Button.BorderRadius = 19;
            this.STD_Logout_Button.BorderThickness = 1;
            this.STD_Logout_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_Logout_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_Logout_Button.CheckedState.Parent = this.STD_Logout_Button;
            this.STD_Logout_Button.CustomImages.Parent = this.STD_Logout_Button;
            this.STD_Logout_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_Logout_Button.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.STD_Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_Logout_Button.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.STD_Logout_Button.HoverState.Parent = this.STD_Logout_Button;
            this.STD_Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("STD_Logout_Button.Image")));
            this.STD_Logout_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.STD_Logout_Button.Location = new System.Drawing.Point(1033, 22);
            this.STD_Logout_Button.Name = "STD_Logout_Button";
            this.STD_Logout_Button.ShadowDecoration.Parent = this.STD_Logout_Button;
            this.STD_Logout_Button.Size = new System.Drawing.Size(165, 45);
            this.STD_Logout_Button.TabIndex = 12;
            this.STD_Logout_Button.Text = "Log Out";
            this.STD_Logout_Button.Click += new System.EventHandler(this.STD_Logout_Button_Click);
            // 
            // STDViewVisitors_Button
            // 
            this.STDViewVisitors_Button.BorderRadius = 19;
            this.STDViewVisitors_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STDViewVisitors_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STDViewVisitors_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STDViewVisitors_Button.CheckedState.Parent = this.STDViewVisitors_Button;
            this.STDViewVisitors_Button.CustomImages.Parent = this.STDViewVisitors_Button;
            this.STDViewVisitors_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STDViewVisitors_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STDViewVisitors_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STDViewVisitors_Button.HoverState.Parent = this.STDViewVisitors_Button;
            this.STDViewVisitors_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._16981;
            this.STDViewVisitors_Button.Location = new System.Drawing.Point(12, 602);
            this.STDViewVisitors_Button.Name = "STDViewVisitors_Button";
            this.STDViewVisitors_Button.ShadowDecoration.Parent = this.STDViewVisitors_Button;
            this.STDViewVisitors_Button.Size = new System.Drawing.Size(180, 45);
            this.STDViewVisitors_Button.TabIndex = 8;
            this.STDViewVisitors_Button.Text = "View Visitors";
            this.STDViewVisitors_Button.Click += new System.EventHandler(this.STDViewVisitors_Button_Click);
            // 
            // STDRoomShift_Button
            // 
            this.STDRoomShift_Button.BorderRadius = 19;
            this.STDRoomShift_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STDRoomShift_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STDRoomShift_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STDRoomShift_Button.CheckedState.Parent = this.STDRoomShift_Button;
            this.STDRoomShift_Button.CustomImages.Parent = this.STDRoomShift_Button;
            this.STDRoomShift_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STDRoomShift_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STDRoomShift_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STDRoomShift_Button.HoverState.Parent = this.STDRoomShift_Button;
            this.STDRoomShift_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._2911176;
            this.STDRoomShift_Button.Location = new System.Drawing.Point(12, 515);
            this.STDRoomShift_Button.Name = "STDRoomShift_Button";
            this.STDRoomShift_Button.ShadowDecoration.Parent = this.STDRoomShift_Button;
            this.STDRoomShift_Button.Size = new System.Drawing.Size(180, 45);
            this.STDRoomShift_Button.TabIndex = 7;
            this.STDRoomShift_Button.Text = "Room Shift";
            this.STDRoomShift_Button.Click += new System.EventHandler(this.STDRoomShift_Button_Click);
            // 
            // STDViewAttendance_Button
            // 
            this.STDViewAttendance_Button.BorderRadius = 19;
            this.STDViewAttendance_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STDViewAttendance_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STDViewAttendance_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STDViewAttendance_Button.CheckedState.Parent = this.STDViewAttendance_Button;
            this.STDViewAttendance_Button.CustomImages.Parent = this.STDViewAttendance_Button;
            this.STDViewAttendance_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STDViewAttendance_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STDViewAttendance_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STDViewAttendance_Button.HoverState.Parent = this.STDViewAttendance_Button;
            this.STDViewAttendance_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._66118951;
            this.STDViewAttendance_Button.Location = new System.Drawing.Point(12, 333);
            this.STDViewAttendance_Button.Name = "STDViewAttendance_Button";
            this.STDViewAttendance_Button.ShadowDecoration.Parent = this.STDViewAttendance_Button;
            this.STDViewAttendance_Button.Size = new System.Drawing.Size(180, 45);
            this.STDViewAttendance_Button.TabIndex = 6;
            this.STDViewAttendance_Button.Text = "View Attendance";
            this.STDViewAttendance_Button.Click += new System.EventHandler(this.STDViewAttendance_Button_Click);
            // 
            // STD_ViewBills_Button
            // 
            this.STD_ViewBills_Button.BorderRadius = 19;
            this.STD_ViewBills_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STD_ViewBills_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_ViewBills_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_ViewBills_Button.CheckedState.Parent = this.STD_ViewBills_Button;
            this.STD_ViewBills_Button.CustomImages.Parent = this.STD_ViewBills_Button;
            this.STD_ViewBills_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_ViewBills_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STD_ViewBills_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_ViewBills_Button.HoverState.Parent = this.STD_ViewBills_Button;
            this.STD_ViewBills_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.bill;
            this.STD_ViewBills_Button.Location = new System.Drawing.Point(12, 249);
            this.STD_ViewBills_Button.Name = "STD_ViewBills_Button";
            this.STD_ViewBills_Button.ShadowDecoration.Parent = this.STD_ViewBills_Button;
            this.STD_ViewBills_Button.Size = new System.Drawing.Size(180, 45);
            this.STD_ViewBills_Button.TabIndex = 5;
            this.STD_ViewBills_Button.Text = "View Bills";
            this.STD_ViewBills_Button.Click += new System.EventHandler(this.STD_ViewBills_Button_Click);
            // 
            // STD_PersonalInfo_Button
            // 
            this.STD_PersonalInfo_Button.BorderRadius = 19;
            this.STD_PersonalInfo_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STD_PersonalInfo_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_PersonalInfo_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_PersonalInfo_Button.CheckedState.Parent = this.STD_PersonalInfo_Button;
            this.STD_PersonalInfo_Button.CustomImages.Parent = this.STD_PersonalInfo_Button;
            this.STD_PersonalInfo_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_PersonalInfo_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STD_PersonalInfo_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_PersonalInfo_Button.HoverState.Parent = this.STD_PersonalInfo_Button;
            this.STD_PersonalInfo_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._1077114;
            this.STD_PersonalInfo_Button.Location = new System.Drawing.Point(12, 145);
            this.STD_PersonalInfo_Button.Name = "STD_PersonalInfo_Button";
            this.STD_PersonalInfo_Button.ShadowDecoration.Parent = this.STD_PersonalInfo_Button;
            this.STD_PersonalInfo_Button.Size = new System.Drawing.Size(180, 45);
            this.STD_PersonalInfo_Button.TabIndex = 4;
            this.STD_PersonalInfo_Button.Text = "Personal Info";
            this.STD_PersonalInfo_Button.Click += new System.EventHandler(this.STD_PersonalInfo_Button_Click);
            // 
            // STDDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1368, 721);
            this.Controls.Add(this.STD_GoOut_Button);
            this.Controls.Add(this.Exit_STD_Dashboard_Button);
            this.Controls.Add(this.STD_Logout_Button);
            this.Controls.Add(this.STDViewVisitors_Button);
            this.Controls.Add(this.STDRoomShift_Button);
            this.Controls.Add(this.STDViewAttendance_Button);
            this.Controls.Add(this.STD_ViewBills_Button);
            this.Controls.Add(this.STD_PersonalInfo_Button);
            this.Controls.Add(this.STD_Welcome);
            this.Controls.Add(this.STD_NavigatorBar_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STDDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STDDashboard";
            this.Load += new System.EventHandler(this.STDDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STD_NavigatorBar_Label;
        private System.Windows.Forms.Label STD_Welcome;
        private Guna.UI2.WinForms.Guna2Button STD_PersonalInfo_Button;
        private Guna.UI2.WinForms.Guna2Elipse STD_Dashboard_Elispse;
        private System.Windows.Forms.Timer STDWelcome_Timer;
        private Guna.UI2.WinForms.Guna2Button STD_ViewBills_Button;
        private Guna.UI2.WinForms.Guna2Button STDViewVisitors_Button;
        private Guna.UI2.WinForms.Guna2Button STDRoomShift_Button;
        private Guna.UI2.WinForms.Guna2Button STDViewAttendance_Button;
        private Guna.UI2.WinForms.Guna2Button STD_Logout_Button;
        private Guna.UI2.WinForms.Guna2Button Exit_STD_Dashboard_Button;
        private Guna.UI2.WinForms.Guna2Button STD_GoOut_Button;
    }
}