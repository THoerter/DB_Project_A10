Public Class FormStaffInfo
   Private workDataView As New DataView()
   Private qualDataView As New DataView()
   Private staffBindingSource As New BindingSource
   Private qualBindingSource As New BindingSource
   Private workBindingSource As New BindingSource

   Private Sub FormStaffInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      staffBindingSource.DataSource = Oracle.UWP_Staff

      txtStaffNo.DataBindings.Add("Text", staffBindingSource, "staffNo")
      txtFirstName.DataBindings.Add("Text", staffBindingSource, "fName")
      txtLastName.DataBindings.Add("Text", staffBindingSource, "lName")
      txtStreet.DataBindings.Add("Text", staffBindingSource, "street")
      txtCity.DataBindings.Add("Text", staffBindingSource, "city")
      txtState.DataBindings.Add("Text", staffBindingSource, "state")
      txtZip.DataBindings.Add("Text", staffBindingSource, "zip")
      txtPhone.DataBindings.Add("Text", staffBindingSource, "phone")
      DTPickDOB.DataBindings.Add("Text", staffBindingSource, "DOB")
      txtGender.DataBindings.Add("Text", staffBindingSource, "gender")
      txtNIN.DataBindings.Add("Text", staffBindingSource, "NIN")
      txtBoxPosition.DataBindings.Add("Text", staffBindingSource, "position")
      txtCurSalary.DataBindings.Add("Text", staffBindingSource, "curSalary")
      txtSalaryScale.DataBindings.Add("Text", staffBindingSource, "salaryScale")
      txtHrsPerWk.DataBindings.Add("Text", staffBindingSource, "hrsPerWk")
      txtPositionType.DataBindings.Add("Text", staffBindingSource, "posPermTemp")
      txtPayType.DataBindings.Add("Text", staffBindingSource, "typeOfPay")

      qualDataView.Table = Oracle.UWP_Qualifications
      qualBindingSource.DataSource = qualDataView

      DTPickQualDate.DataBindings.Add("Text", qualBindingSource, "qualDate")
      txtQualType.DataBindings.Add("Text", qualBindingSource, "type")
      txtQualInst.DataBindings.Add("Text", qualBindingSource, "instName")

      workDataView.Table = Oracle.UWP_WorkExperience
      workBindingSource.DataSource = workDataView

      txtOrgName.DataBindings.Add("Text", workBindingSource, "orgName")
      txtWorkPosition.DataBindings.Add("Text", workBindingSource, "position")
      DTPickStartDate.DataBindings.Add("Text", workBindingSource, "startDate")
      DTPickEndDate.DataBindings.Add("Text", workBindingSource, "finishDate")

      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"

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

      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
   End Sub

   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      If CBoxFieldSel.Text = "type" Then
         Oracle.qualCommand.CommandText =
            "Select * " &
            "From UWP_Qualifications " &
            "Where " & CBoxFieldSel.Text & "= '" & txtValForSearch.Text & "'"
         MessageBox.Show(Oracle.qualCommand.CommandText)
      ElseIf CBoxFieldSel.Text = "orgName" Then
         Oracle.workCommand.CommandText =
            "Select * " &
            "From UWP_WorkExperience " &
            "Where " & CBoxFieldSel.Text & "= '" & txtValForSearch.Text & "'"
         MessageBox.Show(Oracle.workCommand.CommandText)
      Else
         Oracle.staffCommand.CommandText = "You haven't selected a field or a value!"
      End If

      Try
         Oracle.workTable.Clear()
         Oracle.myTable.Clear()
         Oracle.qualTable.Clear()
         Oracle.qualAdapter.Fill(Oracle.qualTable)
         Oracle.workAdapter.Fill(Oracle.workTable)
         Oracle.staffAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
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
      btnPreviousEmpl.Enabled = True
      btnNextEmpl.Enabled = True
      btnToEndEmpl.Enabled = True
      btnToBeginningEmpl.Enabled = True
      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      staffBindingSource.MoveNext()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      If txtEmplIDDisplay.Text.Substring(0, 1).Equals(txtEmplIDDisplay.Text.Substring(2, 1)) Then
         btnNextEmpl.Enabled = False
         btnToEndEmpl.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
   End Sub

   Private Sub btnPreviousEmpl_Click(sender As Object, e As EventArgs) Handles btnPreviousEmpl.Click
      btnPreviousEmpl.Enabled = True
      btnNextEmpl.Enabled = True
      btnToEndEmpl.Enabled = True
      btnToBeginningEmpl.Enabled = True
      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      staffBindingSource.MovePrevious()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

      If txtEmplIDDisplay.Text.Substring(0, 1).Equals("1") Then
         btnPreviousEmpl.Enabled = False
         btnToBeginningEmpl.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
   End Sub

   Private Sub btnToEndEmpl_Click(sender As Object, e As EventArgs) Handles btnToEndEmpl.Click
      btnToEndEmpl.Enabled = False
      btnNextEmpl.Enabled = False
      btnPreviousEmpl.Enabled = True
      btnToBeginningEmpl.Enabled = True
      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      staffBindingSource.MoveLast()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
   End Sub

   Private Sub btnToBeginningEmpl_Click(sender As Object, e As EventArgs) Handles btnToBeginningEmpl.Click
      btnToEndEmpl.Enabled = True
      btnNextEmpl.Enabled = True
      btnPreviousEmpl.Enabled = False
      btnToBeginningEmpl.Enabled = False
      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      staffBindingSource.MoveFirst()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("0") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
      If txtQualNoDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
      If txtWorkExDisplay.Text.Substring(2, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
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
      btnPreviousQual.Enabled = True
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnToBeginningQual.Enabled = True

      qualBindingSource.MoveNext()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

      If txtQualNoDisplay.Text.Substring(0, 1).Equals(txtQualNoDisplay.Text.Substring(2, 1)) Then
         btnNextQual.Enabled = False
         btnToEndQual.Enabled = False
      End If
   End Sub

   Private Sub btnPreviousQual_Click(sender As Object, e As EventArgs) Handles btnPreviousQual.Click
      btnPreviousQual.Enabled = True
      btnNextQual.Enabled = True
      btnToEndQual.Enabled = True
      btnToBeginningQual.Enabled = True
      qualBindingSource.MovePrevious()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      If txtQualNoDisplay.Text.Substring(0, 1).Equals("1") Then
         btnPreviousQual.Enabled = False
         btnToBeginningQual.Enabled = False
      End If
   End Sub

   Private Sub btnToEndQual_Click(sender As Object, e As EventArgs) Handles btnToEndQual.Click
      btnToEndQual.Enabled = False
      btnNextQual.Enabled = False
      btnPreviousQual.Enabled = True
      btnToBeginningQual.Enabled = True
      qualBindingSource.MoveLast()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'" 'And "type = '" & txtQualType.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

   End Sub

   Private Sub btnToBeginningQual_Click(sender As Object, e As EventArgs) Handles btnToBeginningQual.Click
      btnToEndQual.Enabled = True
      btnNextQual.Enabled = True
      btnPreviousQual.Enabled = False
      btnToBeginningQual.Enabled = False
      qualBindingSource.MoveFirst()
      qualDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

   End Sub

   Private Sub btnNextWork_Click(sender As Object, e As EventArgs) Handles btnNextWork.Click
      btnPreviousWork.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      btnToBeginningWork.Enabled = True
      workBindingSource.MoveNext()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count

      If txtWorkExDisplay.Text.Substring(0, 1).Equals(txtWorkExDisplay.Text.Substring(2, 1)) Then
         btnNextWork.Enabled = False
         btnToEndWork.Enabled = False
      End If
   End Sub

   Private Sub btnPreviousWork_Click(sender As Object, e As EventArgs) Handles btnPreviousWork.Click
      btnPreviousWork.Enabled = True
      btnNextWork.Enabled = True
      btnToEndWork.Enabled = True
      btnToBeginningWork.Enabled = True
      workBindingSource.MovePrevious()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
      If txtWorkExDisplay.Text.Substring(0, 1).Equals("1") Then
         btnPreviousWork.Enabled = False
         btnToBeginningWork.Enabled = False
      End If
   End Sub

   Private Sub btnToEndWork_Click(sender As Object, e As EventArgs) Handles btnToEndWork.Click
      btnToEndWork.Enabled = False
      btnNextWork.Enabled = False
      btnPreviousWork.Enabled = True
      btnToBeginningWork.Enabled = True
      workBindingSource.MoveLast()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
   End Sub

   Private Sub btnToBeginningWork_Click(sender As Object, e As EventArgs) Handles btnToBeginningWork.Click
      btnToEndWork.Enabled = True
      btnNextWork.Enabled = True
      btnPreviousWork.Enabled = False
      btnToBeginningWork.Enabled = False
      workBindingSource.MoveFirst()
      workDataView.RowFilter = "staffNo = '" & txtStaffNo.Text & "'"
      txtEmplIDDisplay.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      txtQualNoDisplay.Text = (qualBindingSource.Position + 1) & "/" & qualBindingSource.Count
      txtWorkExDisplay.Text = (workBindingSource.Position + 1) & "/" & workBindingSource.Count
   End Sub

   Private Sub btnSaveEmpl_Click(sender As Object, e As EventArgs) Handles btnSaveEmpl.Click
      Try
         staffBindingSource.EndEdit()
         Oracle.staffAdapter.Update(Oracle.UWP_Staff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
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