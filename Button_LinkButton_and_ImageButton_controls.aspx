<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Button_LinkButton_and_ImageButton_controls.aspx.cs" Inherits="learnBasicConcept_ASP_DOT_Net.Button_LinkButton_and_ImageButton_controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%--button , LinkButton & Image Button 
                
                properties
                commandName
                CommandArgument
                CauseValidation
                ValidationGroup
                PostBackURL
                
                --%>

            <%--on button click you can add event handler like onclick or oncommand on frontend--%>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnCommand="Button1_Command" Text="Button" />
        </div>
        
    </form>
</body>
</html>
