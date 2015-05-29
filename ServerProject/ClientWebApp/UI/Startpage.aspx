<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Startpage.aspx.cs" Inherits="ClientWebApp.UI.Startpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="litUser" runat="server"> </asp:Literal>
    <%--<asp:LoginName ID="LoginName1" runat="server" />--%> 

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <li><a href="Registrer.aspx" visible="true" runat="server" id="reg">REGISTRER</a></li>
    <li><a href="Login.aspx" visible="true" runat="server" id="log">LOG IND</a></li>
     <li><a href="#" onServerClick="btnLogout_Click"  visible="true" runat="server" id="logout">LOG UD</a></li>

</asp:Content>

