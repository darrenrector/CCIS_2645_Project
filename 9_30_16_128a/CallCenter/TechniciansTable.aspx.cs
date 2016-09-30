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
    public partial class TechniciansTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblError.Text = "";
                LoadTechnician();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session.Contents.Remove("TechnicianID"); ////changed from TechnicianID to TechID
            Response.Redirect("./Technicians.aspx");
        }

      
        protected void gvTechnicians_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;
            String strTechID = "";

            lblError.Text = "";

            if (e.CommandName.Trim().ToUpper() == "CHANGE")
            {
                try
                {
                    strTechID = gvTechnicians.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text.ToString();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    lblError.Text = "Unable to find Technician";
                }

                if (!blnErrorOccurred)
                {
                    Session.Contents["TechnicianID"] = strTechID;
                    Response.Redirect("./Technicians.aspx");
                }
            }

            if (e.CommandName.Trim().ToUpper() == "DELETE")
            {
                try
                {
                    strTechID = gvTechnicians.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text.ToString();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    lblError.Text = "Unable to find product";
                }

                if (!blnErrorOccurred)
                {
                    intRetCode = clsDatabase.DeleteTechnician(strTechID);
                    if (intRetCode == 0)
                    {
                        LoadTechnician();
                    }
                    else
                    {
                        lblError.Text = "Unable to remove product";
                    }
                }
            }
        }

        //LOAD TECHNICIAN
        private void LoadTechnician()
        {
            DataSet dsData;

            lblError.Text = "";

            dsData = clsDatabase.GetTechnicians();
            if (dsData == null)
            {
                lblError.Text = "Error retrieving Technician";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving Technician";
                dsData.Dispose();
            }
            else
            {
                gvTechnicians.DataSource = dsData.Tables[0];
                gvTechnicians.DataBind();

                dsData.Dispose();
            }
        }

        protected void btnReturnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Technicians.aspx");

        }


    }
}
