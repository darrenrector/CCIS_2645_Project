namespace Project3_CS
{
    partial class frmEmployeeData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeData));
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblMiddleInit = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.getPayrollByEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDataSet = new Project3_CS.PayrollDataSet();
            this.getPayrollByEmployeeTableAdapter = new Project3_CS.PayrollDataSetTableAdapters.GetPayrollByEmployeeTableAdapter();
            this.tableAdapterManager = new Project3_CS.PayrollDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEmployeeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPayrollByEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.lblError);
            this.grpEmployeeData.Controls.Add(this.txtError);
            this.grpEmployeeData.Controls.Add(this.txtMInit);
            this.grpEmployeeData.Controls.Add(this.txtFName);
            this.grpEmployeeData.Controls.Add(this.txtLName);
            this.grpEmployeeData.Controls.Add(this.txtEmpID);
            this.grpEmployeeData.Controls.Add(this.lblMiddleInit);
            this.grpEmployeeData.Controls.Add(this.lblFirstName);
            this.grpEmployeeData.Controls.Add(this.lblLastName);
            this.grpEmployeeData.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeData.Location = new System.Drawing.Point(168, 53);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Size = new System.Drawing.Size(472, 180);
            this.grpEmployeeData.TabIndex = 0;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Employee Data";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(209, 167);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "(error)";
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(305, 157);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(100, 13);
            this.txtError.TabIndex = 11;
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMInit
            // 
            this.txtMInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMInit.Location = new System.Drawing.Point(97, 140);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.ReadOnly = true;
            this.txtMInit.Size = new System.Drawing.Size(31, 20);
            this.txtMInit.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Location = new System.Drawing.Point(97, 100);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(124, 20);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Location = new System.Drawing.Point(97, 60);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(124, 20);
            this.txtLName.TabIndex = 5;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Location = new System.Drawing.Point(97, 20);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(66, 20);
            this.txtEmpID.TabIndex = 2;
            // 
            // lblMiddleInit
            // 
            this.lblMiddleInit.AutoSize = true;
            this.lblMiddleInit.Location = new System.Drawing.Point(21, 147);
            this.lblMiddleInit.Name = "lblMiddleInit";
            this.lblMiddleInit.Size = new System.Drawing.Size(68, 13);
            this.lblMiddleInit.TabIndex = 4;
            this.lblMiddleInit.Text = "Middle Initial:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(28, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(19, 27);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Papyrus", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblAppTitle.Location = new System.Drawing.Point(268, -4);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(301, 54);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Application Title";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(167, 252);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(80, 26);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(265, 252);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 26);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(363, 252);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 26);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(461, 252);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(80, 26);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(559, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // getPayrollByEmployeeBindingSource
            // 
            this.getPayrollByEmployeeBindingSource.DataMember = "GetPayrollByEmployee";
            this.getPayrollByEmployeeBindingSource.DataSource = this.payrollDataSet;
            // 
            // payrollDataSet
            // 
            this.payrollDataSet.DataSetName = "PayrollDataSet";
            this.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPayrollByEmployeeTableAdapter
            // 
            this.getPayrollByEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project3_CS.PayrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(83, 284);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(641, 193);
            this.dataGridView1.TabIndex = 11;
            // 
            // frmEmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(806, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.grpEmployeeData);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeData";
            this.Text = "Employee Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeData_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeData_Load);
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPayrollByEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeData;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblMiddleInit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExit;
        private PayrollDataSet payrollDataSet;
        private System.Windows.Forms.BindingSource getPayrollByEmployeeBindingSource;
        private PayrollDataSetTableAdapters.GetPayrollByEmployeeTableAdapter getPayrollByEmployeeTableAdapter;
        private PayrollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}