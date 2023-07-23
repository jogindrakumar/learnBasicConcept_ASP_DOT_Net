<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList_control.aspx.cs" Inherits="learnBasicConcept_ASP_DOT_Net.DropDownList_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--dropDown properties
                
                selected
                enabled="true" or False

                or you can add these item on backend also
                if you add listitem on pageload make sure to ispostback
                --%>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
