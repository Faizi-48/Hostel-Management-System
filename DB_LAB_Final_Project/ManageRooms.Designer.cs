namespace DB_LAB_Final_Project
{
    partial class ManageHostels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageHostel_Label = new System.Windows.Forms.Label();
            this.SelectHostel_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Select_Hostel_Label = new System.Windows.Forms.Label();
            this.ViewAllRooms_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ViewSpecificRoom_Button = new Guna.UI2.WinForms.Guna2Button();
            this.AdminManageRoom_CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewAllRooms_Button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllRooms_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageHostel_Label
            // 
            this.ManageHostel_Label.AutoSize = true;
            this.ManageHostel_Label.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ManageHostel_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageHostel_Label.Location = new System.Drawing.Point(250, 33);
            this.ManageHostel_Label.Name = "ManageHostel_Label";
            this.ManageHostel_Label.Size = new System.Drawing.Size(297, 57);
            this.ManageHostel_Label.TabIndex = 0;
            this.ManageHostel_Label.Text = "Manage Rooms";
            // 
            // SelectHostel_ComboBox
            // 
            this.SelectHostel_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectHostel_ComboBox.BorderColor = System.Drawing.Color.Black;
            this.SelectHostel_ComboBox.BorderRadius = 16;
            this.SelectHostel_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectHostel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectHostel_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.SelectHostel_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectHostel_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectHostel_ComboBox.FocusedState.Parent = this.SelectHostel_ComboBox;
            this.SelectHostel_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectHostel_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SelectHostel_ComboBox.HoverState.Parent = this.SelectHostel_ComboBox;
            this.SelectHostel_ComboBox.ItemHeight = 30;
            this.SelectHostel_ComboBox.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.SelectHostel_ComboBox.ItemsAppearance.Parent = this.SelectHostel_ComboBox;
            this.SelectHostel_ComboBox.Location = new System.Drawing.Point(184, 159);
            this.SelectHostel_ComboBox.Name = "SelectHostel_ComboBox";
            this.SelectHostel_ComboBox.ShadowDecoration.Parent = this.SelectHostel_ComboBox;
            this.SelectHostel_ComboBox.Size = new System.Drawing.Size(293, 36);
            this.SelectHostel_ComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SelectHostel_ComboBox.TabIndex = 2;
            // 
            // Select_Hostel_Label
            // 
            this.Select_Hostel_Label.AutoSize = true;
            this.Select_Hostel_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Hostel_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Select_Hostel_Label.Location = new System.Drawing.Point(12, 159);
            this.Select_Hostel_Label.Name = "Select_Hostel_Label";
            this.Select_Hostel_Label.Size = new System.Drawing.Size(166, 34);
            this.Select_Hostel_Label.TabIndex = 1;
            this.Select_Hostel_Label.Text = "Select Hostel:";
            // 
            // ViewAllRooms_GridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ViewAllRooms_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewAllRooms_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewAllRooms_GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ViewAllRooms_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewAllRooms_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ViewAllRooms_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewAllRooms_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ViewAllRooms_GridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewAllRooms_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ViewAllRooms_GridView.EnableHeadersVisualStyles = false;
            this.ViewAllRooms_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewAllRooms_GridView.Location = new System.Drawing.Point(38, 212);
            this.ViewAllRooms_GridView.Name = "ViewAllRooms_GridView";
            this.ViewAllRooms_GridView.RowHeadersVisible = false;
            this.ViewAllRooms_GridView.RowHeadersWidth = 51;
            this.ViewAllRooms_GridView.RowTemplate.Height = 24;
            this.ViewAllRooms_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewAllRooms_GridView.Size = new System.Drawing.Size(805, 206);
            this.ViewAllRooms_GridView.TabIndex = 11;
            this.ViewAllRooms_GridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ViewAllRooms_GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ViewAllRooms_GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ViewAllRooms_GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ViewAllRooms_GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ViewAllRooms_GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ViewAllRooms_GridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ViewAllRooms_GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ViewAllRooms_GridView.ThemeStyle.HeaderStyle.Height = 4;
            this.ViewAllRooms_GridView.ThemeStyle.ReadOnly = false;
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.Height = 24;
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewAllRooms_GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewSpecificRoom_Button
            // 
            this.ViewSpecificRoom_Button.BorderRadius = 19;
            this.ViewSpecificRoom_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ViewSpecificRoom_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ViewSpecificRoom_Button.CheckedState.Parent = this.ViewSpecificRoom_Button;
            this.ViewSpecificRoom_Button.CustomImages.Parent = this.ViewSpecificRoom_Button;
            this.ViewSpecificRoom_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ViewSpecificRoom_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSpecificRoom_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ViewSpecificRoom_Button.HoverState.Parent = this.ViewSpecificRoom_Button;
            this.ViewSpecificRoom_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._3731841;
            this.ViewSpecificRoom_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewSpecificRoom_Button.Location = new System.Drawing.Point(253, 424);
            this.ViewSpecificRoom_Button.Name = "ViewSpecificRoom_Button";
            this.ViewSpecificRoom_Button.ShadowDecoration.Parent = this.ViewSpecificRoom_Button;
            this.ViewSpecificRoom_Button.Size = new System.Drawing.Size(294, 57);
            this.ViewSpecificRoom_Button.TabIndex = 12;
            this.ViewSpecificRoom_Button.Text = "View Secific Room";
            this.ViewSpecificRoom_Button.Click += new System.EventHandler(this.ViewSpecificRoom_Button_Click);
            // 
            // AdminManageRoom_CloseButton
            // 
            this.AdminManageRoom_CloseButton.CheckedState.Parent = this.AdminManageRoom_CloseButton;
            this.AdminManageRoom_CloseButton.CustomImages.Parent = this.AdminManageRoom_CloseButton;
            this.AdminManageRoom_CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.AdminManageRoom_CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdminManageRoom_CloseButton.ForeColor = System.Drawing.Color.White;
            this.AdminManageRoom_CloseButton.HoverState.Parent = this.AdminManageRoom_CloseButton;
            this.AdminManageRoom_CloseButton.Image = global::DB_LAB_Final_Project.Properties.Resources.close;
            this.AdminManageRoom_CloseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AdminManageRoom_CloseButton.Location = new System.Drawing.Point(781, 33);
            this.AdminManageRoom_CloseButton.Name = "AdminManageRoom_CloseButton";
            this.AdminManageRoom_CloseButton.ShadowDecoration.Parent = this.AdminManageRoom_CloseButton;
            this.AdminManageRoom_CloseButton.Size = new System.Drawing.Size(62, 45);
            this.AdminManageRoom_CloseButton.TabIndex = 10;
            this.AdminManageRoom_CloseButton.Click += new System.EventHandler(this.AdminPersonalInfo_CloseButton_Click);
            // 
            // ViewAllRooms_Button
            // 
            this.ViewAllRooms_Button.BorderRadius = 19;
            this.ViewAllRooms_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ViewAllRooms_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ViewAllRooms_Button.CheckedState.Parent = this.ViewAllRooms_Button;
            this.ViewAllRooms_Button.CustomImages.Parent = this.ViewAllRooms_Button;
            this.ViewAllRooms_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ViewAllRooms_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllRooms_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ViewAllRooms_Button.HoverState.Parent = this.ViewAllRooms_Button;
            this.ViewAllRooms_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._3731841;
            this.ViewAllRooms_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewAllRooms_Button.Location = new System.Drawing.Point(558, 149);
            this.ViewAllRooms_Button.Name = "ViewAllRooms_Button";
            this.ViewAllRooms_Button.ShadowDecoration.Parent = this.ViewAllRooms_Button;
            this.ViewAllRooms_Button.Size = new System.Drawing.Size(234, 57);
            this.ViewAllRooms_Button.TabIndex = 7;
            this.ViewAllRooms_Button.Text = "View All Rooms";
            this.ViewAllRooms_Button.Click += new System.EventHandler(this.AddRoom_Button_Click);
            // 
            // ManageHostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.ViewSpecificRoom_Button);
            this.Controls.Add(this.ViewAllRooms_GridView);
            this.Controls.Add(this.AdminManageRoom_CloseButton);
            this.Controls.Add(this.ViewAllRooms_Button);
            this.Controls.Add(this.SelectHostel_ComboBox);
            this.Controls.Add(this.Select_Hostel_Label);
            this.Controls.Add(this.ManageHostel_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageHostels";
            this.Text = "ManageHostels";
            this.Load += new System.EventHandler(this.ManageHostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllRooms_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageHostel_Label;
        private Guna.UI2.WinForms.Guna2ComboBox SelectHostel_ComboBox;
        private System.Windows.Forms.Label Select_Hostel_Label;
        private Guna.UI2.WinForms.Guna2Button ViewAllRooms_Button;
        private Guna.UI2.WinForms.Guna2Button AdminManageRoom_CloseButton;
        private Guna.UI2.WinForms.Guna2DataGridView ViewAllRooms_GridView;
        private Guna.UI2.WinForms.Guna2Button ViewSpecificRoom_Button;
    }
}