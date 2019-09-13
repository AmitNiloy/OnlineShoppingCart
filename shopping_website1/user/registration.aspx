<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="user_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<table>
<tr>
<td>firstname</td>
<td>
<asp:TextBox ID="Textbox1" runat="server"></asp:TextBox>
</td>

</tr>


<tr>
<td>lastname</td>
<td>
<asp:TextBox ID="Textbox2" runat="server"></asp:TextBox>
</td>

</tr>


<tr>
<td>email</td>
<td>
<asp:TextBox ID="Textbox3" runat="server"></asp:TextBox>
</td>

</tr>


<tr>
<td>password</td>
<td>
<asp:TextBox ID="Textbox4" runat="server" TextMode="Password"></asp:TextBox>
</td>

</tr>



<tr>
<td>address</td>
<td>
<asp:TextBox ID="Textbox5" runat="server" Height="78px" TextMode="MultiLine"></asp:TextBox>
</td>

</tr>



<tr>
<td>city</td>
<td>
<asp:TextBox ID="Textbox6" runat="server"></asp:TextBox>
</td>

</tr>


<tr>
<td>state</td>
<td>
<asp:TextBox ID="Textbox7" runat="server"></asp:TextBox>
</td>

</tr>



<tr>
<td>pincode</td>
<td>
<asp:TextBox ID="Textbox8" runat="server"></asp:TextBox>
</td>

</tr>



<tr>
<td>mobile no.</td>
<td>
<asp:TextBox ID="Textbox9" runat="server"></asp:TextBox>
</td>

</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click" />
</td>

</tr>

<tr>

<td colspan="2" align="center">
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</td>

</tr>


</table>

</asp:Content>

