<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClassBooking
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.dgvBooking = New System.Windows.Forms.DataGridView()
      Me.txtValue = New System.Windows.Forms.TextBox()
      Me.cobField = New System.Windows.Forms.ComboBox()
      Me.cobOperator = New System.Windows.Forms.ComboBox()
      Me.btnUpdate = New System.Windows.Forms.Button()
      Me.btnSearch = New System.Windows.Forms.Button()
      Me.btnAll = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgvBooking
      '
      Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvBooking.Location = New System.Drawing.Point(55, 55)
      Me.dgvBooking.Name = "dgvBooking"
      Me.dgvBooking.Size = New System.Drawing.Size(696, 332)
      Me.dgvBooking.TabIndex = 0
      '
      'txtValue
      '
      Me.txtValue.Location = New System.Drawing.Point(651, 414)
      Me.txtValue.Name = "txtValue"
      Me.txtValue.Size = New System.Drawing.Size(100, 20)
      Me.txtValue.TabIndex = 1
      '
      'cobField
      '
      Me.cobField.FormattingEnabled = True
      Me.cobField.Location = New System.Drawing.Point(55, 414)
      Me.cobField.Name = "cobField"
      Me.cobField.Size = New System.Drawing.Size(121, 21)
      Me.cobField.TabIndex = 2
      '
      'cobOperator
      '
      Me.cobOperator.FormattingEnabled = True
      Me.cobOperator.Items.AddRange(New Object() {">", ">=", "=", "<=", "<"})
      Me.cobOperator.Location = New System.Drawing.Point(382, 414)
      Me.cobOperator.Name = "cobOperator"
      Me.cobOperator.Size = New System.Drawing.Size(121, 21)
      Me.cobOperator.TabIndex = 3
      '
      'btnUpdate
      '
      Me.btnUpdate.Location = New System.Drawing.Point(790, 103)
      Me.btnUpdate.Name = "btnUpdate"
      Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
      Me.btnUpdate.TabIndex = 4
      Me.btnUpdate.Text = "&Update"
      Me.btnUpdate.UseVisualStyleBackColor = True
      '
      'btnSearch
      '
      Me.btnSearch.Location = New System.Drawing.Point(790, 182)
      Me.btnSearch.Name = "btnSearch"
      Me.btnSearch.Size = New System.Drawing.Size(75, 23)
      Me.btnSearch.TabIndex = 5
      Me.btnSearch.Text = "&Search"
      Me.btnSearch.UseVisualStyleBackColor = True
      '
      'btnAll
      '
      Me.btnAll.Location = New System.Drawing.Point(790, 271)
      Me.btnAll.Name = "btnAll"
      Me.btnAll.Size = New System.Drawing.Size(75, 23)
      Me.btnAll.TabIndex = 6
      Me.btnAll.Text = "&All"
      Me.btnAll.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(790, 364)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 7
      Me.btnExit.Text = "&Exit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'FormClassBooking
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.ClientSize = New System.Drawing.Size(905, 472)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnAll)
      Me.Controls.Add(Me.btnSearch)
      Me.Controls.Add(Me.btnUpdate)
      Me.Controls.Add(Me.cobOperator)
      Me.Controls.Add(Me.cobField)
      Me.Controls.Add(Me.txtValue)
      Me.Controls.Add(Me.dgvBooking)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Name = "FormClassBooking"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Assignment 10 - Samantha Murphy and Tanner Hoerter"
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents dgvBooking As DataGridView
   Friend WithEvents txtValue As TextBox
   Friend WithEvents cobField As ComboBox
   Friend WithEvents cobOperator As ComboBox
   Friend WithEvents btnUpdate As Button
   Friend WithEvents btnSearch As Button
   Friend WithEvents btnAll As Button
   Friend WithEvents btnExit As Button
End Class
