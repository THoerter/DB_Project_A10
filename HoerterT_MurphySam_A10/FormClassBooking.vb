Public Class Form1
   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      '   Sql Query

      '   Select Case*
      '   From Booking
      '   Where SearchCondition

      'VB.NET
      Dim field As String = cobField.Text
      Dim op As String = cobOperator.Text
      Dim value As String = txtValue.Text

         ' For string values
         Oracle.bookingCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & field & op & " '" & value & "'"


         ' For Date values
         ' Could enter dates in different formats 
         ' Must Try-and-Catch!
         Dim theDate As Date = value

         Oracle.bookingCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & field & op & "to_Date('" & theDate & "', 'mm/dd/yyyy')"
         ' Check CommandText 
         MessageBox.Show(Oracle.bookingCommand.CommandText)

         ' For All
         Oracle.bookingCommand.CommandText = "Select * from booking"

         ' Catch exception
         Try
            Oracle.myTable.Clear()
            Oracle.bookingAdapter.Fill(Oracle.myTable)
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try

   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub
End Class
