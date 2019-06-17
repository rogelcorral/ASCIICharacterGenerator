<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbInput = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbOutputASCII = New System.Windows.Forms.Label()
        Me.tbGenerate = New System.Windows.Forms.Button()
        Me.tbReset = New System.Windows.Forms.Button()
        Me.tbExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbInput
        '
        Me.lbInput.AutoSize = True
        Me.lbInput.Location = New System.Drawing.Point(13, 13)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(85, 13)
        Me.lbInput.TabIndex = 0
        Me.lbInput.Text = "Input an Integer:"
        Me.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(16, 40)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(100, 20)
        Me.tbInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The equivalent ASCII character is:"
        '
        'lbOutputASCII
        '
        Me.lbOutputASCII.BackColor = System.Drawing.Color.White
        Me.lbOutputASCII.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutputASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbOutputASCII.Font = New System.Drawing.Font("Times New Roman", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOutputASCII.Location = New System.Drawing.Point(13, 111)
        Me.lbOutputASCII.Name = "lbOutputASCII"
        Me.lbOutputASCII.Size = New System.Drawing.Size(100, 97)
        Me.lbOutputASCII.TabIndex = 3
        Me.lbOutputASCII.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGenerate
        '
        Me.tbGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbGenerate.Location = New System.Drawing.Point(205, 12)
        Me.tbGenerate.Name = "tbGenerate"
        Me.tbGenerate.Size = New System.Drawing.Size(75, 75)
        Me.tbGenerate.TabIndex = 4
        Me.tbGenerate.Text = "Generate"
        Me.tbGenerate.UseVisualStyleBackColor = True
        '
        'tbReset
        '
        Me.tbReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tbReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbReset.Location = New System.Drawing.Point(205, 81)
        Me.tbReset.Name = "tbReset"
        Me.tbReset.Size = New System.Drawing.Size(75, 75)
        Me.tbReset.TabIndex = 5
        Me.tbReset.Text = "Reset"
        Me.tbReset.UseVisualStyleBackColor = True
        '
        'tbExit
        '
        Me.tbExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbExit.Location = New System.Drawing.Point(205, 149)
        Me.tbExit.Name = "tbExit"
        Me.tbExit.Size = New System.Drawing.Size(75, 75)
        Me.tbExit.TabIndex = 6
        Me.tbExit.Text = "Exit"
        Me.tbExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.tbGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.tbReset
        Me.ClientSize = New System.Drawing.Size(294, 236)
        Me.Controls.Add(Me.tbExit)
        Me.Controls.Add(Me.tbReset)
        Me.Controls.Add(Me.tbGenerate)
        Me.Controls.Add(Me.lbOutputASCII)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lbInput)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASCII Character Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInput As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbOutputASCII As Label
    Friend WithEvents tbGenerate As Button
    Friend WithEvents tbReset As Button
    Friend WithEvents tbExit As Button
End Class
