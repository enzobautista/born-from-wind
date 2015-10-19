<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btninfo = New System.Windows.Forms.Button
        Me.pbxencore = New System.Windows.Forms.PictureBox
        Me.lblencore = New System.Windows.Forms.Label
        Me.lblsolutions = New System.Windows.Forms.Label
        Me.btnsound = New ButtonSound.class1
        Me.btnsoundstop = New music_button.Class1
        Me.pbxmap1 = New System.Windows.Forms.PictureBox
        CType(Me.pbxencore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxmap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Born From Wind"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(240, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(240, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 50)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btninfo
        '
        Me.btninfo.BackColor = System.Drawing.Color.White
        Me.btninfo.Font = New System.Drawing.Font("Edwardian Script ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninfo.ForeColor = System.Drawing.Color.White
        Me.btninfo.Image = CType(resources.GetObject("btninfo.Image"), System.Drawing.Image)
        Me.btninfo.Location = New System.Drawing.Point(240, 230)
        Me.btninfo.Name = "btninfo"
        Me.btninfo.Size = New System.Drawing.Size(192, 50)
        Me.btninfo.TabIndex = 3
        Me.btninfo.Text = "Info"
        Me.btninfo.UseVisualStyleBackColor = False
        '
        'pbxencore
        '
        Me.pbxencore.Image = CType(resources.GetObject("pbxencore.Image"), System.Drawing.Image)
        Me.pbxencore.Location = New System.Drawing.Point(12, 360)
        Me.pbxencore.Name = "pbxencore"
        Me.pbxencore.Size = New System.Drawing.Size(78, 61)
        Me.pbxencore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxencore.TabIndex = 4
        Me.pbxencore.TabStop = False
        '
        'lblencore
        '
        Me.lblencore.AutoSize = True
        Me.lblencore.BackColor = System.Drawing.Color.Transparent
        Me.lblencore.Location = New System.Drawing.Point(96, 380)
        Me.lblencore.Name = "lblencore"
        Me.lblencore.Size = New System.Drawing.Size(41, 13)
        Me.lblencore.TabIndex = 5
        Me.lblencore.Text = "Encore"
        '
        'lblsolutions
        '
        Me.lblsolutions.AutoSize = True
        Me.lblsolutions.BackColor = System.Drawing.Color.Transparent
        Me.lblsolutions.Location = New System.Drawing.Point(96, 393)
        Me.lblsolutions.Name = "lblsolutions"
        Me.lblsolutions.Size = New System.Drawing.Size(50, 13)
        Me.lblsolutions.TabIndex = 6
        Me.lblsolutions.Text = "Solutions"
        '
        'btnsound
        '
        Me.btnsound.BackColor = System.Drawing.Color.Transparent
        Me.btnsound.BackgroundImage = CType(resources.GetObject("btnsound.BackgroundImage"), System.Drawing.Image)
        Me.btnsound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsound.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsound.FlatAppearance.BorderSize = 0
        Me.btnsound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsound.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsound.Location = New System.Drawing.Point(604, 45)
        Me.btnsound.Name = "btnsound"
        Me.btnsound.Size = New System.Drawing.Size(32, 32)
        Me.btnsound.TabIndex = 7
        Me.btnsound.UseVisualStyleBackColor = True
        '
        'btnsoundstop
        '
        Me.btnsoundstop.BackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop.BackgroundImage = CType(resources.GetObject("btnsoundstop.BackgroundImage"), System.Drawing.Image)
        Me.btnsoundstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsoundstop.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsoundstop.FlatAppearance.BorderSize = 0
        Me.btnsoundstop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnsoundstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsoundstop.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsoundstop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsoundstop.Location = New System.Drawing.Point(604, 44)
        Me.btnsoundstop.Name = "btnsoundstop"
        Me.btnsoundstop.Size = New System.Drawing.Size(32, 32)
        Me.btnsoundstop.TabIndex = 8
        Me.btnsoundstop.Text = "X"
        Me.btnsoundstop.UseVisualStyleBackColor = True
        '
        'pbxmap1
        '
        Me.pbxmap1.Image = CType(resources.GetObject("pbxmap1.Image"), System.Drawing.Image)
        Me.pbxmap1.Location = New System.Drawing.Point(0, -10)
        Me.pbxmap1.Name = "pbxmap1"
        Me.pbxmap1.Size = New System.Drawing.Size(687, 478)
        Me.pbxmap1.TabIndex = 9
        Me.pbxmap1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(672, 433)
        Me.Controls.Add(Me.btnsoundstop)
        Me.Controls.Add(Me.btnsound)
        Me.Controls.Add(Me.lblsolutions)
        Me.Controls.Add(Me.lblencore)
        Me.Controls.Add(Me.pbxencore)
        Me.Controls.Add(Me.btninfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxmap1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Born From Wind"
        CType(Me.pbxencore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxmap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btninfo As System.Windows.Forms.Button
    Friend WithEvents pbxencore As System.Windows.Forms.PictureBox
    Friend WithEvents lblencore As System.Windows.Forms.Label
    Friend WithEvents lblsolutions As System.Windows.Forms.Label
    Friend WithEvents btnsound As ButtonSound.class1
    Friend WithEvents btnsoundstop As music_button.Class1
    Friend WithEvents pbxmap1 As System.Windows.Forms.PictureBox
End Class
