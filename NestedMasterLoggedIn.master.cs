using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjektKoncowyV5
{
    public partial class NestedMasterLoggedIn : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["User"] != "tak")
            {
                Response.Redirect("mainNotLoggedIn.aspx");
            }



        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("mainNotLoggedIn.aspx");
        }
    }
}