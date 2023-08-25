using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class ConnectionStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string CS = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using(SqlConnection Con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select * from categories",Con);
               // SqlCommand cmd = new SqlCommand("select * from Categories",connection);
               Con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
               // connection.Open();
               // GridView1.DataSource = cmd.ExecuteReader();
               //GridView1.DataBind();
            }
        }
    }
}