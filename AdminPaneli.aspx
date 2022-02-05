<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPaneli.aspx.cs" Inherits="otuzocak.AdminPaneli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>FENER TABLOSU</div>
        <div>
        <asp:GridView ID="GridView1" runat="server" Height="176px"  Width="531px">
        </asp:GridView>
            <br />
            </div>
    
    <div>ÇATI TABLOSU</div>
    <div>

        <asp:GridView ID="GridView2" runat="server" Height="176px" Width="528px">
        </asp:GridView>

    </div>
</asp:Content>
