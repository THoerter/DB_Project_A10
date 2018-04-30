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
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.cobField = New System.Windows.Forms.ComboBox()
      Me.cobOp = New System.Windows.Forms.ComboBox()
      Me.txtValue = New System.Windows.Forms.TextBox()
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgvBooking
      '
      Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvBooking.Location = New System.Drawing.Point(30, 30)
      Me.dgvBooking.Name = "dgvBooking"
      Me.dgvBooking.Size = New System.Drawing.Size(560, 244)
      Me.dgvBooking.TabIndex = 0
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(620, 30)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 1
      Me.Button1.Text = "&Update"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(620, 104)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 2
      Me.Button2.Text = "&Search"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.Location = New System.Drawing.Point(620, 177)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(75, 23)
      Me.Button3.TabIndex = 3
      Me.Button3.Text = "&All"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button4
      '
      Me.Button4.Location = New System.Drawing.Point(620, 251)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(75, 23)
      Me.Button4.TabIndex = 4
      Me.Button4.Text = "&Exit"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'cobField
      '
      Me.cobField.FormattingEnabled = True
      Me.cobField.Items.AddRange(New Object() {"Hotel_No", "Room_No", "Guest_no", "Date_From", "Date_To"})
      Me.cobField.Location = New System.Drawing.Point(30, 314)
      Me.cobField.Name = "cobField"
      Me.cobField.Size = New System.Drawing.Size(121, 21)
      Me.cobField.TabIndex = 5
      '
      'cobOp
      '
      Me.cobOp.FormattingEnabled = True
      Me.cobOp.Items.AddRange(New Object() {">", ">=", "=", "<=", "<"})
      Me.cobOp.Location = New System.Drawing.Point(262, 314)
      Me.cobOp.Name = "cobOp"
      Me.cobOp.Size = New System.Drawing.Size(121, 21)
      Me.cobOp.TabIndex = 6
      '
      'txtValue
      '
      Me.txtValue.Location = New System.Drawing.Point(490, 315)
      Me.txtValue.Name = "txtValue"
      Me.txtValue.Size = New System.Drawing.Size(100, 20)
      Me.txtValue.TabIndex = 7
      '
      'FormClassBooking
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(722, 376)
      Me.Controls.Add(Me.cobOp)
      Me.Controls.Add(Me.cobField)
      Me.Controls.Add(Me.txtValue)
      Me.Controls.Add(Me.Button4)
      Me.Controls.Add(Me.Button3)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.dgvBooking)
      Me.Name = "FormClassBooking"
      Me.Text = "Assignment 10 - Samantha Murphy and Tanner Hoerter"
      CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents dgvBooking As DataGridView
   Friend WithEvents Button1 As Button
   Friend WithEvents Button2 As Button
   Friend WithEvents Button3 As Button
   Friend WithEvents Button4 As Button
   Friend WithEvents cobField As ComboBox
   Friend WithEvents cobOp As ComboBox
   Friend WithEvents txtValue As TextBox
End Class
