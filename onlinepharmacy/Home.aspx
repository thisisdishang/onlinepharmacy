<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="_Default" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #Password1
        {
            width: 249px;
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">
    <div class="container" align="center">   
            <div class="row">
            <div class="col">
        <br /><br />  
        <asp:Label ID="Label1" runat="server" Text="Welcome To Genesis Pharmacy" 
            Font-Size="20pt" Font-Underline="True" ForeColor="RoyalBlue" 
            Font-Bold="True">
        </asp:Label>
        <br /><br />
        <br /><br /> 
        <asp:Label ID="Label2" runat="server" Text="Login" Font-Size="X-Large" 
            ForeColor="RoyalBlue"></asp:Label>
        <br /><br />        
        <table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <tr>
               <asp:TextBox ID="User" runat="server" Width="252px" Placeholder="Username" 
            Height="28px" AutoComplete="off"></asp:TextBox>&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="User" ErrorMessage="RequiredFieldValidator">Please Enter 
        Username</asp:RequiredFieldValidator>               
            </tr>
        <br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <tr>
            <asp:TextBox ID="Pass" runat="server" Width="252px" Placeholder="Password" 
            Height="28px" TextMode="Password" AutoComplete="off"></asp:TextBox>&nbsp;&nbsp;&nbsp;
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="Pass" ErrorMessage="RequiredFieldValidator">Please 
        Enter Password</asp:RequiredFieldValidator>             
        </tr>            
         <br /><br />
         <tr>
          <asp:DropDownList
             ID="LoginCB" runat="server" Height="28px" Width="252px">
             <asp:ListItem Selected="True">Select User Type</asp:ListItem>
             <asp:ListItem>Admin</asp:ListItem>
             <asp:ListItem>Other</asp:ListItem>
         </asp:DropDownList>       
         </tr>
        <br /><br /> 
        <tr>
            <asp:Button ID="Button1" runat="server" Text="Login" BackColor="RoyalBlue" 
                BorderStyle="None" ForeColor="White" Height="30px" Width="72px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;          
        
                <asp:Button ID="Button2" runat="server" Text="Reset" BackColor="RoyalBlue" 
                BorderStyle="None" ForeColor="White" Height="30px" Width="72px" />
        </tr> 
        </table>
       </div>
       </div> 
       </div>
</asp:Content>


