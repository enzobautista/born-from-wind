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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblload = New System.Windows.Forms.Label
        Me.lblpresent = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'lblload
        '
        Me.lblload.AutoSize = True
        Me.lblload.ForeColor = System.Drawing.Color.White
        Me.lblload.Location = New System.Drawing.Point(22, 261)
        Me.lblload.Name = "lblload"
        Me.lblload.Size = New System.Drawing.Size(45, 13)
        Me.lblload.TabIndex = 2
        Me.lblload.Text = "Loading"
        '
        'lblpresent
        '
        Me.lblpresent.AutoSize = True
        Me.lblpresent.BackColor = System.Drawing.Color.Transparent
        Me.lblpresent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpresent.ForeColor = System.Drawing.Color.White
        Me.lblpresent.Location = New System.Drawing.Point(120, 206)
        Me.lblpresent.Name = "lblpresent"
        Me.lblpresent.Size = New System.Drawing.Size(0, 18)
        Me.lblpresent.TabIndex = 3
        '
        'Timer2
        '
        Me.Timer2.Interval = 70
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(165, 261)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(10, 10)
        Me.ProgressBar2.TabIndex = 4
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.Location = New System.Drawing.Point(137, 261)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBarX1.TabIndex = 7
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(370, 287)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.lblpresent)
        Me.Controls.Add(Me.lblload)
        Me.Controls.Add(Me.ProgressBar2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Born From Wind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblload As System.Windows.Forms.Label
    Friend WithEvents lblpresent As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX

End Class
