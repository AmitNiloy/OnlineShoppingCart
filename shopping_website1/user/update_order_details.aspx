<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="update_order_details.aspx.cs" Inherits="user_update_order_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<table>

<tr>

<td>firstname</td>
<td>
<asp:TextBox ID="t1" runat="server"></asp:TextBox>

</td>
</tr>


<tr>

<td>lasstname</td>
<td>
<asp:TextBox ID="t2" runat="server"></asp:TextBox>

</td>
</tr>



<tr>

<td>address</td>
<td>
<asp:TextBox ID="t3" runat="server" Height="46px" TextMode="MultiLine"></asp:TextBox>

</td>
</tr>



<tr>

<td>city</td>
<td>
<asp:TextBox ID="t4" runat="server"></asp:TextBox>

</td>
</tr>


<tr>

<td>state</td>
<td>
<asp:TextBox ID="t5" runat="server"></asp:TextBox>

</td>
</tr>




<tr>

<td>mobile</td>
<td>
<asp:TextBox ID="t6" runat="server"></asp:TextBox>

</td>
</tr>

<tr>
<td colspan="2" align ="center">
<asp:Button ID="b1" runat="server" Text="update and continue" onclick="b1_Click" />
</td>


</tr>


</table>
</asp:Content>

