<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.pbxcompass = New System.Windows.Forms.PictureBox
        Me.Tbxcheat = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblenablecheat = New System.Windows.Forms.Label
        Me.lblcheatenabled = New System.Windows.Forms.Label
        CType(Me.pbxcompass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxcompass
        '
        Me.pbxcompass.BackColor = System.Drawing.Color.Transparent
        Me.pbxcompass.Image = CType(resources.GetObject("pbxcompass.Image"), System.Drawing.Image)
        Me.pbxcompass.Location = New System.Drawing.Point(28, 27)
        Me.pbxcompass.Name = "pbxcompass"
        Me.pbxcompass.Size = New System.Drawing.Size(256, 248)
        Me.pbxcompass.TabIndex = 0
        Me.pbxcompass.TabStop = False
        '
        'Tbxcheat
        '
        '
        '
        '
        Me.Tbxcheat.Border.Class = "TextBoxBorder"
        Me.Tbxcheat.Location = New System.Drawing.Point(340, 130)
        Me.Tbxcheat.Name = "Tbxcheat"
        Me.Tbxcheat.Size = New System.Drawing.Size(192, 20)
        Me.Tbxcheat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(290, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "What star is used by explorers to navigate their surroundings? "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(337, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Clue: It is also known as the Northern Star)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(409, 78)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Born From Wind"
        '
        'lblenablecheat
        '
        Me.lblenablecheat.AutoSize = True
        Me.lblenablecheat.BackColor = System.Drawing.Color.Transparent
        Me.lblenablecheat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblenablecheat.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenablecheat.Location = New System.Drawing.Point(290, 10)
        Me.lblenablecheat.Name = "lblenablecheat"
        Me.lblenablecheat.Size = New System.Drawing.Size(234, 59)
        Me.lblenablecheat.TabIndex = 6
        Me.lblenablecheat.Text = "Enable Cheat"
        '
        'lblcheatenabled
        '
        Me.lblcheatenabled.AutoSize = True
        Me.lblcheatenabled.BackColor = System.Drawing.Color.Transparent
        Me.lblcheatenabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcheatenabled.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheatenabled.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblcheatenabled.Location = New System.Drawing.Point(290, 10)
        Me.lblcheatenabled.Name = "lblcheatenabled"
        Me.lblcheatenabled.Size = New System.Drawing.Size(251, 59)
        Me.lblcheatenabled.TabIndex = 7
        Me.lblcheatenabled.Text = "Cheat Enabled"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(674, 296)
        Me.Controls.Add(Me.lblcheatenabled)
        Me.Controls.Add(Me.lblenablecheat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbxcheat)
        Me.Controls.Add(Me.pbxcompass)
        Me.Name = "Form4"
        Me.Text = "Sub"
        CType(Me.pbxcompass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxcompass As System.Windows.Forms.PictureBox
    Friend WithEvents Tbxcheat As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblenablecheat As System.Windows.Forms.Label
    Friend WithEvents lblcheatenabled As System.Windows.Forms.Label
End Class
