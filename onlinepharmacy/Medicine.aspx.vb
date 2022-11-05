Imports System.Data.OleDb
Imports System.Data

Partial Class Medicine
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
        str = "select * from MedicineTBL"
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dishangkumar\Documents\Visual Studio 2008\WebSites\genesispharma.accdb"
        cmd = New OleDbCommand(str, cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        MedicineGV.DataSource = ds.Tables(0)
        MedicineGV.DataBind()
        FillCombo()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        reset()
    End Sub

    Public Sub reset()
        MedName.Text = ""
        MedB.Text = ""
        MedS.Text = ""
        MedQty.Text = ""
        MedDate.Text = ""
        MedCB.SelectedIndex = -1
    End Sub

    Public Sub FillCombo()
        Dim cmd As New OleDbCommand("select * from CompanyTBL", cn)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataTable()
        adp.Fill(ds)
        MedCB.DataSource = ds
        MedCB.DataTextField = "CompName"
        MedCB.DataValueField = "CompName"
        MedCB.DataBind()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Delete
        Try
            If MedName.Text = "" Then
                MsgBox("Please Select Details!", MsgBoxStyle.Information, "Enter Medicine Name")
            Else
                cn.Open()
                Dim str As String
                str = "delete from MedicineTBL where MedName='" & MedName.Text & "'"
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Remove Successfully", MsgBoxStyle.Information, "Remove")
                reset()
            End If
        Catch ex As Exception
            MsgBox("Missing Details!!!")
        End Try
        cn.Close()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Insert
        Try
            cn.Open()
            Dim str As String
            str = "insert into MedicineTBL values('" & MedName.Text & "'," & MedB.Text & "," & MedS.Text & "," & MedQty.Text & ",'" & MedDate.Text & "','" & MedCB.SelectedValue.ToString & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Save Successfully", MsgBoxStyle.Information, "Save")
            reset()
        Catch ex As Exception
            MsgBox("Missing Details!!!")
        End Try
        cn.Close()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Update
        Try
            cn.Open()
            Dim str As String
            str = "update MedicineTBL set Bprice=" & MedB.Text & ",Sprice=" & MedS.Text & ",MedQty=" & MedQty.Text & ",ExpDate='" & MedDate.Text & "',CompName='" & MedCB.SelectedValue.ToString & "' where MedName='" & MedName.Text & "'"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Edit Successfully", MsgBoxStyle.Information, "Edit")
            reset()
        Catch ex As Exception
            MsgBox("Missing Details!!!")
        End Try
        cn.Close()
    End Sub
    
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Select
        Try
            cn.Open()
            cmd = New OleDbCommand("select * from MedicineTBL where MedName='" & MedName.Text & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                MedB.Text = dr.Item(1)
                MedS.Text = dr.Item(2)
                MedQty.Text = dr.Item(3)
                MedDate.Text = dr.Item(4)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub
  
End Class
