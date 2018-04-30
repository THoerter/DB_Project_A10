Public Class FormClassBooking
   Private Sub FormClassBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' Binding it to myTable
      dgvBooking.DataSource = Oracle.myTable
   End Sub


   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub


   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      Dim field As String = cobField.Text
      Dim op As String = cobOperator.Text
      Dim value As String = txtValue.Text

      ' For Date values
      ' Could enter dates in different formats 
      ' Must Try-and-Catch!
      If field = "Date_From" Or field = "Date_To" Then

         Dim theDate As Date = value

         Oracle.bookingCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & field & op & "to_Date('" & theDate & "', 'mm/dd/yyyy')"
      Else
         ' For string values
         Oracle.bookingCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & field & op & " '" & value & "'"
      End If

      ' Check CommandText 
      MessageBox.Show(Oracle.bookingCommand.CommandText)

      ' Catch exception
      Try
         Oracle.myTable.Clear()
         Oracle.bookingAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub



   Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
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

   Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
      Try
         Me.BindingContext(Oracle.myTable).EndCurrentEdit()
         Oracle.bookingAdapter.Update(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

End Class
