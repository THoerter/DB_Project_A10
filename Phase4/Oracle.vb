Public Class Oracle
   Friend Shared UWP_Staff As New System.Data.DataTable("UWP_Staff")
   Friend Shared UWP_WorkExperience As New System.Data.DataTable("UWP_WorkExperience")
   Friend Shared UWP_Qualifications As New System.Data.DataTable("UWP_Qualifications")

   Public Enum ResponseType
      OK
      Cancel
   End Enum


   Friend Shared Result As ResponseType

   Friend Shared frmLogin As New FormClassLogin
   Private Shared frmStaffInfo As New FormStaffInfo

   Friend Shared UserName As String
   Friend Shared PassWd As String
   Friend Shared Server As String


   Friend Shared OracleConnection As New System.Data.OracleClient.OracleConnection

   Friend Shared staffAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared staffCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared staffCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

   Friend Shared workAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared workCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared workCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

   Friend Shared qualAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared qualCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared qualCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

   Friend Shared myTable As New System.Data.DataTable



   Public Shared Sub LogInAtRunTime()
      ' For testing 
      'UserName = "yangq"
      'PassWd = "cs3630"
      'Server = "EDDB"

      OracleConnection.ConnectionString = "Data Source = " & Server & ";Persist Security Info=True;User ID=" & UserName & ";Password=" & PassWd & ";Unicode=True"

      staffCommand.CommandType = CommandType.Text
      staffCommand.CommandText = "Select * from UWP_Staff"
      staffCommand.Connection = OracleConnection
      staffAdapter.SelectCommand = staffCommand
      staffCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(staffAdapter)
      staffAdapter.Fill(UWP_Staff)

      workCommand.CommandType = CommandType.Text
      workCommand.CommandText = "Select * from UWP_WorkExperience"
      workCommand.Connection = OracleConnection
      workAdapter.SelectCommand = workCommand
      workCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(workAdapter)
      workAdapter.Fill(UWP_WorkExperience)

      qualCommand.CommandType = CommandType.Text
      qualCommand.CommandText = "Select * from UWP_Qualifications"
      qualCommand.Connection = OracleConnection
      qualAdapter.SelectCommand = qualCommand
      qualCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(qualAdapter)
      qualAdapter.Fill(UWP_Qualifications)
   End Sub

   Public Shared Sub main()
      'LogInAtRunTime()

      'Application.Run(New FormClassBooking)
      Dim connected As Boolean

      While Not connected
         frmLogin.ShowDialog()
         If Result = ResponseType.Cancel Then
            Exit While
         End If

         Try
            LogInAtRunTime()
            connected = True
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
      End While

      If connected Then
         Application.Run(frmStaffInfo)
         frmStaffInfo.LoadInfo()
      End If
   End Sub
End Class