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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        'btnGenerate
        '
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Location = New System.Drawing.Point(205, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 75)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(205, 81)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 75)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(205, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 75)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(294, 236)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lbOutputASCII)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lbInput)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(310, 275)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(310, 275)
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
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
