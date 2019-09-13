<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="testing.aspx.cs" Inherits="user_testing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
<br />
<!--in this way we can create our asp button whenever we need-->
<asp:Button ID ="b1" runat ="server" Text="cookies store" Onclick="b1_Click" />
<asp:Button ID ="b2" runat ="server" Text="cookies display" Onclick="b2_Click" />
<asp:Button ID ="b3" runat ="server" Text="cookies update" Onclick="b3_Click" />
<asp:Button ID ="b4" runat ="server" Text="cookies display using array" Onclick="b4_Click" />

</asp:Content>

