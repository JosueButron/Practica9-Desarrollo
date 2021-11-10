<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LinqXML.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
    </div>
    <form id="form1" runat="server">
        <asp:Button ID="cmdCreateXml" runat="server" OnClick="cmdCreateXml_Click1" Text="Crear XML" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="cmdReadXml" runat="server" OnClick="cmdReadXml_Click1" Text="Leer XML" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="cdmReadXmlAsObjects" runat="server" OnClick="cdmReadXmlAsObjects_Click1" Text="Leer como objeto" />
        <br />
        <br />
        <asp:Label ID="lblXml" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gridResults" runat="server">
        </asp:GridView>
        <br />
        <br />
    </form>
</body>
</html>
