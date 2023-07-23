<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLink_Control.aspx.cs" Inherits="learnBasicConcept_ASP_DOT_Net.HyperLink_Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          <%--  HyperLink Control Properties
              Text
              navigate URL
              Image URL
              Target  _blank(open in new tab)
              
              method :
              focus() - on page load method

              no event property
              you can use on page load method like
              hyperlink.navigateURL="google.com"
              
              
              --%>
            <asp:TextBox runat="server" />
            <br />
            <asp:DynamicHyperLink ID="DynamicHyperLink1" NavigateUrl="https://jogindrakumar.com/" Text="Click here to see Owner website" Target="_blank" runat="server"></asp:DynamicHyperLink>
        </div>
    </form>
</body>

</html>
