<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resever.aspx.cs" Inherits="ClientWebApp.Resever" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server">
    </asp:ScriptManager>



    <script runat="server">

    </script>


    <div class="container">
        <div class="thumbnail2">
            <div class="col-md-12">



                <asp:Literal ID="litMovieInfo" runat="server"></asp:Literal>


            </div>
        </div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
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
                        <asp:DropDownList ID="ddlTickets" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlTickets_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">

                            <asp:Literal ID="litSeatList" runat="server"></asp:Literal>

                    </div>

                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="thumbnail">
                        ddd
                    </div>
                </div>
                </div>


            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlTickets" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
</asp:Content>
