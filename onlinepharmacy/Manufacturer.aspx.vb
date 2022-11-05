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
        str = "select * from CompanyTBL"
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dishangkumar\Documents\Visual Studio 2008\WebSites\genesispharma.accdb"
        cmd = New OleDbCommand(str, cn)
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds)
        ManufacturerGV.DataSource = ds.Tables(0)
        ManufacturerGV.DataBind()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        reset()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Insert 
        Try
            cn.Open()
            Dim str As String
            str = "insert into CompanyTBL values(" & cid.Text & ",'" & cname.Text & "'," & cphn.Text & ",'" & ccity.Text & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Save Successfully", MsgBoxStyle.Information, "Save")
            reset()
        Catch ex As Exception
            MsgBox("Missing Details!!!")
        End Try
        cn.Close()
    End Sub

    Public Sub reset()
        cid.Text = ""
        cname.Text = ""
        cphn.Text = ""
        ccity.Text = ""
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Update
        Try
            cn.Open()
            Dim str As String
            str = "update CompanyTBL set CompName='" & cname.Text & "',CompPhone='" & cphn.Text & "',CompCity='" & ccity.Text & "' where Compid=" & cid.Text & ""
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Edit Successfully", MsgBoxStyle.Information, "Edit")
            reset()
        Catch ex As Exception
            MsgBox("Missing Details")
        End Try
        cn.Close()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Delete
        Try
            If cid.Text = "" Then
                MsgBox("Select Details")
            Else
                cn.Open()
                Dim str As String
                str = "delete from CompanyTBL where Compid=" & cid.Text & ""
                cmd = New OleDbCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Remove Successfully", MsgBoxStyle.Information, "Remove")
                reset()
            End If
        Catch ex As Exception
            MsgBox("Missing Details")
        End Try
        cn.Close()
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Select
        Try
            cn.Open()
            cmd = New OleDbCommand("select * from CompanyTBL where Compid=" & cid.Text & "", cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cname.Text = dr.Item(1)
                cphn.Text = dr.Item(2)
                ccity.Text = dr.Item(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub
End Class
