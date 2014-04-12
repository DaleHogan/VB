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
        Me.EnterAgeButton = New System.Windows.Forms.Button()
        Me.AgeListBox = New System.Windows.Forms.ListBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.EnterAgeLabel = New System.Windows.Forms.Label()
        Me.AgeValidatorLabel = New System.Windows.Forms.Label()
        Me.OldMemberButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnterAgeButton
        '
        Me.EnterAgeButton.Location = New System.Drawing.Point(318, 29)
        Me.EnterAgeButton.Name = "EnterAgeButton"
        Me.EnterAgeButton.Size = New System.Drawing.Size(103, 56)
        Me.EnterAgeButton.TabIndex = 0
        Me.EnterAgeButton.Text = "Submit"
        Me.EnterAgeButton.UseVisualStyleBackColor = True
        '
        'AgeListBox
        '
        Me.AgeListBox.FormattingEnabled = True
        Me.AgeListBox.Location = New System.Drawing.Point(167, 108)
        Me.AgeListBox.Name = "AgeListBox"
        Me.AgeListBox.Size = New System.Drawing.Size(246, 95)
        Me.AgeListBox.TabIndex = 1
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(167, 53)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 2
        '
        'EnterAgeLabel
        '
        Me.EnterAgeLabel.AutoSize = True
        Me.EnterAgeLabel.Location = New System.Drawing.Point(91, 55)
        Me.EnterAgeLabel.Name = "EnterAgeLabel"
        Me.EnterAgeLabel.Size = New System.Drawing.Size(60, 13)
        Me.EnterAgeLabel.TabIndex = 3
        Me.EnterAgeLabel.Text = "Enter Age: "
        '
        'AgeValidatorLabel
        '
        Me.AgeValidatorLabel.AutoSize = True
        Me.AgeValidatorLabel.ForeColor = System.Drawing.Color.Red
        Me.AgeValidatorLabel.Location = New System.Drawing.Point(463, 54)
        Me.AgeValidatorLabel.Name = "AgeValidatorLabel"
        Me.AgeValidatorLabel.Size = New System.Drawing.Size(0, 13)
        Me.AgeValidatorLabel.TabIndex = 4
        Me.AgeValidatorLabel.Visible = False
        '
        'OldMemberButton
        '
        Me.OldMemberButton.Location = New System.Drawing.Point(167, 300)
        Me.OldMemberButton.Name = "OldMemberButton"
        Me.OldMemberButton.Size = New System.Drawing.Size(103, 56)
        Me.OldMemberButton.TabIndex = 5
        Me.OldMemberButton.Text = "Find Oldest Member"
        Me.OldMemberButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(299, 299)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(103, 56)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 500)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OldMemberButton)
        Me.Controls.Add(Me.AgeValidatorLabel)
        Me.Controls.Add(Me.EnterAgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.AgeListBox)
        Me.Controls.Add(Me.EnterAgeButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnterAgeButton As System.Windows.Forms.Button
    Friend WithEvents AgeListBox As System.Windows.Forms.ListBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnterAgeLabel As System.Windows.Forms.Label
    Friend WithEvents AgeValidatorLabel As System.Windows.Forms.Label
    Friend WithEvents OldMemberButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
