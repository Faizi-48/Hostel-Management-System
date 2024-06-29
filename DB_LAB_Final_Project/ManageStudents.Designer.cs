namespace DB_LAB_Final_Project
{
    partial class ManageStudents
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
            this.ManageStudents_Label = new System.Windows.Forms.Label();
            this.DeleteStudent_Label = new System.Windows.Forms.Label();
            this.DeleteStudent_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddorUpdateStudent_Label = new System.Windows.Forms.Label();
            this.ViewAllStudents_Label = new System.Windows.Forms.Label();
            this.ViewAllStudents_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ManageStudents_CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddStudent_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteStudent_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ManageStudents_Label
            // 
            this.ManageStudents_Label.AutoSize = true;
            this.ManageStudents_Label.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ManageStudents_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ManageStudents_Label.Location = new System.Drawing.Point(188, 9);
            this.ManageStudents_Label.Name = "ManageStudents_Label";
            this.ManageStudents_Label.Size = new System.Drawing.Size(336, 57);
            this.ManageStudents_Label.TabIndex = 2;
            this.ManageStudents_Label.Text = "Manage Students";
            // 
            // DeleteStudent_Label
            // 
            this.DeleteStudent_Label.AutoSize = true;
            this.DeleteStudent_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudent_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.DeleteStudent_Label.Location = new System.Drawing.Point(12, 102);
            this.DeleteStudent_Label.Name = "DeleteStudent_Label";
            this.DeleteStudent_Label.Size = new System.Drawing.Size(233, 34);
            this.DeleteStudent_Label.TabIndex = 14;
            this.DeleteStudent_Label.Text = "Enter ID to Delete:";
            // 
            // DeleteStudent_TextBox
            // 
            this.DeleteStudent_TextBox.BorderColor = System.Drawing.Color.Black;
            this.DeleteStudent_TextBox.BorderRadius = 16;
            this.DeleteStudent_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteStudent_TextBox.DefaultText = "";
            this.DeleteStudent_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeleteStudent_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeleteStudent_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteStudent_TextBox.DisabledState.Parent = this.DeleteStudent_TextBox;
            this.DeleteStudent_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteStudent_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.DeleteStudent_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteStudent_TextBox.FocusedState.Parent = this.DeleteStudent_TextBox;
            this.DeleteStudent_TextBox.ForeColor = System.Drawing.Color.Black;
            this.DeleteStudent_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteStudent_TextBox.HoverState.Parent = this.DeleteStudent_TextBox;
            this.DeleteStudent_TextBox.Location = new System.Drawing.Point(265, 102);
            this.DeleteStudent_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteStudent_TextBox.Name = "DeleteStudent_TextBox";
            this.DeleteStudent_TextBox.PasswordChar = '\0';
            this.DeleteStudent_TextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.DeleteStudent_TextBox.PlaceholderText = "";
            this.DeleteStudent_TextBox.SelectedText = "";
            this.DeleteStudent_TextBox.ShadowDecoration.Parent = this.DeleteStudent_TextBox;
            this.DeleteStudent_TextBox.Size = new System.Drawing.Size(237, 39);
            this.DeleteStudent_TextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.DeleteStudent_TextBox.TabIndex = 15;
            // 
            // AddorUpdateStudent_Label
            // 
            this.AddorUpdateStudent_Label.AutoSize = true;
            this.AddorUpdateStudent_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddorUpdateStudent_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.AddorUpdateStudent_Label.Location = new System.Drawing.Point(12, 352);
            this.AddorUpdateStudent_Label.Name = "AddorUpdateStudent_Label";
            this.AddorUpdateStudent_Label.Size = new System.Drawing.Size(277, 34);
            this.AddorUpdateStudent_Label.TabIndex = 32;
            this.AddorUpdateStudent_Label.Text = "Add or Update Student:";
            // 
            // ViewAllStudents_Label
            // 
            this.ViewAllStudents_Label.AutoSize = true;
            this.ViewAllStudents_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllStudents_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ViewAllStudents_Label.Location = new System.Drawing.Point(12, 457);
            this.ViewAllStudents_Label.Name = "ViewAllStudents_Label";
            this.ViewAllStudents_Label.Size = new System.Drawing.Size(225, 34);
            this.ViewAllStudents_Label.TabIndex = 35;
            this.ViewAllStudents_Label.Text = "View All Students:";
            // 
            // ViewAllStudents_Button
            // 
            this.ViewAllStudents_Button.BorderRadius = 19;
            this.ViewAllStudents_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.ViewAllStudents_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ViewAllStudents_Button.CheckedState.Parent = this.ViewAllStudents_Button;
            this.ViewAllStudents_Button.CustomImages.Parent = this.ViewAllStudents_Button;
            this.ViewAllStudents_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ViewAllStudents_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.ViewAllStudents_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ViewAllStudents_Button.HoverState.Parent = this.ViewAllStudents_Button;
            this.ViewAllStudents_Button.Image = global::DB_LAB_Final_Project.Properties.Resources._476700;
            this.ViewAllStudents_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewAllStudents_Button.Location = new System.Drawing.Point(330, 434);
            this.ViewAllStudents_Button.Name = "ViewAllStudents_Button";
            this.ViewAllStudents_Button.ShadowDecoration.Parent = this.ViewAllStudents_Button;
            this.ViewAllStudents_Button.Size = new System.Drawing.Size(225, 57);
            this.ViewAllStudents_Button.TabIndex = 36;
            this.ViewAllStudents_Button.Text = "View Students";
            this.ViewAllStudents_Button.Click += new System.EventHandler(this.ViewAllStudents_Button_Click);
            // 
            // ManageStudents_CloseButton
            // 
            this.ManageStudents_CloseButton.CheckedState.Parent = this.ManageStudents_CloseButton;
            this.ManageStudents_CloseButton.CustomImages.Parent = this.ManageStudents_CloseButton;
            this.ManageStudents_CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ManageStudents_CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageStudents_CloseButton.ForeColor = System.Drawing.Color.White;
            this.ManageStudents_CloseButton.HoverState.Parent = this.ManageStudents_CloseButton;
            this.ManageStudents_CloseButton.Image = global::DB_LAB_Final_Project.Properties.Resources.close;
            this.ManageStudents_CloseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ManageStudents_CloseButton.Location = new System.Drawing.Point(785, 21);
            this.ManageStudents_CloseButton.Name = "ManageStudents_CloseButton";
            this.ManageStudents_CloseButton.ShadowDecoration.Parent = this.ManageStudents_CloseButton;
            this.ManageStudents_CloseButton.Size = new System.Drawing.Size(62, 45);
            this.ManageStudents_CloseButton.TabIndex = 34;
            this.ManageStudents_CloseButton.Click += new System.EventHandler(this.ManageStudents_CloseButton_Click);
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.BorderRadius = 19;
            this.AddStudent_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddStudent_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.AddStudent_Button.CheckedState.Parent = this.AddStudent_Button;
            this.AddStudent_Button.CustomImages.Parent = this.AddStudent_Button;
            this.AddStudent_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.AddStudent_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.AddStudent_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.AddStudent_Button.HoverState.Parent = this.AddStudent_Button;
            this.AddStudent_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.adduser;
            this.AddStudent_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.AddStudent_Button.Location = new System.Drawing.Point(330, 343);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.ShadowDecoration.Parent = this.AddStudent_Button;
            this.AddStudent_Button.Size = new System.Drawing.Size(194, 57);
            this.AddStudent_Button.TabIndex = 33;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // DeleteStudent_Button
            // 
            this.DeleteStudent_Button.BorderRadius = 19;
            this.DeleteStudent_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.DeleteStudent_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.DeleteStudent_Button.CheckedState.Parent = this.DeleteStudent_Button;
            this.DeleteStudent_Button.CustomImages.Parent = this.DeleteStudent_Button;
            this.DeleteStudent_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.DeleteStudent_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudent_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.DeleteStudent_Button.HoverState.Parent = this.DeleteStudent_Button;
            this.DeleteStudent_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.deleteuser;
            this.DeleteStudent_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.DeleteStudent_Button.Location = new System.Drawing.Point(265, 184);
            this.DeleteStudent_Button.Name = "DeleteStudent_Button";
            this.DeleteStudent_Button.ShadowDecoration.Parent = this.DeleteStudent_Button;
            this.DeleteStudent_Button.Size = new System.Drawing.Size(237, 57);
            this.DeleteStudent_Button.TabIndex = 30;
            this.DeleteStudent_Button.Text = "Delete Student";
            this.DeleteStudent_Button.Click += new System.EventHandler(this.DeleteStudent_Button_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.ViewAllStudents_Button);
            this.Controls.Add(this.ViewAllStudents_Label);
            this.Controls.Add(this.ManageStudents_CloseButton);
            this.Controls.Add(this.AddStudent_Button);
            this.Controls.Add(this.AddorUpdateStudent_Label);
            this.Controls.Add(this.DeleteStudent_Button);
            this.Controls.Add(this.DeleteStudent_TextBox);
            this.Controls.Add(this.DeleteStudent_Label);
            this.Controls.Add(this.ManageStudents_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageStudents_Label;
        private System.Windows.Forms.Label DeleteStudent_Label;
        private Guna.UI2.WinForms.Guna2TextBox DeleteStudent_TextBox;
        private Guna.UI2.WinForms.Guna2Button DeleteStudent_Button;
        private System.Windows.Forms.Label AddorUpdateStudent_Label;
        private Guna.UI2.WinForms.Guna2Button AddStudent_Button;
        private Guna.UI2.WinForms.Guna2Button ManageStudents_CloseButton;
        private System.Windows.Forms.Label ViewAllStudents_Label;
        private Guna.UI2.WinForms.Guna2Button ViewAllStudents_Button;
    }
}