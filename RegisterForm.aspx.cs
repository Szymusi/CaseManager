using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjektKoncowyV5
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ClearForm()
        {
            LoginInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            PasswortInputRe.Text = string.Empty;
        }

        private void ExecuteInsert(string login, string password, string passwordRe)
        {
            if (password != passwordRe)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Hasła muszą być takie same')", true);
                ClearForm();
            }
            else
            {
                string strcon = ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;
                SqlConnection conn = new SqlConnection(strcon);
                string sql = "INSERT INTO Users (UserName, Password) VALUES "
                            + " (@userName, @userPassword)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", login);
                cmd.Parameters.AddWithValue("@userPassword", password);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Udało Ci się zarejestrować')", true);
                Session["User"] = "tak";
                Response.Redirect("MainLogedIn.aspx");

            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            ExecuteInsert(LoginInput.Text, PasswordInput.Text, PasswortInputRe.Text);
        }
    }
}