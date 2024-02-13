<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="Gmail.homepage" %>
 
<%@ Register Src="Password.ascx" TagName="ucPasswordToggle"  TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .login1 {
            background-color: honeydew;
            animation-name: example;
            animation-duration: 4s;
        }

        @keyframes example {
            from {
                background-color: honeydew;
            }

            to {
                background-color: yellow;
            }
        }

        div {
            padding-top: 50px;
            padding-bottom: 50px;
            padding-right: 50px;
            padding-left: 50px
        }

        .login2 {
            border-style: solid;
            height: 50px;
            vertical-align: bottom;
        }
        </style>
</head>
<body class="login1">
    <form id="form1" runat="server">

        <div>
            <center>
                <h1><b>LOGIN PAGE</b></h1>
                <table class="login2">
                    <tr>
                        <td><b>Firstname  :</b></td>
                        <td>
                            <asp:TextBox ID="firstname" runat="server" placeholder="enter the first name" AutoCompleteType="Disabled"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><b>Lastname :</b></td>
                        <td>
                            <asp:TextBox ID="lastnamet" runat="server" placeholder="enter the last name" AutoCompleteType="Disabled"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><b>Gender&nbsp;&nbsp; :</b></td>
                        <td>
                            <asp:RadioButtonList ID="genderList1t" runat="server">
                                <asp:ListItem Value="M">Male</asp:ListItem>
                                <asp:ListItem Value="F">Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td><b>username :</b></td>
                        <td>
                            <asp:TextBox ID="usernamet" runat="server" placeholder="enter the user name" AutoCompleteType="Disabled"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><b>password  :</b></td>
                        <td>
             
                          <uc:PasswordToggle ID="ucPasswordToggle" runat="server"></uc:PasswordToggle>

                          </td>
                    </tr>
                    <tr>
                        <td><b>country  :</b></td>
                        <td>
                            <asp:DropDownList ID="ddlcountry" DataTextField="name" DataValueField="lookupid" runat="server" OnSelectedIndexChanged="country_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><b>State  :</b></td>
                        <td>
                            <asp:DropDownList ID="ddlstate" DataTextField="name" DataValueField="lookupid" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><b>Active</b></td>
                        <td>
                            <asp:CheckBox ID="active1" runat="server" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="msglbl" runat="server" ForeColor="RED"></asp:Label>
                        </td>
                    </tr>
                </table>
                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click"/>
                <asp:Button ID="btncancel" runat="server" Text="Cancel" />
                <asp:HiddenField ID="userIdHidden" runat="server" />
                
            </center>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
