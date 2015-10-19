<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnMain = New System.Windows.Forms.Button
        Me.btnJib = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(231, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Born From Wind"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Which line controls the largest sail?"
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(231, 167)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(94, 47)
        Me.btnMain.TabIndex = 20
        Me.btnMain.Text = "Main Sheet"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnJib
        '
        Me.btnJib.Location = New System.Drawing.Point(102, 167)
        Me.btnJib.Name = "btnJib"
        Me.btnJib.Size = New System.Drawing.Size(109, 47)
        Me.btnJib.TabIndex = 19
        Me.btnJib.Text = "Jib Sheet"
        Me.btnJib.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._3N_3rd_term_21_Born_From_Wind.My.Resources.Resources.vladstudio_world_map_small_towns_1600x1200
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 294)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnJib)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnJib As System.Windows.Forms.Button
End Class
