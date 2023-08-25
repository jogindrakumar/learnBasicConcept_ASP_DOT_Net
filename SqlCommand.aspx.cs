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
    public partial class SqlCommand : System.Web.UI.Page
    {
        public SqlCommand(string v, SqlConnection con)
        {
            V = v;
            Con = con;
        }

        public string V { get; }
        public SqlConnection Con { get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection connnection = new SqlConnection(CS))
            {
                SqlCommand cmd  = new SqlCommand("select * from Categories",connnection);
                connnection.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

      
    }
}