Imports System.Data.OleDb
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") = Nothing And Session("pass") = Nothing Then
            Response.Redirect("Home.aspx")
        End If

        Dim str As String
        str = "select * from BillingTBL"
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dishangkumar\Documents\Visual Studio 2008\WebSites\genesispharma.accdb"
        cmd = New OleDbCommand(str, cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        BillingGV.DataSource = ds.Tables(0)
        BillingGV.DataBind()
        FillCombo()
    End Sub

    Public Sub FillCombo()
        Dim cmd As New OleDbCommand("select * from MedicineTBL", cn)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataTable()
        adp.Fill(ds)
        BillingCB.DataSource = ds
        BillingCB.DataValueField = "MedName"
        BillingCB.DataTextField = "MedName"
        BillingCB.DataBind()
    End Sub


    Public Sub getqty()
        cn.Open()
        Dim qry = "Select * from MedicineTBL where MedName='" & BillingCB.SelectedValue.ToString() & "'"
        Dim cmd As New OleDbCommand(qry, cn)
        Dim dt As New DataTable
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        While dr.Read
            astock.Text = dr.Item(3)
        End While
        cn.Close()
    End Sub

    Protected Sub BillingCB_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BillingCB.SelectedIndexChanged
        getqty()
    End Sub

    Protected Sub Bill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bill.Click
        'This Feature are coming soon...
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This Feature are coming soon...
    End Sub
End Class
