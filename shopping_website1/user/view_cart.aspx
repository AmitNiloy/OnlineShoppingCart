<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="view_cart.aspx.cs" Inherits="user_view_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<asp:Button ID="b1" runat="server" Text="view cart" OnClick="b1_Click" />
    <asp:DataList ID="d1" runat="server">
    
    <HeaderTemplate>
    
    <table border="1">
    <tr style="background-color:silver; color:white; font-weight:bold">
   
<td>product image</td>
<td>product name</td>
<td>product description</td>
<td>product price</td>
<td>product qty</td>
    <td>delete</td>

    </tr>
    </HeaderTemplate>
    <ItemTemplate>
   <tr>
   <td>
    <img src ='../<%#Eval("product_image") %>' height="100" width="100"/>
    </td>
    <td><%#Eval("product_name") %>
    <td/>
    <td><%#Eval("product_desc") %>
    <td/>
    <td><%#Eval("product_price") %>
    <td/>
    <td><%#Eval("product_qty") %>
    <td/>
   <td> <a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a>
   <td />
  
   </tr>
    
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>

    </asp:DataList>
    
    <br />
    <p align="center">
    <asp:Label ID="L1" runat="server"></asp:Label><br />
    <asp:Button id2 ="B1" runat="server" Text="checkout" onclick="Unnamed1_Click" />
    </p>
   
</asp:Content>

