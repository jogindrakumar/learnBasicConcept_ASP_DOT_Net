using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class fileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
            lblMessage.Text = "file uploaded";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
    }
}