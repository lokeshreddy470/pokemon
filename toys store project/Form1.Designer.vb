<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PikachuTextBox = New System.Windows.Forms.TextBox()
        Me.SquirtleTextBox = New System.Windows.Forms.TextBox()
        Me.CharmanderTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Cost :"
        '
        'OutputLabel
        '
        Me.OutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OutputLabel.Location = New System.Drawing.Point(254, 222)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(100, 23)
        Me.OutputLabel.TabIndex = 3
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(119, 321)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(102, 23)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "CalculateButton"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pikachu :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Squirtle :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Charmander :"
        '
        'PikachuTextBox
        '
        Me.PikachuTextBox.Location = New System.Drawing.Point(253, 76)
        Me.PikachuTextBox.Name = "PikachuTextBox"
        Me.PikachuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PikachuTextBox.TabIndex = 8
        Me.PikachuTextBox.Text = "0"
        '
        'SquirtleTextBox
        '
        Me.SquirtleTextBox.Location = New System.Drawing.Point(253, 108)
        Me.SquirtleTextBox.Name = "SquirtleTextBox"
        Me.SquirtleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SquirtleTextBox.TabIndex = 9
        Me.SquirtleTextBox.Text = "0"
        '
        'CharmanderTextBox
        '
        Me.CharmanderTextBox.Location = New System.Drawing.Point(253, 145)
        Me.CharmanderTextBox.Name = "CharmanderTextBox"
        Me.CharmanderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CharmanderTextBox.TabIndex = 10
        Me.CharmanderTextBox.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(290, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CharmanderTextBox)
        Me.Controls.Add(Me.SquirtleTextBox)
        Me.Controls.Add(Me.PikachuTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents CalcButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PikachuTextBox As TextBox
    Friend WithEvents SquirtleTextBox As TextBox
    Friend WithEvents CharmanderTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
