using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class Ado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source=.;database=BookSolution; integrated security=SSPI");
            //SqlCommand cmd = new SqlCommand("select * from [Categories]", con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader(); // sql excute query inside of it rdr
            //GridView1.DataSource = rdr; //whatever data we got send it this
            //GridView1.DataBind();
            //con.Close();

            //if any other database call then use Oracle,OleDb and so on .

            // other way to  doing this 

            string CS = "data source=.;database=BookSolution; integrated security=SSPI";
           

            //try
            //{
            //    SqlCommand cmd = new SqlCommand("select * from Categories", con);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    GridView1.DataSource = reader;
            //    GridView1.DataBind();
            //}
            //catch
            //{


            //}
            //finally { con.Close(); }
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Categories", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();

                //automatically connection close syntax
            }


        }
    }
}