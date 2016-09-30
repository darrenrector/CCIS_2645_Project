namespace Project3_CS
{
    partial class frmPayRoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayRoll));
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.txtWeekEnding = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblPayrollTitle = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblWeekEnding = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pdlgGrid = new System.Windows.Forms.PrintDialog();
            this.sfdPayroll = new System.Windows.Forms.SaveFileDialog();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.pdGrid = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(209, 140);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(121, 21);
            this.cboEmployee.TabIndex = 0;
            // 
            // txtWeekEnding
            // 
            this.txtWeekEnding.Location = new System.Drawing.Point(565, 140);
            this.txtWeekEnding.Name = "txtWeekEnding";
            this.txtWeekEnding.Size = new System.Drawing.Size(127, 20);
            this.txtWeekEnding.TabIndex = 1;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(565, 208);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(127, 20);
            this.txtHoursWorked.TabIndex = 2;
            // 
            // lblPayrollTitle
            // 
            this.lblPayrollTitle.AutoSize = true;
            this.lblPayrollTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayrollTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollTitle.Location = new System.Drawing.Point(255, 25);
            this.lblPayrollTitle.Name = "lblPayrollTitle";
            this.lblPayrollTitle.Size = new System.Drawing.Size(301, 41);
            this.lblPayrollTitle.TabIndex = 3;
            this.lblPayrollTitle.Text = "Employee Payroll";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(116, 141);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(74, 17);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Employee:";
            // 
            // lblWeekEnding
            // 
            this.lblWeekEnding.AutoSize = true;
            this.lblWeekEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekEnding.Location = new System.Drawing.Point(453, 141);
            this.lblWeekEnding.Name = "lblWeekEnding";
            this.lblWeekEnding.Size = new System.Drawing.Size(96, 17);
            this.lblWeekEnding.TabIndex = 5;
            this.lblWeekEnding.Text = "Week Ending:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(446, 209);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(103, 17);
            this.lblHoursWorked.TabIndex = 6;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(189, 256);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(100, 36);
            this.btnCommit.TabIndex = 8;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(354, 256);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 36);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(519, 256);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 36);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(684, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pdlgGrid
            // 
            this.pdlgGrid.UseEXDialog = true;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll.Location = new System.Drawing.Point(24, 298);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.Size = new System.Drawing.Size(760, 167);
            this.dgvPayroll.TabIndex = 12;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(50, 208);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(59, 20);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "(error)";
            // 
            // pdGrid
            // 
            this.pdGrid.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdGrid_PrintPage);
            // 
            // frmPayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 477);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvPayroll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblWeekEnding);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblPayrollTitle);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtWeekEnding);
            this.Controls.Add(this.cboEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayRoll";
            this.Text = "Payroll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPayRoll_FormClosing);
            this.Load += new System.EventHandler(this.frmPayrollData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.TextBox txtWeekEnding;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblPayrollTitle;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblWeekEnding;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PrintDialog pdlgGrid;
        private System.Windows.Forms.SaveFileDialog sfdPayroll;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label lblError;
        private System.Drawing.Printing.PrintDocument pdGrid;
    }
}