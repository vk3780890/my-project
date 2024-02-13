<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Password.ascx.cs" Inherits="Gmail.Password" %>

<script>
    function togglePasswordVisibility() {
        var password= document.getElementById('<%=PasswordText.ClientID%>');
       // var showPasswordIcon = document.getElementById('ShowPassword');
        if (password.type === 'PasswordText') {
            password.type = 'text'; 
            //showPasswordIcon.innerHTML = '&#x1F440;'; 
        } else {
            password.type = 'PasswordText'; 
           // showPasswordIcon.innerHTML = '&#x1F441;'; 

        }
    }

</script>
<table> 
  <tr>
      
      <td>
          <asp:TextBox ID="PasswordText" runat="server"></asp:TextBox>
  
      </td>
  </tr>

    </table>
