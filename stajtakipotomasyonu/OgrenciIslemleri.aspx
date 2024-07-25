<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfaa.Master" AutoEventWireup="true" CodeBehind="OgrenciIslemleri.aspx.cs" Inherits="StajTakipOtomasyonu.Öğrenciİşlemleri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <form runat="server" method="post" id="form1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="Öğrenci No:" Font-Names="Arial Black"></asp:Label> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="150px" Height="30px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label6" runat="server" Text="Doğum Yeri:" Font-Names="Arial Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox34" runat="server" Width="150px" Height="30px" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label17" runat="server" Text="Anne Adı:" Font-Names="Arial Black"></asp:Label> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox15" runat="server" Width="150px" Height="30px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label ID="Label19" runat="server" Text="Uyruğu:" Font-Names="Arial Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        
    <table style="width:50%; margin-left:246px;">
        <tr>
            <td><asp:Label ID="Label10" runat="server" Text="Öğrenci No:" Font-Names="Arial Black"></asp:Label></td>
            <td><asp:TextBox ID="TextBox10" runat="server" Width="150px" Height="30px"></asp:TextBox></td>
        </tr>
    </table>
        </form>
</asp:Content>
