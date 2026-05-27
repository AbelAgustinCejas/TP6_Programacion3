<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="TP6_Grupo19_2_.MostrarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label
    ID="lblMensaje"
    runat="server"
    Text="Productos seleccionados">
</asp:Label>

            <br />
            <br />
            <br />
      <asp:GridView
    ID="gvProductos"
    runat="server">
</asp:GridView>
            <br />
            <br />
            <br />
            <br />

        <asp:LinkButton
    ID="volverinicio"
    runat="server"
    OnClick="volverinicio_Click">
volver al inicio</asp:LinkButton></div>
    </form>
</body>
</html>
