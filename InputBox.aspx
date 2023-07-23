<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InputBox.aspx.cs" Inherits="learnBasicConcept_ASP_DOT_Net.InputBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <%--properties

            maxlenght 
            readonly
            textmode = email , password and so on 
            tooltip on hover used
            columns
            height 
            width
            autopostback
            ontextchanged method make sure to use autopostback=true
             methods of a textbox
            focus- 
            on pageload method 

            textbox1.focus()


            
            --%>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
