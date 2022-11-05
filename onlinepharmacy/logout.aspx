<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="logout.aspx.vb" Inherits="_Default" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">
    <div class="container" align="center">   
        <div class="row">
        <div class="col">
        <br /><br />  
        <br /><br />
        <br /><br />
        <br /><br />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Are You Sure To Want To Logout???" 
            Font-Size="20pt" ForeColor="RoyalBlue" 
            Font-Bold="True">
        </asp:Label>
        <br /><br />            
        <table>     
        <tr>
            <asp:Button ID="logoutyes" runat="server" Text="Yes" BackColor="RoyalBlue" 
                BorderStyle="None" ForeColor="White" Height="30px" Width="72px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;          
        
                <asp:Button ID="logoutno" runat="server" Text="No" BackColor="RoyalBlue" 
                BorderStyle="None" ForeColor="White" Height="30px" Width="72px" />
        </tr> 
        </table>
       </div>
       </div> 
       </div>
</asp:Content>

