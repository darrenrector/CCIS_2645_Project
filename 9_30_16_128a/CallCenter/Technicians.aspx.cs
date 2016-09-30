using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace CallCenter
{
    public partial class Technicians : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblError.Text = "";
                NewTechnician("--Technician--");
                if (Session.Contents["TechnicianID"] != null)
                {
                    NewTechnician(Session.Contents["TechnicianID"].ToString());
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (Session.Contents["TechnicianID"] != null)
            {
                NewTechnician(Session.Contents["TechnicianID"].ToString());
            }
            else
            {
                txtFirstName.Text = "";
                txtMiddleInit.Text = "";
                txtLastName.Text = "";
                txtEMail.Text = "";
                txtDepartment.Text = "";
                txtPhone.Text = "";
                txtHourlyRate.Text = "";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Int32 intRetValue;
            String strTechID = "";
            lblError.Text = "";

            if (ValidateFields())
            {
                if (Session.Contents["TechnicianID"] == null)
                {
                    intRetValue = clsDatabase.InsertTechnician(strTechID, txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtMiddleInit.Text.Trim(), txtEMail.Text.Trim(), txtPhone.Text.Trim(), txtDepartment.Text.Trim(), txtHourlyRate.Text.Trim());
                    if (intRetValue == 0)
                    {
                        lblError.Text = "New technician inserted";
                        Session.Contents["TechnicianID"] = strTechID;
                    }
                    else
                    {
                        lblError.Text = "Error inserting new technician";
                    }
                }
                else
                {
                    //UPDATE TECHNICIAN
                    intRetValue = clsDatabase.UpdateTechnician(strTechID, txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtMiddleInit.Text.Trim(), txtEMail.Text.Trim(), txtDepartment.Text.Trim(), txtPhone.Text.Trim(), txtHourlyRate.Text.Trim());
                    if (intRetValue == 0)
                    {
                        lblError.Text = "Technician updated";
                    }
                    else
                    {
                        lblError.Text = "Error updating technician";
                    }
                }
            }
        }

        private void NewTechnician(String strTechID)
        {
            DataSet dsData;

            lblError.Text = "";

            dsData = clsDatabase.GetTechnicianByID(strTechID);
            if (dsData == null)
            {
                lblError.Text = "Error retrieving Technician";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving Technician";
                dsData.Dispose();
            }
            else if (dsData.Tables[0].Rows.Count < 1)
            {
                lblError.Text = "Error retrieving Technician";
                dsData.Dispose();
            }
            else
            {
                ddlTechID.Text = strTechID;

                if (dsData.Tables[0].Rows[0]["LName"] == DBNull.Value)
                {
                    txtLastName.Text = "";
                }
                else
                {
                    txtLastName.Text = dsData.Tables[0].Rows[0]["LName"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["FName"] == DBNull.Value)
                {
                    txtFirstName.Text = "";
                }
                else
                {
                    txtFirstName.Text = dsData.Tables[0].Rows[0]["FName"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["MInit"] == DBNull.Value)
                {
                    txtMiddleInit.Text = "";
                }
                else
                {
                    txtMiddleInit.Text = dsData.Tables[0].Rows[0]["MInit"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["EMail"] == DBNull.Value)
                {
                    txtEMail.Text = "";
                }
                else
                {
                    txtEMail.Text = dsData.Tables[0].Rows[0]["EMail"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["Dept"] == DBNull.Value)
                {
                    txtDepartment.Text = "";
                }
                else
                {
                    txtDepartment.Text = dsData.Tables[0].Rows[0]["Dept"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["Phone"] == DBNull.Value)
                {
                    txtPhone.Text = "";
                }
                else
                {
                    txtPhone.Text = dsData.Tables[0].Rows[0]["Phone"].ToString();
                }

                if (dsData.Tables[0].Rows[0]["HRate"] == DBNull.Value)
                {
                    txtHourlyRate.Text = "";
                }
                else
                {
                    txtHourlyRate.Text = dsData.Tables[0].Rows[0]["HRate"].ToString();
                }
                dsData.Dispose();
            }
        }

        private Boolean ValidateFields()
        {
            Boolean blnOk = true;
            String strMessage = "";
            String strTechID = "";

            lblError.Text = "";

            //if (strTechID.Trim().Length < 1)
            //{
            //    blnOk = false;
            //    strMessage += "Technician ID required";
            //}

            if (txtFirstName.Text.Trim().Length < 1)
            {
                blnOk = false;
                strMessage += "First Name required";
            }

            if (txtLastName.Text.Trim().Length < 1)
            {
                blnOk = false;
                strMessage += "Last Name required";
            }

            if(txtPhone.Text.Trim().Length < 10)
            {
                blnOk = false;
                strMessage += "Ten digit phone number required!";
            }

            if (txtHourlyRate.Text.Trim().Length <= 0)
            {
                blnOk = false;
                strMessage += "Hourly rate required!";
            }
            lblError.Text = strMessage;
            return blnOk;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewTech.Enabled = true;
        }

        protected void btnReturntoMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Main.aspx");

        }

        protected void btnNewTech_Click(object sender, EventArgs e)
        {
            NewTech();
        }
        
        //NEWTECH Method
        private void NewTech()
        {
            if (btnNewTech.Enabled == true)
            {
                txtFirstName.Enabled = true;
                txtMiddleInit.Enabled = true;
                txtLastName.Enabled = true;
                txtEMail.Enabled = true;
                txtPhone.Enabled = true;
                txtDepartment.Enabled = true;
                txtHourlyRate.Enabled = true;
                ddlTechID.Enabled = false;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtMiddleInit.Enabled = false;
                txtLastName.Enabled = false;
                txtEMail.Enabled = false;
                txtPhone.Enabled = false;
                txtDepartment.Enabled = false;
                txtHourlyRate.Enabled = false;
                ddlTechID.Enabled = true;
            }
        }

        protected void btnReturnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("./TechniciansTable.aspx");
        }

    }
}
