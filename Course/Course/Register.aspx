<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Course.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Register</h1>
    </hgroup>
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Enter your full name</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox1" runat="server" Width="276px"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Enter your nationality</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox2" runat="server" Width="276px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="227px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
        .auto-style2 {
            height: 33px;
            width: 164px;
            font-size: medium;
        }
        .auto-style3 {
            width: 164px;
            font-size: medium;
        }
        .auto-style4 {
            height: 33px;
            width: 278px;
        }
        .auto-style5 {
            width: 278px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="FeaturedContent">
            <h1>Habbit Information</h1>
        </asp:Content>

