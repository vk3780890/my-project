<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gmailgrid.aspx.cs" Inherits="Gmail.gmailgrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 86px;
            height: 99px;
            margin-right: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                 <td><asp:Button ID="Button1" Text="New user" runat="server" OnClick="Button1_Click" />
                 </td>  <td>
                      <asp:CheckBox ID="CheckBox1" Text="ShowInactive" runat="server" />
                    </td>
                </tr>
                <tr> 
                    <td colspan="2" >
               <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
               <Columns>
                <%--// <asp:BoundField DataField="uid" HeaderText="uid" />--%>
                    <asp:BoundField DataField="fname" HeaderText="fname" />
                     <asp:BoundField DataField="lname" HeaderText="lname"  />
                     <asp:BoundField DataField="gender" HeaderText="gender" />
                   <asp:BoundField DataField="username" HeaderText="username"  />
                   <asp:BoundField DataField="password" HeaderText="password"  />
                   <asp:BoundField DataField="countryid" HeaderText="countryid"  />
                   <asp:BoundField DataField="stateid" HeaderText="stateid"  />
                   <asp:BoundField DataField="active" HeaderText="active"  />
                     <asp:TemplateField DataField="" HeaderText="edit"></asp:TemplateField>
                   
                   <asp:TemplateField HeaderText="delete"></asp:TemplateField>
                     </Columns>
                   </asp:GridView>
                    </td>
                    </tr>
            </table>
        </div>
    </form>
</body>
</html>