<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lanchonete.aspx.cs" Inherits="WebApplication1.Lanchonete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Digite as informações da pizza<br />
            <br />
            Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id" runat="server" Width="170px"></asp:TextBox>
            <br />
            <br />
            Descrição:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="descricao" runat="server" Width="170px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Valor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="valor" runat="server" Width="170px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="inserir" runat="server" OnClick="inserir_Click" Text="Inserir" Width="94px" />
            &nbsp;&nbsp;
            <asp:Button ID="consultar" runat="server" OnClick="consultar_Click" Text="Consultar" Width="94px" />
            &nbsp;&nbsp;
            <asp:Button ID="remover" runat="server" OnClick="remover_Click" Text="Remover" Width="94px" />
&nbsp;&nbsp;
            <asp:Button ID="valorTotal" runat="server" Text="Valor Total" OnClick="valorTotal_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="log" runat="server" OnClick="log_Click" Text="Logs" Width="94px" />
            <br />
            <br />
            <asp:Label ID="msg" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GVDados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
