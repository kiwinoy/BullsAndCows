<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BullsAndCows.Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- You may change anything on this page if required -->
    <div class="row">
        <h2>Secret number</h2>
        <!--<h2><span class="label label-default">********</span></h2>-->
        <asp:TextBox ID="bcNumber" TextMode="Password" runat="server" />
    </div>

    <div class="row">
        <h3>Guess</h3>
        <!--<input class="input-lg" id="guess"/>-->
        <asp:TextBox ID="guess" runat="server"/>
        <asp:Button runat="server" class="btn btn-info" id="btnSubmit" Text="Submit Guess" OnClick="btnSubmit_OnClick"></asp:Button>
    </div>
    
    <br/>

    <div class="row">
        <h3>Results</h3>
        <asp:Label runat="server" id="results" Text=""></asp:Label>
        <asp:Button runat="server" class="btn btn-info" id="btnReset" Text="Reset" OnClick="btnReset_OnClick"></asp:Button>
    </div>
</asp:Content>
