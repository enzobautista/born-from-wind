<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.btnSkipper = New System.Windows.Forms.Button
        Me.btnMate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "What do you call me?"
        '
        'btnSkipper
        '
        Me.btnSkipper.Location = New System.Drawing.Point(215, 166)
        Me.btnSkipper.Name = "btnSkipper"
        Me.btnSkipper.Size = New System.Drawing.Size(94, 47)
        Me.btnSkipper.TabIndex = 28
        Me.btnSkipper.Text = "Skipper"
        Me.btnSkipper.UseVisualStyleBackColor = True
        '
        'btnMate
        '
        Me.btnMate.Location = New System.Drawing.Point(86, 166)
        Me.btnMate.Name = "btnMate"
        Me.btnMate.Size = New System.Drawing.Size(109, 47)
        Me.btnMate.TabIndex = 27
        Me.btnMate.Text = "Mate"
        Me.btnMate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(215, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Born From Wind"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._3N_3rd_term_21_Born_From_Wind.My.Resources.Resources.vladstudio_world_map_small_towns_1600x1200
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSkipper)
        Me.Controls.Add(Me.btnMate)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form12"
        Me.Text = "Form12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSkipper As System.Windows.Forms.Button
    Friend WithEvents btnMate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
