<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Lab2.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <a href="login.aspx" style="color:blue; font-size: 20px;">Войти как админ</a>
    <asp:ListView ID="ListView1" DataKeyNames="ID" runat="server" ItemType="Lab2.Model.Race" SelectMethod="GetRaces">
            <LayoutTemplate>
                <div>
                    <table>
                        <tr>
                            <th>Аэропорт</th>
                            <th>Пункт вылета</th>
                            <th>Пункт назначения</th>
                            <th>Дата и время вылета</th>
                            <th>Дата и время прилета</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.Aeroport %></td>
                    <td><%# Item.Departure %></td>
                    <td><%# Item.Destination %></td>
                    <td><%# Item.CorrectDepartureDateTime %></td>
                    <td><%# Item.CorrectDestinationDateTime %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Aeroport">Аэропорт</asp:ListItem>
            <asp:ListItem Value="Departure">Пункт вылета</asp:ListItem>
            <asp:ListItem Value="Destination">Пункт назначения</asp:ListItem>
            <asp:ListItem Value="DepartureDateTime">Дата и время вылета</asp:ListItem>
            <asp:ListItem Value="DestinationDateTime">Дата и время прилета</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" Width="373px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Фильтр" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Показать все" />
    </form>
</body>
</html>
