<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Course.Contact" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
       
        <h1>Welcome to Pet Questionnaire </h1>
    </hgroup>

    <section class="contact">
        <h3>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </h3>
        <p>
            <table style="width: 98%; height: 278px; margin-top: 0px;">
                <tr>
                    <td class="auto-style3">Select a questions</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="QuestionDrop" runat="server" AutoPostBack="True" Height="37px" Width="408px" OnSelectedIndexChanged="QuestionDrop_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" Height="29px" OnClick="Button2_Click" Text="Ok" Width="145px" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Choose your Answers</td>
                    <td class="auto-style8">
                        <asp:ListBox ID="ListBox1" runat="server" Height="85px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="400px"></asp:ListBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Image ID="Image1" runat="server" Height="50px" Width="64px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        Correct Answer</td>
                    <td class="auto-style1">
                        <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" Width="306px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:Button ID="SUB1" runat="server" Height="33px" OnClick="Button1_Click" Text="Submit" Width="198px" />
                    </td>
                </tr>
            </table>
        </p>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
            width: 464px;
        }
        .auto-style2 {
            height: 30px;
            width: 219px;
        }
        .auto-style3 {
            height: 30px;
            width: 129px;
        }
        .auto-style4 {
            width: 129px;
            height: 56px;
        }
        .auto-style6 {
            height: 56px;
            width: 219px;
        }
        .auto-style7 {
            height: 30px;
            width: 464px;
        }
        .auto-style8 {
            height: 56px;
            width: 464px;
        }
        .auto-style9 {
            height: 23px;
            width: 129px;
        }
    </style>
</asp:Content>
