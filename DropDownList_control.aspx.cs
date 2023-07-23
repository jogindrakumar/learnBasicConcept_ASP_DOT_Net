using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class DropDownList_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                ListItem MalelistItem = new ListItem("Male", "1");
                ListItem FemalelistItem = new ListItem("FeMale", "2");
                DropDownList1.Items.Add(MalelistItem);
                DropDownList1.Items.Add(FemalelistItem);
            }
        }
    }
}