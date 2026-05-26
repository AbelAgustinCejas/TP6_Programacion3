<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos2.aspx.cs" Inherits="TP6_Grupo19_2_.SeleccionarProductos2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvProductos" runat="server"
    AutoGenerateColumns="False"
    AllowPaging="True"
    PageSize="14"
    DataKeyNames="IdProducto"
    OnPageIndexChanging="gvProductos_PageIndexChanging" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvProductos_SelectedIndexChanging">

    <Columns>

        <asp:TemplateField HeaderText="Id Producto">
            <ItemTemplate>
                <asp:Label ID="lbl_it_idProducto"
                    runat="server"
                    Text='<%# Bind("IdProducto") %>'>
                </asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Nombre Producto">
            <ItemTemplate>
                <asp:Label ID="lbl_it_NombreProducto"
                    runat="server"
                    Text='<%# Bind("NombreProducto") %>'>
                </asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txt_eit_NombreProducto"
                    runat="server"
                    Text='<%# Bind("NombreProducto") %>'>
                </asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Id Proovedor">
            <EditItemTemplate>
                <asp:TextBox ID="txt_eit_idProovedor"
                    runat="server"
                    Text='<%# Bind("idProovedor") %>'>
                </asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                lbl_it_idProovedor
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Precio Unidad">
            <ItemTemplate>
                <asp:Label ID="lbl_it_PrecioUnidad"
                    runat="server"
                    Text='<%# Bind("PrecioUnidad") %>'>
                </asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txt_eit_PrecioUnidad"
                    runat="server"
                    Text='<%# Bind("PrecioUnidad") %>'>
                </asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>

    </Columns>

    <FooterStyle BackColor="White" ForeColor="#000066" />
    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
    <RowStyle ForeColor="#000066" />
    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#007DBB" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#00547E" />

</asp:GridView>
        </div>
    </form>
</body>
</html>
