Imports System.Data.OleDb
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim cn As New OleDbConnection

    Public Sub reset()
        User.Text = ""
        Pass.Text = ""
        LoginCB.SelectedIndex = -1
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Reset()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dishangkumar\Documents\Visual Studio 2008\WebSites\genesispharma.accdb"
        Session.Timeout = 5
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If User.Text = "admin" And Pass.Text = "admin" And LoginCB.SelectedValue = "Admin" Then
            Session("user") = User.Text
            Session("pass") = Pass.Text
            Response.Redirect("Medicine.aspx")
        Else
            cn.Open()
            Dim str As String
            str = "select * from AgentTBL where EmpName='" & User.Text & "' and EmpPass='" & Pass.Text & "'"
            Dim cmd = New OleDbCommand(str, cn)
            Dim adp = New OleDbDataAdapter(cmd)
            Dim ds = New DataSet
            adp.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Invalid Username Or Password!", MsgBoxStyle.Critical, "Not Found")
                reset()
            Else
                Session("user") = User.Text
                Session("pass") = Pass.Text
                If LoginCB.SelectedValue = "Other" Then
                    Response.Redirect("Medicine.aspx")
                Else
                    MsgBox("Please Select Proper User Type!", MsgBoxStyle.Exclamation, "Invalid User Type")
                    reset()
                End If
            End If
            cn.Close()
        End If
    End Sub
End Class
