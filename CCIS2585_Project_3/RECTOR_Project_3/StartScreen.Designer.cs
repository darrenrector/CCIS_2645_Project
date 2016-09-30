namespace Project3_CS
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPayrollData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowseInfo = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(166, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Application Menu";
            // 
            // btnPayrollData
            // 
            this.btnPayrollData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPayrollData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayrollData.FlatAppearance.BorderSize = 2;
            this.btnPayrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayrollData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayrollData.Location = new System.Drawing.Point(192, 180);
            this.btnPayrollData.Name = "btnPayrollData";
            this.btnPayrollData.Size = new System.Drawing.Size(227, 39);
            this.btnPayrollData.TabIndex = 2;
            this.btnPayrollData.Text = "Payroll Data";
            this.btnPayrollData.UseVisualStyleBackColor = false;
            this.btnPayrollData.Click += new System.EventHandler(this.btnPayrollData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(192, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnBrowseInfo
            // 
            this.btnBrowseInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBrowseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseInfo.FlatAppearance.BorderSize = 2;
            this.btnBrowseInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrowseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInfo.Location = new System.Drawing.Point(192, 105);
            this.btnBrowseInfo.Name = "btnBrowseInfo";
            this.btnBrowseInfo.Size = new System.Drawing.Size(227, 39);
            this.btnBrowseInfo.TabIndex = 4;
            this.btnBrowseInfo.Text = "Browse Employee Data";
            this.btnBrowseInfo.UseVisualStyleBackColor = false;
            this.btnBrowseInfo.Click += new System.EventHandler(this.btnBrowseInfo_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 444);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "(error)";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 466);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBrowseInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPayrollData);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Start Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPayrollData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowseInfo;
        private System.Windows.Forms.Label lblError;
    }
}

