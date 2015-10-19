<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnFront = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(221, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Born From Wind"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(126, 205)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 39)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFront
        '
        Me.btnFront.Location = New System.Drawing.Point(281, 205)
        Me.btnFront.Name = "btnFront"
        Me.btnFront.Size = New System.Drawing.Size(99, 39)
        Me.btnFront.TabIndex = 14
        Me.btnFront.Text = "Front"
        Me.btnFront.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "The captain decides to test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "you on your competency."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Which part of the ship is the stern?"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._3N_3rd_term_21_Born_From_Wind.My.Resources.Resources.vladstudio_world_map_small_towns_1600x1200
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 294)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFront)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFront As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
