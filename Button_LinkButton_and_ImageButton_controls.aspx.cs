using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class Button_LinkButton_and_ImageButton_controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // or you can add event handler on button on page load like
            Button1.Click += new EventHandler(Button1_Click);
            //Button1.Command +=  CommandEventHandler(Button1_Command);
           
        }

        private void Button1_Command1(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {

        }
    }
}