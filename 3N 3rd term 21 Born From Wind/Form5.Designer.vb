<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnsound2 = New music_button.Class1
        Me.btnsoundstop2 = New music_button.Class1
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Born From Wind"
        '
        'btnsound2
        '
        Me.btnsound2.BackColor = System.Drawing.Color.Transparent
        Me.btnsound2.BackgroundImage = CType(resources.GetObject("btnsound2.BackgroundImage"), System.Drawing.Image)
        Me.btnsound2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsound2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsound2.FlatAppearance.BorderSize = 0
        Me.btnsound2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsound2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsound2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsound2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsound2.Location = New System.Drawing.Point(604, 44)
        Me.btnsound2.Name = "btnsound2"
        Me.btnsound2.Size = New System.Drawing.Size(32, 32)
        Me.btnsound2.TabIndex = 12
        Me.btnsound2.UseVisualStyleBackColor = True
        '
        'btnsoundstop2
        '
        Me.btnsoundstop2.BackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop2.BackgroundImage = CType(resources.GetObject("btnsoundstop2.BackgroundImage"), System.Drawing.Image)
        Me.btnsoundstop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsoundstop2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsoundstop2.FlatAppearance.BorderSize = 0
        Me.btnsoundstop2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsoundstop2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsoundstop2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsoundstop2.Location = New System.Drawing.Point(604, 44)
        Me.btnsoundstop2.Name = "btnsoundstop2"
        Me.btnsoundstop2.Size = New System.Drawing.Size(32, 32)
        Me.btnsoundstop2.TabIndex = 13
        Me.btnsoundstop2.Text = "X"
        Me.btnsoundstop2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Tan
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 445)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.Location = New System.Drawing.Point(12, 5)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(639, 10)
        Me.ProgressBarX1.TabIndex = 15
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 175
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(672, 433)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.btnsoundstop2)
        Me.Controls.Add(Me.btnsound2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsound2 As music_button.Class1
    Friend WithEvents btnsoundstop2 As music_button.Class1
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
