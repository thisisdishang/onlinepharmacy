﻿<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Medicine.aspx.vb" Inherits="Medicine" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
Medicine
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">
        
        <div align="center">
            <br /><br />
            <asp:Panel ID="Panel1" runat="server" BackColor="RoyalBlue" Height="50px">
            <div align="center" style="height: 40px" >
            <asp:Label ID="Label2" runat="server" Text="Medicine" ForeColor="White" 
                Font-Size="XX-Large" Font-Underline="True"></asp:Label>
            </div>
            </asp:Panel>
        </div>
    <br />
    <div class="container">
       
        <div class="row">
            <div class="col-sm-6"> 
                            
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Medicine Details:-" 
                Font-Size="18pt" ForeColor="RoyalBlue"></asp:Label>                             
                              
                <br /><br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="MedName" runat="server" Width="221px" placeholder="Medicine Name" AutoComplete="off"></asp:TextBox>
                <br /><br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="MedB" 
                     runat="server" Width="221px" placeholder="Buying Price" AutoComplete="off"></asp:TextBox>
                <br /><br />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="MedS" 
                     runat="server" Width="221px" placeholder="Selling Price" AutoComplete="off"></asp:TextBox>
                <br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="MedQty" 
                     runat="server" Width="221px" placeholder="Quantity" AutoComplete="off"></asp:TextBox>
                <br /><br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="MedDate" 
                     runat="server" Width="221px" placeholder="Date" AutoComplete="off"></asp:TextBox>
                <br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:DropDownList ID="MedCB" runat="server" Width="221px">
                   
                 </asp:DropDownList>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                 <br /><br />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" Text="Save" BackColor="RoyalBlue" 
                     Font-Bold="True" ForeColor="White" Height="30px" Width="72px" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button2" runat="server" Text="Edit" BackColor="RoyalBlue" 
                     Font-Bold="True" ForeColor="White" Height="30px" Width="72px" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button3" runat="server" Text="Remove" BackColor="RoyalBlue" 
                     Font-Bold="True" ForeColor="White" Height="30px" Width="72px" />
                 <br /><br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button4" runat="server" Text="Search" BackColor="RoyalBlue" 
                     Font-Bold="True" ForeColor="White" Height="30px" Width="72px" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Button5" runat="server" Text="Reset" BackColor="RoyalBlue" 
                     Font-Bold="True" ForeColor="White" Height="30px" Width="72px" />                 
                 
            </div>
            <div class="col-sm-5" align="center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Medicine List:-" 
                Font-Size="18pt" ForeColor="RoyalBlue"></asp:Label>                               
                                            
                <asp:GridView ID="MedicineGV" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" Width="490px" Height="160px">
                    <RowStyle BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
              
            </div>        
        </div>        
    </div> 
</asp:Content>

