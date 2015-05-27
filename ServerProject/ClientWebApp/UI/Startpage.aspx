<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Startpage.aspx.cs" Inherits="ClientWebApp.UI.Startpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="litUser" runat="server"> </asp:Literal> hello
    <asp:LoginName ID="LoginName1" runat="server" />
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>