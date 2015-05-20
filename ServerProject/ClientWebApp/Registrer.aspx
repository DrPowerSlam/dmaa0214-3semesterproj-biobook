<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrer.aspx.cs" Inherits="ClientWebApp.Registrer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <div id="legend">
            <legend class="">
                <h3>Register</h3>
            </legend>
        </div>
        <div class="control-group">
            <!-- Username -->
            <br />
            <label class="control-label" for="username">Fulde navn</label>
            <div class="controls">

                <asp:TextBox ID="txtName" runat="server" CssClass="input-xlarge"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv1" runat="server" ErrorMessage="* Indtast navn" ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>

                <br />
            </div>
        </div>

        <div class="control-group">
            <!-- E-mail -->
            <label class="control-label" for="email">E-mail</label>
            <div class="controls">

                <asp:TextBox ID="txtMail" runat="server" CssClass="input-xlarge"></asp:TextBox>
                <asp:RegularExpressionValidator
                    ID="regEmail"
                    ControlToValidate="txtMail" ForeColor="Red"
                    Text="* ugyldig e-mail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    runat="server" />


                <br />
            </div>
        </div>

        <div class="control-group">
            <!-- Password-->
            <label class="control-label" for="password">Adgangskode</label>
            <div class="controls">

                <asp:TextBox ID="txtPassword" runat="server" CssClass="input-xlarge"></asp:TextBox>
                <br />
            </div>
        </div>

        <div class="control-group">
            <!-- Password -->
            <label class="control-label" for="password_confirm">Gentag adgangskode</label>
            <br />
            <div class="controls">

                <asp:TextBox ID="txtPasswordRepeat" runat="server" CssClass="input-xlarge"></asp:TextBox>
                <br />
            </div>
        </div>

        <div class="control-group">
            <!-- Button -->
            <div class="controls">
                <br />
                <button class="btn btn-success">Register</button>
            </div>
        </div>
    </fieldset>

</asp:Content>
