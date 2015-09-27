<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Lab2.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="log_out.aspx" style="color:blue; font-size: 20px;">Выйти из-под админки</a>
        <asp:ListView ID="ListView1" DataKeyNames="ID" runat="server" ItemType="Lab2.Model.Race" SelectMethod="GetRaces" UpdateMethod="UpdateRace" DeleteMethod="DeleteRace" InsertMethod="InsertRace" InsertItemPosition="LastItem">
            <LayoutTemplate>
                <div>
                    <table>
                        <tr>
                            <th>Аэропорт</th>
                            <th>Пункт вылета</th>
                            <th>Пункт назначения</th>
                            <th>Дата и время вылета</th>
                            <th>Дата и время прилета</th>
                            <th>Задержка</th>
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
                    <td><%# Item.DepartureDateTime %></td>
                    <td><%# Item.DestinationDateTime %></td>
                    <td><%# Item.DelayTimeSpan %></td>
                    <td>
                        <asp:Button CommandName="Edit" Text="Редактировать" runat="server"/>
                        <asp:Button CommandName="Delete" Text="Удалить" runat="server"/>
                    </td>
                </tr>
            </ItemTemplate>
            <EditItemTemplate>
                <tr>
                    <td><input name="Aeroport" value="<%# Item.Aeroport%>"/>
                        <input type="hidden" name="ID" value="<%# Item.ID%>" />
                    </td>
                    <td><input name="Departure" value="<%# Item.Departure%>"/></td>
                    <td><input name="Destination" value="<%# Item.Destination%>"/></td>
                    <td><input name="DepartureDateTime" value="<%# Item.DepartureDateTime%>"/></td>
                    <td><input name="DestinationDateTime" value="<%# Item.DestinationDateTime%>"/></td>
                    <td><input name="DelayTimeSpan" value="<%# Item.DelayTimeSpan%>"/></td>
                    <td>
                        <asp:Button CommandName="Update" Text="ОК" runat="server" />
                        <asp:Button CommandName="Cancel" Text="Отмена" runat="server" />
                    </td>
                </tr>
            </EditItemTemplate>
            <InsertItemTemplate>
                <tr>
                    <td><input name="Aeroport"/>
                        <input type="hidden" name="ID" value="0" />
                    </td>
                    <td><input name="Departure"/></td>
                    <td><input name="Destination"/></td>
                    <td><input name="DepartureDateTime"/></td>
                    <td><input name="DestinationDateTime"/></td>
                    <td><input name="DelayTimeSpan"/></td>
                    <td>
                        <asp:Button CommandName="Insert" Text="Добавить" runat="server" />
                    </td>
                </tr>
            </InsertItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
