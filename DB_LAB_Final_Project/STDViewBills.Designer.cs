namespace DB_LAB_Final_Project
{
    partial class STDViewBills
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
            this.STDViewBills_Label = new System.Windows.Forms.Label();
            this.STDBillView_GridBox = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STD_ViewMess_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STD_ViewHostel_Button = new Guna.UI2.WinForms.Guna2Button();
            this.STDViewBills_CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewBills_ApplyGYM_Button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.STDBillView_GridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // STDViewBills_Label
            // 
            this.STDViewBills_Label.AutoSize = true;
            this.STDViewBills_Label.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STDViewBills_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STDViewBills_Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.STDViewBills_Label.Location = new System.Drawing.Point(315, 9);
            this.STDViewBills_Label.Name = "STDViewBills_Label";
            this.STDViewBills_Label.Size = new System.Drawing.Size(218, 57);
            this.STDViewBills_Label.TabIndex = 3;
            this.STDViewBills_Label.Text = "View Bills";
            this.STDViewBills_Label.Click += new System.EventHandler(this.STDViewBills_Label_Click);
            // 
            // STDBillView_GridBox
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.STDBillView_GridBox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.STDBillView_GridBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.STDBillView_GridBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.STDBillView_GridBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.STDBillView_GridBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.STDBillView_GridBox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.STDBillView_GridBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.STDBillView_GridBox.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.STDBillView_GridBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.STDBillView_GridBox.EnableHeadersVisualStyles = false;
            this.STDBillView_GridBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.STDBillView_GridBox.Location = new System.Drawing.Point(92, 88);
            this.STDBillView_GridBox.Name = "STDBillView_GridBox";
            this.STDBillView_GridBox.RowHeadersVisible = false;
            this.STDBillView_GridBox.RowHeadersWidth = 51;
            this.STDBillView_GridBox.RowTemplate.Height = 24;
            this.STDBillView_GridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.STDBillView_GridBox.Size = new System.Drawing.Size(647, 297);
            this.STDBillView_GridBox.TabIndex = 5;
            this.STDBillView_GridBox.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.STDBillView_GridBox.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.STDBillView_GridBox.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.STDBillView_GridBox.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.STDBillView_GridBox.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.STDBillView_GridBox.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.STDBillView_GridBox.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.STDBillView_GridBox.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.STDBillView_GridBox.ThemeStyle.HeaderStyle.Height = 4;
            this.STDBillView_GridBox.ThemeStyle.ReadOnly = false;
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.Height = 24;
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.STDBillView_GridBox.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // STD_ViewMess_Button
            // 
            this.STD_ViewMess_Button.BorderRadius = 19;
            this.STD_ViewMess_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STD_ViewMess_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_ViewMess_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_ViewMess_Button.CheckedState.Parent = this.STD_ViewMess_Button;
            this.STD_ViewMess_Button.CustomImages.Parent = this.STD_ViewMess_Button;
            this.STD_ViewMess_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_ViewMess_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STD_ViewMess_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_ViewMess_Button.HoverState.Parent = this.STD_ViewMess_Button;
            this.STD_ViewMess_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.bill;
            this.STD_ViewMess_Button.Location = new System.Drawing.Point(92, 437);
            this.STD_ViewMess_Button.Name = "STD_ViewMess_Button";
            this.STD_ViewMess_Button.ShadowDecoration.Parent = this.STD_ViewMess_Button;
            this.STD_ViewMess_Button.Size = new System.Drawing.Size(180, 45);
            this.STD_ViewMess_Button.TabIndex = 6;
            this.STD_ViewMess_Button.Text = "Mess Bill";
            this.STD_ViewMess_Button.Click += new System.EventHandler(this.STD_ViewMess_Button_Click);
            // 
            // STD_ViewHostel_Button
            // 
            this.STD_ViewHostel_Button.BorderRadius = 19;
            this.STD_ViewHostel_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.STD_ViewHostel_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.STD_ViewHostel_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.STD_ViewHostel_Button.CheckedState.Parent = this.STD_ViewHostel_Button;
            this.STD_ViewHostel_Button.CustomImages.Parent = this.STD_ViewHostel_Button;
            this.STD_ViewHostel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STD_ViewHostel_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STD_ViewHostel_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.STD_ViewHostel_Button.HoverState.Parent = this.STD_ViewHostel_Button;
            this.STD_ViewHostel_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.bill;
            this.STD_ViewHostel_Button.Location = new System.Drawing.Point(325, 437);
            this.STD_ViewHostel_Button.Name = "STD_ViewHostel_Button";
            this.STD_ViewHostel_Button.ShadowDecoration.Parent = this.STD_ViewHostel_Button;
            this.STD_ViewHostel_Button.Size = new System.Drawing.Size(180, 45);
            this.STD_ViewHostel_Button.TabIndex = 7;
            this.STD_ViewHostel_Button.Text = "Hostel Bill";
            this.STD_ViewHostel_Button.Click += new System.EventHandler(this.STD_ViewHostel_Button_Click);
            // 
            // STDViewBills_CloseButton
            // 
            this.STDViewBills_CloseButton.CheckedState.Parent = this.STDViewBills_CloseButton;
            this.STDViewBills_CloseButton.CustomImages.Parent = this.STDViewBills_CloseButton;
            this.STDViewBills_CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.STDViewBills_CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STDViewBills_CloseButton.ForeColor = System.Drawing.Color.White;
            this.STDViewBills_CloseButton.HoverState.Parent = this.STDViewBills_CloseButton;
            this.STDViewBills_CloseButton.Image = global::DB_LAB_Final_Project.Properties.Resources.close;
            this.STDViewBills_CloseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.STDViewBills_CloseButton.Location = new System.Drawing.Point(801, 12);
            this.STDViewBills_CloseButton.Name = "STDViewBills_CloseButton";
            this.STDViewBills_CloseButton.ShadowDecoration.Parent = this.STDViewBills_CloseButton;
            this.STDViewBills_CloseButton.Size = new System.Drawing.Size(62, 45);
            this.STDViewBills_CloseButton.TabIndex = 20;
            this.STDViewBills_CloseButton.Click += new System.EventHandler(this.STDViewBills_CloseButton_Click);
            // 
            // ViewBills_ApplyGYM_Button
            // 
            this.ViewBills_ApplyGYM_Button.BorderRadius = 19;
            this.ViewBills_ApplyGYM_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ViewBills_ApplyGYM_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ViewBills_ApplyGYM_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ViewBills_ApplyGYM_Button.CheckedState.Parent = this.ViewBills_ApplyGYM_Button;
            this.ViewBills_ApplyGYM_Button.CustomImages.Parent = this.ViewBills_ApplyGYM_Button;
            this.ViewBills_ApplyGYM_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.ViewBills_ApplyGYM_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewBills_ApplyGYM_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ViewBills_ApplyGYM_Button.HoverState.Parent = this.ViewBills_ApplyGYM_Button;
            this.ViewBills_ApplyGYM_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._681494;
            this.ViewBills_ApplyGYM_Button.Location = new System.Drawing.Point(577, 437);
            this.ViewBills_ApplyGYM_Button.Name = "ViewBills_ApplyGYM_Button";
            this.ViewBills_ApplyGYM_Button.ShadowDecoration.Parent = this.ViewBills_ApplyGYM_Button;
            this.ViewBills_ApplyGYM_Button.Size = new System.Drawing.Size(180, 45);
            this.ViewBills_ApplyGYM_Button.TabIndex = 21;
            this.ViewBills_ApplyGYM_Button.Text = "Apply For Gym";
            this.ViewBills_ApplyGYM_Button.Click += new System.EventHandler(this.ViewBills_ApplyGYM_Button_Click);
            // 
            // STDViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.ViewBills_ApplyGYM_Button);
            this.Controls.Add(this.STDViewBills_CloseButton);
            this.Controls.Add(this.STD_ViewHostel_Button);
            this.Controls.Add(this.STD_ViewMess_Button);
            this.Controls.Add(this.STDBillView_GridBox);
            this.Controls.Add(this.STDViewBills_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STDViewBills";
            this.Text = "STDViewBills";
            this.Load += new System.EventHandler(this.STDViewBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STDBillView_GridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STDViewBills_Label;
        private Guna.UI2.WinForms.Guna2DataGridView STDBillView_GridBox;
        private Guna.UI2.WinForms.Guna2Button STD_ViewMess_Button;
        private Guna.UI2.WinForms.Guna2Button STD_ViewHostel_Button;
        private Guna.UI2.WinForms.Guna2Button STDViewBills_CloseButton;
        private Guna.UI2.WinForms.Guna2Button ViewBills_ApplyGYM_Button;
    }
}