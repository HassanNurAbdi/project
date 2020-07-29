<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splaashvb
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splaashvb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuProgressBar2 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(268, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 86)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Loading..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuProgressBar1.BorderRadius = 5
        Me.BunifuProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(0, 177)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(730, 25)
        Me.BunifuProgressBar1.TabIndex = 3
        Me.BunifuProgressBar1.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'BunifuProgressBar2
        '
        Me.BunifuProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BunifuProgressBar2.BorderRadius = 5
        Me.BunifuProgressBar2.Location = New System.Drawing.Point(0, 178)
        Me.BunifuProgressBar2.MaximumValue = 100
        Me.BunifuProgressBar2.Name = "BunifuProgressBar2"
        Me.BunifuProgressBar2.ProgressColor = System.Drawing.Color.Teal
        Me.BunifuProgressBar2.Size = New System.Drawing.Size(10, 25)
        Me.BunifuProgressBar2.TabIndex = 4
        Me.BunifuProgressBar2.Value = 0
        '
        'Splaashvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 202)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuProgressBar2)
        Me.Controls.Add(Me.BunifuProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Splaashvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splaashvb"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BunifuProgressBar2 As Bunifu.Framework.UI.BunifuProgressBar
End Class
