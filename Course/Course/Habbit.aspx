<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Habbit.aspx.cs" Inherits="Course.Habbit" %>

<!DOCTYPE html>

<head>
    <link href="Content/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .newStyle1 {
            background-color: #A6DBED;
        }
        .newStyle2 {
            background-color: #A6DBED;
        }
        .auto-style1 {
            width: 583px;
        }
        .auto-style2 {
            width: 360px;
        }
        .auto-style3 {
            width: 278px;
        }
        .auto-style4 {
            width: 237px;
            height: 146px;
        }
        .auto-style5 {
            width: 264px;
            height: 163px;
        }
        .auto-style6 {
            width: 360px;
            height: 53px;
        }
        .auto-style7 {
            width: 278px;
            height: 53px;
        }
        .auto-style8 {
            height: 53px;
        }
    </style>
</head>
<form id="form1" runat="server">

<hgroup class="title" style="background-color: #00FFFF">
        <h1>Habbit Information</h1>
    </hgroup>
    <table style="width:100%;">
        <tr>
            <td class="auto-style2"><span style="color: rgb(0, 0, 0); font-family: 'Trebuchet MS', Arial, Verdana, Geneva, Helvetica, sans-serif; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">Chewing is a normal for canine behavior. If your dog chews on something that is not good, say NO in a low voice. Then immediately give your dog a safe toy.</span></td>
            <td class="auto-style3">
                <img alt="" class="auto-style4" src="b.jpg" /></td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><span style="color: rgb(0, 0, 0); font-family: 'Trebuchet MS', Arial, Verdana, Geneva, Helvetica, sans-serif; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">Some dogs will dig under a fence to get out of the yard. It is recommended to have a fence that fit tight to the ground or even be buried a few inches underneath to prevent a dog&#39;s crawling or digging out from under it</span></td>
            <td class="auto-style3">
                <img alt="" class="auto-style5" src="a.jpg" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7">It is important to train pets with your family as a team otherwise it will create problems.<br />
                <br />
                Stay safe and keep your pets happy and healthy</td>
            <td class="auto-style8">
                <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Go Back " Width="219px" />
            </td>
        </tr>
    </table>
</form>

