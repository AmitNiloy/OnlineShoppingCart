<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="display_order.aspx.cs" Inherits="admin_display_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
  <asp:Repeater ID ="r1" runat="server">
<HeaderTemplate>
<table border =' 3 '>
<tr style="background-color:Gray; color:White" >
<td>id</td>
<td>firstname</td>
<td>lastname</td>
<td>city</td>
<td>state</td>
<td>pincode</td>
<td>view full order</td>
</tr>

</HeaderTemplate>
<ItemTemplate>
<tr>
<td><%#Eval("id") %>></td>
<td><%#Eval("firstname") %>></td>
<td><%#Eval("lastname") %>></td>
<td><%#Eval("city") %>></td>
<td><%#Eval("state") %>></td>
<td><%#Eval("pincode") %>></td>
<td><a href="view_full_order.aspx?id=<%#Eval("id") %>">view full order</a></td>

</tr>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>

</asp:Repeater>
</asp:Content>

