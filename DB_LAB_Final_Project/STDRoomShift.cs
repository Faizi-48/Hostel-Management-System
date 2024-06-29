using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_Final_Project
{
    public partial class STDRoomShift : Form
    {
        public STDRoomShift()
        {
            InitializeComponent();
        }

        private void STDRoomShift_Load(object sender, EventArgs e)
        {
            this.Location = new Point(550, 240);
        }

        private void STDShiftClose_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STD_ShiftSendRequest_Button_Click(object sender, EventArgs e)
        {
            STDShiftRequest shiftrequest = new STDShiftRequest();
            this.Hide();
            shiftrequest.Show();
        }
    }
}
