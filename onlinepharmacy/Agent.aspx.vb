Imports System.Data.OleDb
Imports System.Data

Partial Class Default2
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim dr As OleDbDataReader
    Dim ds As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") = Nothing And Session("pass") = Nothing Then
            Response.Redirect("Home.aspx")
        End If

        If Not (Session("user") = "admin") And Not (Session("pass") = "admin") Then
            MsgBox("You Can Not Access This Page!", MsgBoxStyle.Exclamation, "Warning")
            Response.Redirect("Medicine.aspx")
        End If

        If Session("user") = "admin" And Session("pass") = "admin" Then
            Dim str As String
            str = "select * from AgentTBL"
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dishangkumar\Documents\Visual Studio 2008\WebSites\genesispharma.accdb"
            cmd = New OleDbCommand(str, cn)
            adp = New OleDbDataAdapter(cmd)
            adp.Fill(ds)
            AgentGV.DataSource = ds.Tables(0)
            AgentGV.DataBind()
        End If
    End Sub


    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        reset()
    End Sub


    Public Sub reset()
        Empid.Text = ""
        Empname.Text = ""
        Empage.Text = ""
        Empphn.Text = ""
        Empsal.Text = ""
        Emppass.Text = ""
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Delete
        Try
            If Empid.Text = "" Then
                MsgBox("Select Details")
            Else
                cn.Open()
                Dim str As String
                str = "delete from AgentTBL where Empid=" & Empid.Text & ""
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


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Insert 
        Try
            cn.Open()
            Dim str As String
            str = "insert into AgentTBL values(" & Empid.Text & ",'" & Empname.Text & "'," & Empage.Text & "," & Empsal.Text & "," & Empphn.Text & ",'" & Emppass.Text & "')"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Save Successfully", MsgBoxStyle.Information, "Save")
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
            cmd = New OleDbCommand("select * from AgentTBL where Empid=" & Empid.Text & "", cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Empname.Text = dr.Item(1)
                Empage.Text = dr.Item(2)
                Empsal.Text = dr.Item(3)
                Empphn.Text = dr.Item(4)
                Emppass.Text = dr.Item(5)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, , "Record Not Found")
        End Try
        cn.Close()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Update
        Try
            cn.Open()
            Dim str As String
            str = "update AgentTBL set EmpName='" & Empname.Text & "',EmpAge=" & Empage.Text & ",EmpSalary=" & Empsal.Text & ",EmpPhn=" & Empphn.Text & ",EmpPass='" & Emppass.Text & "' where Empid=" & Empid.Text & ""
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Edit Successfully", MsgBoxStyle.Information, "Edit")
            reset()
        Catch ex As Exception
            MsgBox("Missing Details")
        End Try
        cn.Close()
    End Sub
End Class
