<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOrion = New System.Windows.Forms.Button
        Me.btnBdipper = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Trial for First Mate: Ursula Major is also known as?"
        '
        'btnOrion
        '
        Me.btnOrion.Location = New System.Drawing.Point(187, 172)
        Me.btnOrion.Name = "btnOrion"
        Me.btnOrion.Size = New System.Drawing.Size(94, 47)
        Me.btnOrion.TabIndex = 40
        Me.btnOrion.Text = "Orion"
        Me.btnOrion.UseVisualStyleBackColor = True
        '
        'btnBdipper
        '
        Me.btnBdipper.Location = New System.Drawing.Point(58, 172)
        Me.btnBdipper.Name = "btnBdipper"
        Me.btnBdipper.Size = New System.Drawing.Size(109, 47)
        Me.btnBdipper.TabIndex = 39
        Me.btnBdipper.Text = "The Big Dipper"
        Me.btnBdipper.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(247, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Born From Wind"
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrion)
        Me.Controls.Add(Me.btnBdipper)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOrion As System.Windows.Forms.Button
    Friend WithEvents btnBdipper As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
