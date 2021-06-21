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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ClearForm()
        {
            SubjectInput.Text = string.Empty;
            SenderInput.Text = string.Empty;
            InputDescription.Text = string.Empty;
            InputPriority.Text = string.Empty;
        }
        private void ExecuteInsert(string subject, string sender, string priority, string description)
        {
            string strcon = ConfigurationManager.ConnectionStrings["Baza"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            string sql = "INSERT INTO Cases (Subject, Sender, Priority, Description) VALUES "
                        + " (@Subject, @Sender, @Priority, @Description)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Subject", SqlDbType.VarChar, 50);
            param[1] = new SqlParameter("@Sender", SqlDbType.VarChar, 50);
            param[2] = new SqlParameter("@Priority", SqlDbType.VarChar, 50);
            param[3] = new SqlParameter("@Description", SqlDbType.Char, 50);


            param[0].Value = subject;
            param[1].Value = sender;
            param[2].Value = priority;
            param[3].Value = description;


            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(param[i]);
            }


            cmd.ExecuteNonQuery();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Zgłoszenie zostało dodane')", true);

            conn.Close();

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            ExecuteInsert(SubjectInput.Text, SenderInput.Text, InputPriority.Text, InputDescription.Text);
            ClearForm();
        }
    }
}