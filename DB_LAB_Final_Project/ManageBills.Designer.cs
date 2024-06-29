namespace DB_LAB_Final_Project
{
    partial class ManageBills
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
            this.GenerateBills_Label = new System.Windows.Forms.Label();
            this.GenerateBillID_Label = new System.Windows.Forms.Label();
            this.GenerateBill_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PayBill_Label = new System.Windows.Forms.Label();
            this.PayBill_Button = new Guna.UI2.WinForms.Guna2Button();
            this.GenerateBill_CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.GenerateHostelFee_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // GenerateBills_Label
            // 
            this.GenerateBills_Label.AutoSize = true;
            this.GenerateBills_Label.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GenerateBills_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.GenerateBills_Label.Location = new System.Drawing.Point(279, 9);
            this.GenerateBills_Label.Name = "GenerateBills_Label";
            this.GenerateBills_Label.Size = new System.Drawing.Size(279, 57);
            this.GenerateBills_Label.TabIndex = 2;
            this.GenerateBills_Label.Text = "Generate Bills";
            // 
            // GenerateBillID_Label
            // 
            this.GenerateBillID_Label.AutoSize = true;
            this.GenerateBillID_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBillID_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.GenerateBillID_Label.Location = new System.Drawing.Point(12, 120);
            this.GenerateBillID_Label.Name = "GenerateBillID_Label";
            this.GenerateBillID_Label.Size = new System.Drawing.Size(307, 34);
            this.GenerateBillID_Label.TabIndex = 14;
            this.GenerateBillID_Label.Text = "Enter ID to Generate Bill:";
            // 
            // GenerateBill_TextBox
            // 
            this.GenerateBill_TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.GenerateBill_TextBox.BorderRadius = 16;
            this.GenerateBill_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GenerateBill_TextBox.DefaultText = "";
            this.GenerateBill_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GenerateBill_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GenerateBill_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GenerateBill_TextBox.DisabledState.Parent = this.GenerateBill_TextBox;
            this.GenerateBill_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GenerateBill_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.GenerateBill_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenerateBill_TextBox.FocusedState.Parent = this.GenerateBill_TextBox;
            this.GenerateBill_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.GenerateBill_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenerateBill_TextBox.HoverState.Parent = this.GenerateBill_TextBox;
            this.GenerateBill_TextBox.Location = new System.Drawing.Point(352, 120);
            this.GenerateBill_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateBill_TextBox.Name = "GenerateBill_TextBox";
            this.GenerateBill_TextBox.PasswordChar = '\0';
            this.GenerateBill_TextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.GenerateBill_TextBox.PlaceholderText = "";
            this.GenerateBill_TextBox.SelectedText = "";
            this.GenerateBill_TextBox.ShadowDecoration.Parent = this.GenerateBill_TextBox;
            this.GenerateBill_TextBox.Size = new System.Drawing.Size(237, 39);
            this.GenerateBill_TextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.GenerateBill_TextBox.TabIndex = 15;
            // 
            // PayBill_Label
            // 
            this.PayBill_Label.AutoSize = true;
            this.PayBill_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBill_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.PayBill_Label.Location = new System.Drawing.Point(12, 402);
            this.PayBill_Label.Name = "PayBill_Label";
            this.PayBill_Label.Size = new System.Drawing.Size(113, 34);
            this.PayBill_Label.TabIndex = 34;
            this.PayBill_Label.Text = "Pay Bill:";
            // 
            // PayBill_Button
            // 
            this.PayBill_Button.BorderRadius = 19;
            this.PayBill_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.PayBill_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.PayBill_Button.CheckedState.Parent = this.PayBill_Button;
            this.PayBill_Button.CustomImages.Parent = this.PayBill_Button;
            this.PayBill_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.PayBill_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBill_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.PayBill_Button.HoverState.Parent = this.PayBill_Button;
            this.PayBill_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.paybill;
            this.PayBill_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.PayBill_Button.Location = new System.Drawing.Point(203, 389);
            this.PayBill_Button.Name = "PayBill_Button";
            this.PayBill_Button.ShadowDecoration.Parent = this.PayBill_Button;
            this.PayBill_Button.Size = new System.Drawing.Size(219, 57);
            this.PayBill_Button.TabIndex = 35;
            this.PayBill_Button.Text = "Pay Bills";
            this.PayBill_Button.Click += new System.EventHandler(this.PayBill_Button_Click);
            // 
            // GenerateBill_CloseButton
            // 
            this.GenerateBill_CloseButton.CheckedState.Parent = this.GenerateBill_CloseButton;
            this.GenerateBill_CloseButton.CustomImages.Parent = this.GenerateBill_CloseButton;
            this.GenerateBill_CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.GenerateBill_CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateBill_CloseButton.ForeColor = System.Drawing.Color.White;
            this.GenerateBill_CloseButton.HoverState.Parent = this.GenerateBill_CloseButton;
            this.GenerateBill_CloseButton.Image = global::DB_LAB_Final_Project.Properties.Resources.close;
            this.GenerateBill_CloseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.GenerateBill_CloseButton.Location = new System.Drawing.Point(792, 12);
            this.GenerateBill_CloseButton.Name = "GenerateBill_CloseButton";
            this.GenerateBill_CloseButton.ShadowDecoration.Parent = this.GenerateBill_CloseButton;
            this.GenerateBill_CloseButton.Size = new System.Drawing.Size(62, 45);
            this.GenerateBill_CloseButton.TabIndex = 33;
            this.GenerateBill_CloseButton.Click += new System.EventHandler(this.GenerateBill_CloseButton_Click);
            // 
            // GenerateHostelFee_Button
            // 
            this.GenerateHostelFee_Button.BorderRadius = 19;
            this.GenerateHostelFee_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.GenerateHostelFee_Button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.GenerateHostelFee_Button.CheckedState.Parent = this.GenerateHostelFee_Button;
            this.GenerateHostelFee_Button.CustomImages.Parent = this.GenerateHostelFee_Button;
            this.GenerateHostelFee_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.GenerateHostelFee_Button.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateHostelFee_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.GenerateHostelFee_Button.HoverState.Parent = this.GenerateHostelFee_Button;
            this.GenerateHostelFee_Button.Image = global::DB_LAB_Final_Project.Properties.Resources.generatebill;
            this.GenerateHostelFee_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.GenerateHostelFee_Button.Location = new System.Drawing.Point(352, 227);
            this.GenerateHostelFee_Button.Name = "GenerateHostelFee_Button";
            this.GenerateHostelFee_Button.ShadowDecoration.Parent = this.GenerateHostelFee_Button;
            this.GenerateHostelFee_Button.Size = new System.Drawing.Size(219, 57);
            this.GenerateHostelFee_Button.TabIndex = 30;
            this.GenerateHostelFee_Button.Text = "Hostel Fee";
            this.GenerateHostelFee_Button.Click += new System.EventHandler(this.GenerateHostelFee_Button_Click);
            // 
            // ManageBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(875, 512);
            this.Controls.Add(this.PayBill_Button);
            this.Controls.Add(this.PayBill_Label);
            this.Controls.Add(this.GenerateBill_CloseButton);
            this.Controls.Add(this.GenerateHostelFee_Button);
            this.Controls.Add(this.GenerateBill_TextBox);
            this.Controls.Add(this.GenerateBillID_Label);
            this.Controls.Add(this.GenerateBills_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBills";
            this.Text = "ManageBills";
            this.Load += new System.EventHandler(this.ManageBills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GenerateBills_Label;
        private System.Windows.Forms.Label GenerateBillID_Label;
        private Guna.UI2.WinForms.Guna2TextBox GenerateBill_TextBox;
        private Guna.UI2.WinForms.Guna2Button GenerateHostelFee_Button;
        private Guna.UI2.WinForms.Guna2Button GenerateBill_CloseButton;
        private System.Windows.Forms.Label PayBill_Label;
        private Guna.UI2.WinForms.Guna2Button PayBill_Button;
    }
}