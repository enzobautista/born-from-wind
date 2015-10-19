<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.btnDeck = New System.Windows.Forms.Button
        Me.btnFmate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Congratulations your captain finds you worthy enough!"
        '
        'btnDeck
        '
        Me.btnDeck.Location = New System.Drawing.Point(201, 172)
        Me.btnDeck.Name = "btnDeck"
        Me.btnDeck.Size = New System.Drawing.Size(94, 47)
        Me.btnDeck.TabIndex = 36
        Me.btnDeck.Text = "Remain a deckhand forever"
        Me.btnDeck.UseVisualStyleBackColor = True
        '
        'btnFmate
        '
        Me.btnFmate.Location = New System.Drawing.Point(72, 172)
        Me.btnFmate.Name = "btnFmate"
        Me.btnFmate.Size = New System.Drawing.Size(109, 47)
        Me.btnFmate.TabIndex = 35
        Me.btnFmate.Text = "Try for first mate"
        Me.btnFmate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Born From Wind"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "(Event achieved: Deckhand)"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._3N_3rd_term_21_Born_From_Wind.My.Resources.Resources.vladstudio_world_map_small_towns_1600x1200
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 294)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeck)
        Me.Controls.Add(Me.btnFmate)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form14"
        Me.Text = "Form14"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDeck As System.Windows.Forms.Button
    Friend WithEvents btnFmate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
