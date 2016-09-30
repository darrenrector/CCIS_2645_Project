using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter
{
    public partial class ServiceCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturntoMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Main.aspx");

        }
    }
}