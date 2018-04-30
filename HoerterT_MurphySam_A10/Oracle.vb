Public Class Oracle
   Friend Shared UserName As String
   Friend Shared PassWd As String
   Friend Shared Server As String

   Friend Shared OracleConnection As New System.Data.OracleClient.OracleConnection

   Friend Shared bookingAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared bookingCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared bookingCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

   Friend Shared myTable As New System.Data.DataTable

   Public Shared Sub LogInAtRunTime()
      ' For testing 
      UserName = "yangq"
      PassWd = "cs3630"
      Server = "EDDB"

      OracleConnection.ConnectionString = "Data Source = " & Server & ";Persist Security Info=True;User ID=" & UserName & ";Password=" & PassWd & ";Unicode=True"

      bookingCommand.CommandType = CommandType.Text
      bookingCommand.CommandText = "Select * from booking"
      bookingCommand.Connection = OracleConnection

      bookingAdapter.SelectCommand = bookingCommand
      bookingCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(bookingAdapter)

      bookingAdapter.Fill(myTable)
   End Sub

   Public Shared Sub main()
      LogInAtRunTime()

      Application.Run(New FormClassBooking)
   End Sub

End Class