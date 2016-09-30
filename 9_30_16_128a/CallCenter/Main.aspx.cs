using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnManageTechnicians_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Technicians.aspx");
        }

        protected void btnServiceEvent_Click1(object sender, EventArgs e)
        {
            Response.Redirect("./ServiceCenter.aspx");
        }

        protected void btnResolution_Click(object sender, EventArgs e)
        {
            Response.Redirect("./ProblemResolution.aspx");
        }
    }
}