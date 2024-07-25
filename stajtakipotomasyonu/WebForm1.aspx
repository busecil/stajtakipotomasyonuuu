<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfaa.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StajTakipOtomasyonu.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post" id="form1">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="toluSec" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Toplu Öğrenci Aktar" AutoPostBack="False" OnClick="Button1_Click" />
        <br />        <br /> 
    <asp:GridView ID="topluGW" runat="server">
        </asp:GridView>
        </form>
</asp:Content>
