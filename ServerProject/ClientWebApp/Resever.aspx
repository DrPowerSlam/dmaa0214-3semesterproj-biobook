<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resever.aspx.cs" Inherits="ClientWebApp.Resever" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script runat="server">

    </script>


        <div class="thumbnail2">
            <div class="col-md-12">



                <asp:Literal ID="litMovieInfo" runat="server"></asp:Literal>


            </div>
        </div>

<%--        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>--%>
                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">

                        <span class="glyphicon glyphicon-film"></span>
                        <div class="title">
                            VÆLG <b>BILLETTER</b>



                        </div>

                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">
                        <span class="glyphicon glyphicon-credit-card"></span>
                        <div class="title">
                            <!-- <asp:TextBox ID="txtSeatList" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox> -->

                            VÆLG <b>PLACERING</b>
                        </div>


                    </div>
                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">
                        <span class="glyphicon glyphicon-th"></span>
                        <div class="title">
                            VÆLG <b>BETALING/KVITTERING</b>
                            
                        </div>
                    </div>
                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">
                        <asp:DropDownList ID="ddlTickets" AutoPostBack="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlTickets_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">

                            <asp:Literal ID="litSeatList" runat="server"></asp:Literal>

                    </div>

                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">
                        <asp:Literal ID="litLoggedOn" runat="server" Text="Jeg kan se at du er ikke logget på. Log på eller registerer en bruger øverst på siden."></asp:Literal>
                        <asp:Button ID="btnConfirm" runat="server" Text="Klik her for at reservere." OnClick="btnConfirm_Click" Visible="false" />

                    </div>
                </div>
                
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <li><a href="Registrer.aspx" visible="true" runat="server" id="reg">REGISTRER</a></li>
    <li><a href="Login.aspx" visible="true" runat="server" id="log">LOG IND</a></li>

</asp:Content>

