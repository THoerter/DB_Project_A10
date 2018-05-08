'Imports System.Data.SqlClient
Public Class FormStaffInfo
   Public Sub LoadInfo()

   End Sub
   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      Dim field As String = CBoxFieldSel.Text
      Dim value As String = txtValForSearch.Text

      If field = "Type" Then
         Oracle.staffCommand.CommandText =
            "Select * " &
            "From UWP_Qualifications " &
            "Where type = '" & value & "'"
      ElseIf field = "Org Name" Then
         Oracle.staffCommand.CommandText =
            "Select * " &
            "From UWP_WorkExperience " &
            "Where orgName = '" & value & "'"
      Else
         Oracle.staffCommand.CommandText = "You haven't selected a field or a value!"
      End If
      'Check CommandText
      MessageBox.Show(Oracle.staffCommand.CommandText)

      'Catch Exception
      Try
         Oracle.myTable.Clear()
         Oracle.staffAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
      Try
         Me.BindingContext(Oracle.myTable).EndCurrentEdit()
         Oracle.staffAdapter.Update(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub
End Class