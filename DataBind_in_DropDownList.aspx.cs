using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class DataBind_in_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          string CS =  ConfigurationManager.ConnectionStrings["JO"].ConnectionString;
            using SqlConnection con = new SqlConnection(CS)
            {
                SqlCommand  cmd = new SqlCommand("select username from admin_login_tbl",con);
                con.Open();
            DropDownList1.DataSource = cmd.ExecuteReader();
            DropDownList1.DataBind();
            DropDownList1.DataTextFi
            }
        }
    }
}