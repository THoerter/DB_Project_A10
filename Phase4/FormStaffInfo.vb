'Imports System.Data.SqlClient
Public Class FormStaffInfo
   'Private staffDataView As New DataView()
   Private workDataView As New DataView()
   Private qualDataView As New DataView()
   Private staffBindingSource As New BindingSource
   Private qualBindingSource As New BindingSource
   Private workBindingSource As New BindingSource

   Private Sub FormStaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'staffDataView.Table = 
      staffBindingSource.DataSource = Oracle.UWP_Staff

      txtStaffNo.DataBindings.Add("Text", Oracle.UWP_Staff, "staffNo")
      txtFirstName.DataBindings.Add("Text", Oracle.UWP_Staff, "fName")
      txtLastName.DataBindings.Add("Text", Oracle.UWP_Staff, "lName")
      txtStreet.DataBindings.Add("Text", Oracle.UWP_Staff, "street")
      txtCity.DataBindings.Add("Text", Oracle.UWP_Staff, "city")
      txtState.DataBindings.Add("Text", Oracle.UWP_Staff, "state")
      txtZip.DataBindings.Add("Text", Oracle.UWP_Staff, "zip")
      txtPhone.DataBindings.Add("Text", Oracle.UWP_Staff, "phone")
      DTPickDOB.DataBindings.Add("Text", Oracle.UWP_Staff, "DOB")
      txtGender.DataBindings.Add("Text", Oracle.UWP_Staff, "gender")
      txtNIN.DataBindings.Add("Text", Oracle.UWP_Staff, "NIN")
      txtBoxPosition.DataBindings.Add("Text", Oracle.UWP_Staff, "position")
      txtCurSalary.DataBindings.Add("Text", Oracle.UWP_Staff, "curSalary")
      txtSalaryScale.DataBindings.Add("Text", Oracle.UWP_Staff, "salaryScale")
      txtHrsPerWk.DataBindings.Add("Text", Oracle.UWP_Staff, "hrsPerWk")
      txtPositionType.DataBindings.Add("Text", Oracle.UWP_Staff, "posPermTemp")
      txtPayType.DataBindings.Add("Text", Oracle.UWP_Staff, "typeOfPay")

      qualDataView.Table = Oracle.UWP_Qualifications
      qualBindingSource.DataSource = qualDataView

      DTPickQualDate.DataBindings.Add("Text", Oracle.UWP_Qualifications, "qualDate")
      txtQualType.DataBindings.Add("Text", Oracle.UWP_Qualifications, "type")
      txtQualInst.DataBindings.Add("Text", Oracle.UWP_Qualifications, "instName")

      workDataView.Table = Oracle.UWP_WorkExperience
      workBindingSource.DataSource = workDataView

      txtOrgName.DataBindings.Add("Text", Oracle.UWP_WorkExperience, "orgName")
      txtWorkPosition.DataBindings.Add("Text", Oracle.UWP_WorkExperience, "position")
      DTPickStartDate.DataBindings.Add("Text", Oracle.UWP_WorkExperience, "startDate")
      DTPickEndDate.DataBindings.Add("Text", Oracle.UWP_WorkExperience, "finishDate")

      'staffDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "orgName = '" & txtOrgName.Text & "'" And "startDate = '" & DTPickStartDate.Text & "'"
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"

      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

      DTPickDOB.Format = DateTimePickerFormat.Custom
      DTPickDOB.CustomFormat = "M/dd/yyyy"

      DTPickEndDate.Format = DateTimePickerFormat.Custom
      DTPickEndDate.CustomFormat = "M/dd/yyyy"

      DTPickQualDate.Format = DateTimePickerFormat.Custom
      DTPickQualDate.CustomFormat = "M/dd/yyyy"

      DTPickStartDate.Format = DateTimePickerFormat.Custom
      DTPickStartDate.CustomFormat = "M/dd/yyyy"

   End Sub
   'Public Sub LoadInfo()

   'End Sub
   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      Dim field As String = CBoxFieldSel.Text
      Dim value As String = txtValForSearch.Text

      If field = "Type" Then
         Oracle.qualCommand.CommandText =
            "Select * " &
            "From UWP_Qualifications " &
            "Where type = '" & value & "'"
         Try
            Oracle.myTable.Clear()
            Oracle.qualAdapter.Fill(Oracle.myTable)
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
         MessageBox.Show(Oracle.qualCommand.CommandText)

      ElseIf field = "Org Name" Then
         Oracle.workCommand.CommandText =
            "Select * " &
            "From UWP_WorkExperience " &
            "Where orgName = '" & value & "'"
         Try
            Oracle.myTable.Clear()
            Oracle.workAdapter.Fill(Oracle.myTable)
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
         MessageBox.Show(Oracle.workCommand.CommandText)

      Else
         Oracle.staffCommand.CommandText = "You haven't selected a field or a value!"
      End If
      'Check CommandText
      'MessageBox.Show(Oracle.staffCommand.CommandText)

      'Catch Exception
      'Try
      '      Oracle.myTable.Clear()
      'Oracle.workAdapter.Fill(Oracle.myTable)
      'Catch ex As Exception
      '      MessageBox.Show(ex.Message)
      'End Try
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

   Private Sub btnNextEmpl_Click(sender As Object, e As EventArgs) Handles btnNextEmpl.Click
      staffBindingSource.MoveNext()
      'staffDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
   End Sub

   Private Sub btnPreviousEmpl_Click(sender As Object, e As EventArgs) Handles btnPreviousEmpl.Click
      staffBindingSource.MovePrevious()
      'staffDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
   End Sub

   Private Sub btnToEndEmpl_Click(sender As Object, e As EventArgs) Handles btnToEndEmpl.Click
      staffBindingSource.MoveLast()
      'staffDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
   End Sub

   Private Sub btnToBeginningEmpl_Click(sender As Object, e As EventArgs) Handles btnToBeginningEmpl.Click
      staffBindingSource.MoveFirst()
      'staffDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
   End Sub

   Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
      Try
         staffBindingSource.EndEdit()
         Oracle.staffAdapter.Update(Oracle.UWP_Staff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      Try
         qualBindingSource.EndEdit()
         Oracle.qualAdapter.Update(Oracle.UWP_Qualifications)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      Try
         workBindingSource.EndEdit()
         Oracle.workAdapter.Update(Oracle.UWP_WorkExperience)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub btnNewEmpl_Click(sender As Object, e As EventArgs) Handles btnNewEmpl.Click
      Dim r As DataRow

      r = Oracle.UWP_Staff.NewRow
      Oracle.UWP_Staff.Rows.Add(r)
      staffBindingSource.MoveLast()

      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub btnNewQual_Click(sender As Object, e As EventArgs) Handles btnNewQual.Click
      Dim r As DataRow

      r = Oracle.UWP_Qualifications.NewRow
      Oracle.UWP_Qualifications.Rows.Add(r)
      qualBindingSource.MoveLast()

      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
   End Sub

   Private Sub btnNewWork_Click(sender As Object, e As EventArgs) Handles btnNewWork.Click
      Dim r As DataRow

      r = Oracle.UWP_WorkExperience.NewRow
      Oracle.UWP_WorkExperience.Rows.Add(r)
      workBindingSource.MoveLast()

      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
   End Sub

   Private Sub btnDeleteEmpl_Click(sender As Object, e As EventArgs) Handles btnDeleteEmpl.Click
      btnUpdate.PerformClick()

      Try
         staffBindingSource.RemoveCurrent()
         txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub btnDeleteQual_Click(sender As Object, e As EventArgs) Handles btnDeleteQual.Click

      Try
         qualBindingSource.RemoveCurrent()
         txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub btnDeleteWork_Click(sender As Object, e As EventArgs) Handles btnDeleteWork.Click

      Try
         workBindingSource.RemoveCurrent()
         txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub btnNextQual_Click(sender As Object, e As EventArgs) Handles btnNextQual.Click
      qualBindingSource.MoveNext()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"
   End Sub

   Private Sub btnPreviousQual_Click(sender As Object, e As EventArgs) Handles btnPreviousQual.Click
      qualBindingSource.MovePrevious()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"
   End Sub

   Private Sub btnToEndQual_Click(sender As Object, e As EventArgs) Handles btnToEndQual.Click
      qualBindingSource.MoveLast()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"

   End Sub

   Private Sub btnToBeginningQual_Click(sender As Object, e As EventArgs) Handles btnToBeginningQual.Click
      qualBindingSource.MoveFirst()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"

   End Sub

   Private Sub btnNextWork_Click(sender As Object, e As EventArgs) Handles btnNextWork.Click
      workBindingSource.MoveNext()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "orgName = '" & txtOrgName.Text & "'" And "startDate = '" & DTPickStartDate.Text & "'"
   End Sub

   Private Sub btnPreviousWork_Click(sender As Object, e As EventArgs) Handles btnPreviousWork.Click
      workBindingSource.MovePrevious()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "orgName = '" & txtOrgName.Text & "'" And "startDate = '" & DTPickStartDate.Text & "'"
   End Sub

   Private Sub btnToEndWork_Click(sender As Object, e As EventArgs) Handles btnToEndWork.Click
      workBindingSource.MoveLast()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "orgName = '" & txtOrgName.Text & "'" And "startDate = '" & DTPickStartDate.Text & "'"
   End Sub

   Private Sub btnToBeginningWork_Click(sender As Object, e As EventArgs) Handles btnToBeginningWork.Click
      workBindingSource.MoveFirst()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "orgName = '" & txtOrgName.Text & "'" And "startDate = '" & DTPickStartDate.Text & "'"
   End Sub

   Private Sub btnSaveEmpl_Click(sender As Object, e As EventArgs) Handles btnSaveEmpl.Click
      Dim r As DataRowView
      r = staffBindingSource.AddNew
      r(0) = txtStaffNo.Text
      staffBindingSource.MoveLast()
   End Sub

   Private Sub btnSaveQual_Click(sender As Object, e As EventArgs) Handles btnSaveQual.Click
      Dim r As DataRowView
      r = qualBindingSource.AddNew
      r(0) = txtStaffNo.Text
      qualBindingSource.MoveLast()
   End Sub

   Private Sub btnSaveWork_Click(sender As Object, e As EventArgs) Handles btnSaveWork.Click
      Dim r As DataRowView
      r = workBindingSource.AddNew
      r(0) = txtStaffNo.Text
      workBindingSource.MoveLast()
   End Sub
End Class