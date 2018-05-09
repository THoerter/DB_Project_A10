'Imports System.Data.SqlClient
Public Class FormStaffInfo
   Private staffDataView As New DataView()
   Private workDataView As New DataView()
   Private qualDataView As New DataView()
   Private staffBindingSource As New BindingSource

   Private Sub FormStaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      staffDataView.Table = Oracle.UWP_Staff
      staffBindingSource.DataSource = staffDataView

      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "staffNo")
      txtFirstName.DataBindings.Add("Text", Oracle.UWP_Staff, "fName")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "lName")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "street")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "city")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "state")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "zip")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "phone")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "DOB")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "gender")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "NIN")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "position")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "curSalary")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "salaryScale")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "hrsPerWk")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "posPermTemp")
      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "typeOfPay")

   End Sub
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