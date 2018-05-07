Public Class FormClassLogin
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Oracle.UserName = TextBox1.Text
      Oracle.PassWd = TextBox2.Text
      Oracle.Server = TextBox3.Text

      Oracle.Result = Oracle.ResponseType.OK

      Me.Close()

   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      Oracle.Result = Oracle.ResponseType.Cancel

      Me.Close()

   End Sub

End Class