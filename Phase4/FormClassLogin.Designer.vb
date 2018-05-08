<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClassLogin
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
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.TextBox3 = New System.Windows.Forms.TextBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'TextBox1
      '
      Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox1.Location = New System.Drawing.Point(83, 21)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(191, 20)
      Me.TextBox1.TabIndex = 0
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(83, 55)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.TextBox2.Size = New System.Drawing.Size(191, 20)
      Me.TextBox2.TabIndex = 1
      '
      'TextBox3
      '
      Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox3.Location = New System.Drawing.Point(83, 87)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(191, 20)
      Me.TextBox3.TabIndex = 2
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(39, 133)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 3
      Me.Button1.Text = "&Login"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button2.Location = New System.Drawing.Point(163, 133)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 4
      Me.Button2.Text = "&Cancel"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(22, 24)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(55, 13)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "Username"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(22, 58)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(53, 13)
      Me.Label2.TabIndex = 6
      Me.Label2.Text = "Password"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(22, 90)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(29, 13)
      Me.Label3.TabIndex = 7
      Me.Label3.Text = "Host"
      '
      'FormClassLogin
      '
      Me.AcceptButton = Me.Button1
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Button2
      Me.ClientSize = New System.Drawing.Size(293, 182)
      Me.ControlBox = False
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.TextBox3)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.TextBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassLogin"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CS3630 Samantha Murphy, Tanner Hoerter"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents TextBox1 As TextBox
   Friend WithEvents TextBox2 As TextBox
   Friend WithEvents TextBox3 As TextBox
   Friend WithEvents Button1 As Button
   Friend WithEvents Button2 As Button
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
End Class
