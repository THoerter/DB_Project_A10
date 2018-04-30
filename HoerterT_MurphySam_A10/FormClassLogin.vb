Public Class FormClassLogin
   Private Sub AcceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptButton.Click
      Oracle.UserName = TextBox1.Text
      Oracle.PassWd = TextBox2.Text
      Oracle.Server = TextBox3.Text

      Oracle.Result = Oracle.ResponseType.OK

      Me.Close()
   End Sub

   Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
      Oracle.Result = Oracle.ResponseType.Cancel

      Me.Close()
   End Sub

End Class