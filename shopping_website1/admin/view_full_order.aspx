<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="view_full_order.aspx.cs" Inherits="admin_view_full_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
   <asp:Repeater ID ="r1" runat="server">
<HeaderTemplate>
<table>
<tr>

<td>product image</td>
<td>product name</td>
<td>product price</td>
<td>product qty</td>
</tr>


</HeaderTemplate>
<ItemTemplate>
<tr>
<td><img src="../<%#Eval("product_images") %>" height="100" width="100" /></td>

<td><%#Eval("product_name") %>></td>
<td><%#Eval("product_price") %>></td>
<td><%#Eval("product qty") %>></td>
</tr>
</ItemTemplate>

<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>

<asp:Label ID="L1" runat="server" Text=""></asp:Label> 
</asp:Content>

