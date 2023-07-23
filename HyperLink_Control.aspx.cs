using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learnBasicConcept_ASP_DOT_Net
{
    public partial class HyperLink_Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DynamicHyperLink1.Focus();
            //DynamicHyperLink1.NavigateUrl = "";
        }
    }
}