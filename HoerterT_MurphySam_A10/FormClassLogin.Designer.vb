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
      Me.btnLogin = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.TextBox3 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'btnLogin
      '
      Me.btnLogin.Location = New System.Drawing.Point(282, 436)
      Me.btnLogin.Name = "btnLogin"
      Me.btnLogin.Size = New System.Drawing.Size(75, 23)
      Me.btnLogin.TabIndex = 0
      Me.btnLogin.Text = "&Login"
      Me.btnLogin.UseVisualStyleBackColor = True
      '
      'btnCancel
      '
      Me.btnCancel.Location = New System.Drawing.Point(425, 436)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 23)
      Me.btnCancel.TabIndex = 1
      Me.btnCancel.Text = "&Cancel"
      Me.btnCancel.UseVisualStyleBackColor = True
      '
      'TextBox1
      '
      Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox1.Location = New System.Drawing.Point(400, 80)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(100, 20)
      Me.TextBox1.TabIndex = 2
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(400, 200)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.TextBox2.Size = New System.Drawing.Size(100, 20)
      Me.TextBox2.TabIndex = 1
      '
      'TextBox3
      '
      Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox3.Location = New System.Drawing.Point(400, 330)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(100, 20)
      Me.TextBox3.TabIndex = 4
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(279, 80)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(57, 13)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "UserName"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(279, 200)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(53, 13)
      Me.Label2.TabIndex = 6
      Me.Label2.Text = "Password"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(279, 330)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(59, 13)
      Me.Label3.TabIndex = 7
      Me.Label3.Text = "Host String"
      '
      'FormClassLogin
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(824, 593)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TextBox3)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.btnCancel)
      Me.Controls.Add(Me.btnLogin)
      Me.Name = "FormClassLogin"
      Me.Text = "Login - Samantha Murphy and Tanner Hoerter"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btnLogin As Button
   Friend WithEvents btnCancel As Button
   Friend WithEvents TextBox1 As TextBox
   Friend WithEvents TextBox2 As TextBox
   Friend WithEvents TextBox3 As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
End Class
