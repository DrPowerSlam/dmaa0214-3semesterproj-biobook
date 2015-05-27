<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientWebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <!-- ASP literal her, som udskriver alle nyste film, fra codebehind: Default.cs -->
    <!-- Title -->

    <asp:Literal ID="litNewstMovies"   runat="server"></asp:Literal>
    Welcome: <asp:LoginName ID="LoginName1" runat="server" />
    <asp:LoginStatus ID="LoginStatus1" runat="server" />

</asp:Content>
