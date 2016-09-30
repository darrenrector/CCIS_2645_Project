using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_CS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Do you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeData data = new frmEmployeeData();
            data.Show();
            this.Hide();
        }

        private void btnPayrollData_Click(object sender, EventArgs e)
        {
            frmPayRoll data = new frmPayRoll();
            data.Show();
            this.Hide();
        }
    }
}
