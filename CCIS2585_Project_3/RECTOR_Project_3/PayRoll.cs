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
    public partial class frmPayRoll : Form
    {
        public frmPayRoll()
        {
            InitializeComponent();
        }

        Int32 intCurrRow = 0;
        DataTable dtGrid = null;
        
        private void frmPayrollData_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            LoadEmployees();
            CreateDataTable();
        }

        private void frmPayRoll_FormClosing(object sender, FormClosingEventArgs e)
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

            if (dtGrid != null)
            {
                dtGrid.Dispose();
            }
        }

        private void LoadEmployees()
        {
            DataSet dsData;

            cboEmployee.Items.Clear();

            dsData = clsDatabase.GetEmployeeNames();
            if (dsData == null)
            {
                lblError.Text = "Error retrieving employee names";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving employee names";
            }
            else
            {
                cboEmployee.DataSource = dsData.Tables[0];
                cboEmployee.DisplayMember = "FullName";
                cboEmployee.ValueMember = "EmpID";
            }

        }
        
        //* CREATE TABLE
        private void CreateDataTable()
        {

            lblError.Text = "";
            if (dtGrid != null)
            {
                dtGrid.Dispose();
            }
            else
            {
            }

            dtGrid = new DataTable();
            dtGrid.Columns.Add("EmpID", typeof(String));
            dtGrid.Columns.Add("EmpName", typeof(String));
            dtGrid.Columns.Add("WeekEnding", typeof(String));
            dtGrid.Columns.Add("HoursWorked", typeof(String));
            dtGrid.Columns.Add("TotalPay", typeof(String));

            dgvPayroll.DataSource = dtGrid;

            dgvPayroll.AllowUserToAddRows = false;
            dgvPayroll.AllowUserToDeleteRows = false;
            dgvPayroll.AllowUserToOrderColumns = false;

            dgvPayroll.Columns[0].Width = 100;
            dgvPayroll.Columns[1].Width = 200;
            dgvPayroll.Columns[2].Width = 150;
            dgvPayroll.Columns[3].Width = 175;
            dgvPayroll.Columns[4].Width = 200;

        }
        
        //* BUTTONS

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Boolean blnIsOK = true;
            Decimal decValue = 0m;

            lblError.Text = "";

            try
            {
                decValue = Convert.ToDecimal(txtHoursWorked.Text);

                //dtGrid.Rows.Add(Convert.ToInt32(cboEmployee.SelectedValue), txtWeekEnding.Text, decValue.ToString(), (decValue * 15.0m));
            }

            catch (Exception ex)
            {
                blnIsOK = false;
                lblError.Text = "The hours worked  box must be numeric, please enter a valid number";
            }

            if (blnIsOK)
            {
                dtGrid.Rows.Add(cboEmployee.SelectedValue, cboEmployee.Text, txtWeekEnding.Text, decValue.ToString(), (decValue * 25.0m));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dlgAnswer;

            dlgAnswer = pdlgGrid.ShowDialog();
            if (dlgAnswer == DialogResult.OK)
            {
                pdGrid.PrinterSettings.PrinterName = pdlgGrid.PrinterSettings.PrinterName;
                pdGrid.PrinterSettings.Copies = pdlgGrid.PrinterSettings.Copies;

                pdGrid.Print();
            }
        }

        private void pdGrid_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fDoc;
            Single sglXPos;
            Single sglYPos;
            Int32 intRow;
            Decimal decTotalValue;

            fDoc = new Font("Arial", 12);

            e.Graphics.DrawString("Employee Payroll Data", fDoc, Brushes.Black, Convert.ToSingle(50), Convert.ToSingle(100));
            String strDate = DateTime.Now.ToLongDateString();

            //Draw Date
            e.Graphics.DrawString(strDate, new Font("Arial", 12),
                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                    e.Graphics.MeasureString(strDate, new Font(dgvPayroll.Font,
                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top);
            //** Print colums headings

            sglYPos = 300;
            for (intRow = 0; intRow < dtGrid.Rows.Count; intRow++)
            {
                //**Table columns placement for printing on page
                sglYPos = Convert.ToSingle(125);
                e.Graphics.DrawString("EmpID", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(30.0), sglYPos);
                e.Graphics.DrawString("EmpName", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(200.0), sglYPos);
                e.Graphics.DrawString("WeekEnding", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(400.0), sglYPos);
                e.Graphics.DrawString("HoursWorked", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(550.0), sglYPos);
                e.Graphics.DrawString("TotalPay", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(700.0), sglYPos);

                //** Accumulate payroll
                decTotalValue = Convert.ToDecimal(0.0);

                for (intRow = 0; intRow < dtGrid.Rows.Count; intRow++)
                {
                    sglXPos = Convert.ToSingle(30);

                    sglYPos += Convert.ToSingle(fDoc.Height);

                    //**Entered values formatting for printing on page
                    e.Graphics.DrawString(dtGrid.Rows[intRow]["EmpID"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                    sglXPos = Convert.ToSingle(200);
                    e.Graphics.DrawString(dtGrid.Rows[intRow]["EmpName"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                    sglXPos = Convert.ToSingle(400);
                    e.Graphics.DrawString(dtGrid.Rows[intRow]["WeekEnding"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                    sglXPos = Convert.ToSingle(550);
                    e.Graphics.DrawString(dtGrid.Rows[intRow]["HoursWorked"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                    sglXPos = Convert.ToSingle(700);
                    e.Graphics.DrawString(dtGrid.Rows[intRow]["TotalPay"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                    decTotalValue += Convert.ToDecimal(dtGrid.Rows[intRow]["TotalPay"]);
                }

                sglYPos += (Convert.ToSingle(fDoc.Height * 2));
                e.Graphics.DrawString("Records: " + dtGrid.Rows.Count.ToString(), fDoc, Brushes.Black, Convert.ToSingle(50), Convert.ToSingle(sglYPos));
                e.Graphics.DrawString("Total Payroll: " + decTotalValue.ToString(), fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(400.0), sglYPos);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult dlgAnswer;
            DataSet dsPay;

            lblError.Text = "";
            sfdPayroll.DefaultExt = "xml";
            sfdPayroll.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            sfdPayroll.InitialDirectory = "C:/Users/Darren/Documents/HTC SPR 2016/Programming II/";
            //sfdPayroll.InitialDirectory = "C:\\:";
            sfdPayroll.OverwritePrompt = true;
            sfdPayroll.Title = "Save XML file";

            dlgAnswer = sfdPayroll.ShowDialog();
            if (dlgAnswer == System.Windows.Forms.DialogResult.OK)
            {
                dsPay = clsDatabase.GetTotalPayrollByWeek();
                if (dsPay == null)
                {
                    lblError.Text = "Unable to retrieve payroll information";
                }
                else if (dsPay.Tables.Count < 1)
                {
                    lblError.Text = "Unable to retrieve payroll information";
                }
                else
                {
                    dsPay.Tables[0].WriteXml(sfdPayroll.FileName);
                    MessageBox.Show("XML saved");

                    dsPay.Dispose();
                }
            }
            else
            {
                lblError.Text = "Save XML cancelled";
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            Int32 intRow;
            for (intRow = 0; intRow < dtGrid.Rows.Count; intRow++)
            {
                clsDatabase.insertPayroll(Convert.ToInt32(dtGrid.Rows[intRow]["EmpID"]), (dtGrid.Rows[intRow]["WeekEnding"].ToString()), Convert.ToDecimal(dtGrid.Rows[intRow]["HoursWorked"]));
            }

            MessageBox.Show("Data uploaded");

            dtGrid.Dispose();
            dtGrid = new DataTable();
        }

        private void Clear()
        {
            txtWeekEnding.Clear();
            txtHoursWorked.Clear();
        }
    }
}
