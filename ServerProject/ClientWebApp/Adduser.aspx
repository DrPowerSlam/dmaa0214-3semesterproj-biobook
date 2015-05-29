<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adduser.aspx.cs" Inherits="ClientWebApp.Adduser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  

    <div class="row">
        <div class="col-lg-6">
            <asp:TextBox ID="txtName" placeholder="Navn" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
       </div>
    <br />
    <div class="row">
              <div class="col-lg-6">
            <asp:TextBox ID="txtPhone" placeholder="Telefon nummer" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

     <br />
    <div class="row">
              <div class="col-lg-6">
            <asp:TextBox ID="txtPassword" placeholder="Adgangskode" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

         <br />
    <div class="row">
              <div class="col-lg-6">
            <asp:TextBox ID="txtMail" placeholder="E-mail adresse" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

            <br />
    <div class="row">
              <div class="col-lg-6">
                 
                  <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" Text="Klik for at oprette" OnClick="btnSubmit_Click" />      <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" Text="Annuler" OnClick="btnCancel_Click" />

        </div>
    </div>
  

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <li><a href="Registrer.aspx" visible="true" runat="server" id="reg">REGISTRER</a></li>
    <li><a href="Login.aspx" visible="true" runat="server" id="log">LOG IND</a></li>

</asp:Content>

