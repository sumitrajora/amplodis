<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Amplodis-Manage-Blog.aspx.cs" Inherits="Amplodis.AmplodisBlog.Amplodis_Manage_Blog" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="tiny_mce/tiny_mce.js"></script>
    <script type="text/javascript" language="javascript">
        tinyMCE.init({
            mode: "textareas",
            theme: "advanced",
            plugins: "pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups",

        });
    </script>    
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <div>        
        Blog Name: <asp:TextBox ID="txtBlog" runat="server" Width="400"></asp:TextBox><br />
        Description: <asp:TextBox ID="txtDesc" runat="server" Width="400"></asp:TextBox><br />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </div>
        <br />
        <hr /><br />
        <div>
            Select Parent Blog: <asp:DropDownList ID="ddlBlog" runat="server"></asp:DropDownList><br />
            Answer: <asp:TextBox ID="txtAnswer" runat="server" TextMode="MultiLine" Width="800" Height="330"></asp:TextBox><br />
            <asp:Button ID="btnSaveAns" runat="server" Text="Save Answer" OnClick="btnSaveAns_Click" />
        </div>
    </form>
</body>
</html>
