using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjektKoncowyV5
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ClearForm()
        {
            LoginInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
        }
        private void LogIn(string login, string password)
        {
            string strcon = ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            string sql = "select id from Users where UserName like @Login and Password like @Password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Udało ci się zalogować')", true);
                Session["User"] = "tak";
                Response.Redirect("MainLogedIn.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Błędne dane logowania')", true);
                ClearForm();

            }



        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            LogIn(LoginInput.Text, PasswordInput.Text);
        }
    }
}