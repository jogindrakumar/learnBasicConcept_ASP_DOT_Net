using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class InputBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello" + TextBox1.Text);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("hello" + TextBox1.Text);
        }
    }
}