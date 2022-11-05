
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub logoutyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logoutyes.Click
        Session.Remove("user")
        Session.Remove("pass")
        Session.RemoveAll()
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub logoutno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logoutno.Click
        Response.Redirect("Medicine.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") = Nothing And Session("pass") = Nothing Then
            Response.Redirect("Home.aspx")
        End If
    End Sub
End Class
