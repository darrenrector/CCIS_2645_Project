using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Project3_CS
{
    public partial class frmEmployeeData : Form
    {
        DataSet dsEmp = null;
        Int32 intCurrRow = 0;

        public frmEmployeeData()
        {
            InitializeComponent();
        }

        private void frmEmployeeData_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            LoadEmployees();
        }



        private void frmEmployeeData_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Do you want to return to the Main Menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                frmMenu menu = new frmMenu();
                menu.Show();
            }

            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }
        }
        
        private void LoadEmployees()
        {
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            intCurrRow = 0;

            dsEmp = clsDatabase.GetAllEmployees();
            if (dsEmp == null)
            {
                lblError.Text = "Unable to retrieve employee information";
            }
            else if (dsEmp.Tables.Count < 1)
            {
                lblError.Text = "Unable to retrieve employee information";
                dsEmp.Dispose();
                dsEmp = null;
            }
            else if (dsEmp.Tables[0].Rows.Count < 1)
            {
                lblError.Text = "No employee information available at the time, try again later";
            }
            else
            {
                ShowEmployee();
            }
        }
        
        private void ShowEmployee()
        {
            txtEmpID.Text = dsEmp.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
            txtLName.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
            txtFName.Text = dsEmp.Tables[0].Rows[intCurrRow]["FName"].ToString();
            if (dsEmp.Tables[0].Rows[intCurrRow]["MInit"] == DBNull.Value)
            {
                txtMInit.Text = "";
            }
            else
            {
                txtMInit.Text = dsEmp.Tables[0].Rows[intCurrRow]["MInit"].ToString();
            }
            ShowEmpPayroll();
        }

        private void ShowPayroll()
        {
            DataSet dsPay;
        }

        private void ShowEmpPayroll()
        {
            DataSet dsData;
            dsData = clsDatabase.GetPayrollByEmployee(Convert.ToInt32(txtEmpID.Text));
            dataGridView1.DataSource = dsData.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            ShowEmployee();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow++;
            if (intCurrRow < dsEmp.Tables[0].Rows.Count)
            {
                ShowEmployee();
            }
            else
            {
                lblError.Text = "The end of the database has been reached!";
                intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (dsEmp.Tables[0].Rows.Count > 0)
            {
                intCurrRow = 0;
            }
            ShowEmployee();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow--;
            if (intCurrRow >= 0)
            {
                ShowEmployee();
            }
            else
            {
                lblError.Text = "The end of the database has been reached!";
                intCurrRow = 0;
            }
        }
    }
}
